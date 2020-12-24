using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Social.Data;
using Social.DTO;

namespace Social.Controllers
{


    // api/posts
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepo repository;
        private readonly IMapper mapper;

        //private readonly PostRepo _repository = new PostRepo();

        public PostController(IPostRepo _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }
        [HttpGet]
        public ActionResult<List<PostRepo>> getAllPost()
        {
            var list_post = repository.GetPosts();
            if (list_post == null) return new List<PostRepo>();
            return Ok(mapper.Map<IEnumerable<PostRepo>>(list_post));
        }
        [HttpGet("{id}")]
        public ActionResult<PostRepo> getPostById(int id)
        {
            
            var post_item = repository.GetPostById(id);
            if (post_item == null) return NotFound();
            return Ok(mapper.Map<PostDTO>(post_item));
        }
    }
}