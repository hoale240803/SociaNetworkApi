using AutoMapper;
using Social.DTO;
using Social.Models;

namespace Social.Profiles
{
    public class PostProfile: Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostDTO>();
        }
    }
}
