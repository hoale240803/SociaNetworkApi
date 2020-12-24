using System;
using System.Collections.Generic;
using Social.Models;

namespace Social.Data
{
    public class PostRepo : IPostRepo
    {
        public Post GetPostById(int id)
        {
            return new Post { post_id = 01, user_id = 01, comment = 01, time = DateTime.Now.ToString() };
        }

        public IEnumerable<Post> GetPosts()
        {
            return new List<Post> {
            new Post { post_id = 01, user_id = 01, comment = 01, time=DateTime.Now.ToString()},
            new Post { post_id = 02, user_id = 02, comment = 02, time = DateTime.Now.ToString() },
            new Post { post_id = 03, user_id = 03, comment = 03, time = DateTime.Now.ToString() }
        };
        }
    }
}