using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class PostsLive
    {
        public int LiveId { get; set; }
        public int PostId { get; set; }
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
