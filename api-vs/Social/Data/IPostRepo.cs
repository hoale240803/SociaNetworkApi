using System.Collections.Generic;
using Social.Models;

namespace Social.Data
{
    public interface IPostRepo
    {
        IEnumerable<Post> GetPosts();
        Post GetPostById(int id);
    }
}