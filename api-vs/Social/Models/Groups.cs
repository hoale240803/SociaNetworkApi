using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Groups
    {
        public int GroupId { get; set; }
        public string GroupPrivacy { get; set; }
        public int GroupAdmin { get; set; }
        public int GroupCategory { get; set; }
        public string GroupName { get; set; }
        public string GroupTitle { get; set; }
        public string GroupDescription { get; set; }
        public string GroupPublishEnabled { get; set; }
        public string GroupPublishApprovalEnabled { get; set; }
        public string GroupPicture { get; set; }
        public int? GroupPictureId { get; set; }
        public string GroupCover { get; set; }
        public int? GroupCoverId { get; set; }
        public string GroupCoverPosition { get; set; }
        public int? GroupAlbumPictures { get; set; }
        public int? GroupAlbumCovers { get; set; }
        public int? GroupAlbumTimeline { get; set; }
        public int? GroupPinnedPost { get; set; }
        public int GroupMembers { get; set; }
    }
}
