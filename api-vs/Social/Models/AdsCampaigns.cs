using System;
using System.Collections.Generic;

namespace Social.Models
{
    public partial class AdsCampaigns
    {
        public int CampaignId { get; set; }
        public int CampaignUserId { get; set; }
        public string CampaignTitle { get; set; }
        public double CampaignBudget { get; set; }
        public double CampaignSpend { get; set; }
        public string CampaignBidding { get; set; }
        public string AudienceCountries { get; set; }
        public string AudienceGender { get; set; }
        public string AudienceRelationship { get; set; }
        public string AdsTitle { get; set; }
        public string AdsDescription { get; set; }
        public string AdsType { get; set; }
        public string AdsUrl { get; set; }
        public int? AdsPage { get; set; }
        public int? AdsGroup { get; set; }
        public int? AdsEvent { get; set; }
        public string AdsPlacement { get; set; }
        public string AdsImage { get; set; }
        public string CampaignIsActive { get; set; }
        public int CampaignViews { get; set; }
        public int CampaignClicks { get; set; }
    }
}
