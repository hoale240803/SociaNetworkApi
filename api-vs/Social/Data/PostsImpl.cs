
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Social.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Social.Data
{
    public class PostsImpl : IPosts
    {
        private readonly socialdbContext db;
        private readonly IMapper mapper;

        public PostsImpl(socialdbContext _db, IMapper _mapper)
        {
            db = _db;
            mapper = _mapper;
        }


        public async Task<List<Posts>> GetPosts()
        {
            if (db == null)
            {
                return null;
            }

            return await db.Posts.ToListAsync();

        }

        public async Task<Posts> GetPost(int? postId)
        {

            var post_item = db.Posts.Find(postId);
            if (post_item == null)
                throw new PgpException("Posts not found.");
            return post_item;
        }

        public async Task<int> AddPost(Posts post)
        {
            if (db != null)
            {
                await db.Posts.AddAsync(post);
                await db.SaveChangesAsync();

                return post.PostId;
            }

            return 0;
        }

        public async Task<int> DeletePost(int? postId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var post = await db.Posts.FirstOrDefaultAsync(x => x.PostId == postId);

                if (post != null)
                {
                    //Delete that post
                    db.Posts.Remove(post);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }


        public async Task UpdatePost(Posts post)
        {
            if (db != null)
            {
                //Delete that post
                //db.Posts.Update(post);
                db.Entry(post).State = EntityState.Modified;
                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }
        public async Task PatchPost(JsonPatchDocument<Posts>  post, int id)
        {
            if (db != null)
            {
                var postNeedToUpdate = db.Posts.Find(id);
                post.ApplyTo(postNeedToUpdate);

                db.Update(postNeedToUpdate);
                await db.SaveChangesAsync();        
            }
        }

    }
}
