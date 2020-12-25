using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SocialAPI.Data;
using SocialAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SocialAPI", Version = "v1" });
            });
            // ### enable pomelo mysql
            services.AddDbContext<socialdbContext>(item => item.UseMySql(Configuration.GetConnectionString("SocialDBConnection"), new MySqlServerVersion(new Version(8, 0, 21))));
            //services.AddDbContextPool<socialdbContext>(
            //   dbContextOptions => dbContextOptions
            //       .UseMySql(
            //           // Replace with your connection string.
            //           "server=localhost;user=root;password=1234;database=",
            //           // Replace with your server version and type.
            //           // For common usages, see pull request #1233.
            //           new MySqlServerVersion(new Version(8, 0, 21)), // use MariaDbServerVersion for MariaDB
            //           mySqlOptions => mySqlOptions
            //               .CharSetBehavior(CharSetBehavior.NeverAppend))
            //       // Everything from this point on is optional but helps with debugging.
            //       .EnableSensitiveDataLogging()
            //       .EnableDetailedErrors();
            
            // ### Add application services.
            services.AddScoped<IPosts, PostsImpl>();
            // enable cors
            services.AddCors(option => option.AddPolicy("MyBlogPolicy", builder => {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();

            
            }));
            //enable auto mapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SocialAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            // enable cors
            app.UseCors("MyBlogPolicy");
        }
    }
}
