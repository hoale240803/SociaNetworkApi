using AutoMapper;
using SocialAPI.DTO;
using SocialAPI.Models;

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
