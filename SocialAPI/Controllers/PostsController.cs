using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using SocialAPI.Models;
using SocialAPI.Data;
using Microsoft.AspNetCore.JsonPatch;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Social.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPosts postRepository;
        public PostsController(IPosts _postRepository)
        {
            postRepository = _postRepository;
        }


        // GET api/<PostsController>/5
        [HttpGet]
        [Route("GetPosts")]
        public async Task<IActionResult> GetPosts()
        {
            try
            {
                var posts = await postRepository.GetPosts();
                if (posts == null)
                {
                    return NotFound();
                }

                return Ok(posts);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetPostById")]
        public async Task<IActionResult> GetPostById(uint? postId)
        {
            if (postId == null)
            {
                return BadRequest();
            }

            try
            {
                var post = await postRepository.GetPost(postId);

                if (post == null)
                {
                    return NotFound();
                }

                return Ok(post);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        // POST api/<PostsController>
        [HttpPost]
        [Route("AddPost")]
        public async Task<IActionResult> AddPost([FromBody] Post model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var postId = await postRepository.AddPost(model);
                    if (postId > 0)
                    {
                        return Ok("Adding Post Succesful! "+postId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Data.ToString());
                    return BadRequest();
                }

            }

            return BadRequest();
        }
        // PUT api/<PostsController>/5
        [HttpPut]
        [Route("UpdatePost")]
        public async Task<IActionResult> UpdatePost([FromBody] Post model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await postRepository.UpdatePost(model);

                    return Ok("Updating Post Succesful!");
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }
        // DELETE api/<PostsController>/5
        [HttpDelete]
        [Route("DeletePost")]
        public async Task<IActionResult> DeletePost(uint? postId)
        {
            int result = 0;

            if (postId == null)
            {
                return BadRequest();
            }

            try
            {
                result = (int)await postRepository.DeletePost(postId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok("Deleting Post Succesful!");
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPatch]
        [Route("EditPost")]
        public IActionResult JsonPatchWithModelState([FromBody] JsonPatchDocument<Post> patchDoc)
        {
            if (patchDoc != null)
            {
                var post = new Post();

                patchDoc.ApplyTo(post, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                return new ObjectResult(post);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult EditPatialPost( [FromBody] JsonPatchDocument<Post> post, uint id)
        {
            if (post == null) { return BadRequest(); }
            try
            {
                postRepository.PatchPost(post,id);
                return Ok("update post sucessful!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Data);
                return BadRequest(e.Message);
            }
        }
    }
}



