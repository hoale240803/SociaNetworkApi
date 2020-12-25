using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Page
    {
        public uint PageId { get; set; }
        public uint PageAdmin { get; set; }
        public uint PageCategory { get; set; }
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public string PagePicture { get; set; }
        public uint? PagePictureId { get; set; }
        public string PageCover { get; set; }
        public uint? PageCoverId { get; set; }
        public string PageCoverPosition { get; set; }
        public uint? PageAlbumPictures { get; set; }
        public uint? PageAlbumCovers { get; set; }
        public uint? PageAlbumTimeline { get; set; }
        public uint? PagePinnedPost { get; set; }
        public string PageVerified { get; set; }
        public string PageBoosted { get; set; }
        public uint? PageBoostedBy { get; set; }
        public string PageCompany { get; set; }
        public string PagePhone { get; set; }
        public string PageWebsite { get; set; }
        public string PageLocation { get; set; }
        public string PageDescription { get; set; }
        public string PageActionText { get; set; }
        public string PageActionColor { get; set; }
        public string PageActionUrl { get; set; }
        public string PageSocialFacebook { get; set; }
        public string PageSocialTwitter { get; set; }
        public string PageSocialYoutube { get; set; }
        public string PageSocialInstagram { get; set; }
        public string PageSocialLinkedin { get; set; }
        public string PageSocialVkontakte { get; set; }
        public uint PageLikes { get; set; }
        public DateTime PageDate { get; set; }
    }
}
