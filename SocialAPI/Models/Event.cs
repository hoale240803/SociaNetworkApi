using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class Event
    {
        public uint EventId { get; set; }
        public string EventPrivacy { get; set; }
        public uint EventAdmin { get; set; }
        public uint EventCategory { get; set; }
        public string EventTitle { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
        public string EventPublishEnabled { get; set; }
        public string EventPublishApprovalEnabled { get; set; }
        public string EventCover { get; set; }
        public uint? EventCoverId { get; set; }
        public string EventCoverPosition { get; set; }
        public int? EventAlbumCovers { get; set; }
        public int? EventAlbumTimeline { get; set; }
        public int? EventPinnedPost { get; set; }
        public uint EventInvited { get; set; }
        public uint EventInterested { get; set; }
        public uint EventGoing { get; set; }
        public DateTime EventDate { get; set; }
    }
}
