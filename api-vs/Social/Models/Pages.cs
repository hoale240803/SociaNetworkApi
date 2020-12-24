using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Pages
    {
        public int PageId { get; set; }
        public int PageAdmin { get; set; }
        public int PageCategory { get; set; }
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public string PagePicture { get; set; }
        public int? PagePictureId { get; set; }
        public string PageCover { get; set; }
        public int? PageCoverId { get; set; }
        public string PageCoverPosition { get; set; }
        public int? PageAlbumPictures { get; set; }
        public int? PageAlbumCovers { get; set; }
        public int? PageAlbumTimeline { get; set; }
        public int? PagePinnedPost { get; set; }
        public string PageVerified { get; set; }
        public string PageBoosted { get; set; }
        public int? PageBoostedBy { get; set; }
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
        public int PageLikes { get; set; }
    }
}
