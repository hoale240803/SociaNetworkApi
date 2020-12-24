namespace Social.Models
{
    public class Post
    {
        public int post_id { set; get; }
        public int user_id { set; get; }
        public enum user_type { User, Pages }
        public enum in_group { zero, one }
        public int group_id { set; get; }
        public enum group_approved { zero, one }
        public enum in_event { zero, one }
        public int event_id { set; get; }
        public enum event_approved { zero, one }
        public enum in_wall { zero, one }
        public int wall_id { set; get; }
        public string post_type { set; get; }
        public int colored_pattern { set; get; }
        public int origin_id { set; get; }
        public string time { set; get; }
        public string location { set; get; }
        public string privacy { set; get; }
        public string longtext { set; get; }
        public string feeling_action { set; get; }
        public string feeling_value { set; get; }
        public enum boosted { zero, one }
        public int boosted_by { set; get; }
        public enum comments_disabled { zero, one }
        public enum is_hidden { zero, one }
        public enum is_anonymous { zero, one }
        public int reaction_like_count { set; get; }
        public int reaction_love_count { set; get; }
        public int reaction_haha_count { set; get; }
        public int reaction_yay_count { set; get; }
        public int reaction_wow_count { set; get; }
        public int reaction_sad_count { set; get; }
        public int reaction_angry_count { set; get; }
        public int comment { set; get; }
        public int shares { set; get; }
        public enum pos_earned { zero, one }
    }
}