using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class Events
    {
        public int EventId { get; set; }
        public string EventPrivacy { get; set; }
        public int EventAdmin { get; set; }
        public int EventCategory { get; set; }
        public string EventTitle { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public string EventPublishEnabled { get; set; }
        public string EventPublishApprovalEnabled { get; set; }
        public string EventCover { get; set; }
        public int? EventCoverId { get; set; }
        public string EventCoverPosition { get; set; }
        public int? EventAlbumCovers { get; set; }
        public int? EventAlbumTimeline { get; set; }
        public int? EventPinnedPost { get; set; }
        public int EventInvited { get; set; }
        public int EventInterested { get; set; }
        public int EventGoing { get; set; }
    }
}
