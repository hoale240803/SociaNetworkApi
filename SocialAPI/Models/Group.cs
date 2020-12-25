using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Group
    {
        public uint GroupId { get; set; }
        public string GroupPrivacy { get; set; }
        public uint GroupAdmin { get; set; }
        public uint GroupCategory { get; set; }
        public string GroupName { get; set; }
        public string GroupTitle { get; set; }
        public string GroupDescription { get; set; }
        public string GroupPublishEnabled { get; set; }
        public string GroupPublishApprovalEnabled { get; set; }
        public string GroupPicture { get; set; }
        public uint? GroupPictureId { get; set; }
        public string GroupCover { get; set; }
        public uint? GroupCoverId { get; set; }
        public string GroupCoverPosition { get; set; }
        public int? GroupAlbumPictures { get; set; }
        public int? GroupAlbumCovers { get; set; }
        public int? GroupAlbumTimeline { get; set; }
        public int? GroupPinnedPost { get; set; }
        public uint GroupMembers { get; set; }
        public DateTime GroupDate { get; set; }
    }
}
