using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class PostsLive
    {
        public uint LiveId { get; set; }
        public uint PostId { get; set; }
        public string VideoThumbnail { get; set; }
        public int AgoraUid { get; set; }
        public string AgoraChannelName { get; set; }
        public string AgoraResourceId { get; set; }
        public string AgoraSid { get; set; }
        public string AgoraFile { get; set; }
        public string LiveEnded { get; set; }
        public string LiveRecorded { get; set; }
    }
}
