using Microsoft.AspNetCore.JsonPatch;
using SocialAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialAPI.Data
{
    public interface IPosts
    {

        Task<List<Post>> GetPosts();

        Task<Post> GetPost(uint? postId);

        Task<uint> AddPost(Post post);

        Task<uint> DeletePost(uint? postId);

        Task UpdatePost(Post post);

        Task PatchPost(JsonPatchDocument<Post> post, uint id);
    }
}
