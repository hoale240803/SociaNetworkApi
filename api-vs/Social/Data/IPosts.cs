using Microsoft.AspNetCore.JsonPatch;
using Social.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Social.Data
{
    public interface IPosts
    {

        Task<List<Posts>> GetPosts();

        Task<Posts> GetPost(int? postId);

        Task<int> AddPost(Posts post);

        Task<int> DeletePost(int? postId);

        Task UpdatePost(Posts post);

        Task PatchPost(JsonPatchDocument<Posts> post, int id);
    }
}
