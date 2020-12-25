using System;
using System.Collections.Generic;

#nullable disable

namespace SocialAPI.Models
{
    public partial class AdsCampaign
    {
        public int CampaignId { get; set; }
        public uint CampaignUserId { get; set; }
        public string CampaignTitle { get; set; }
        public DateTime CampaignStartDate { get; set; }
        public DateTime CampaignEndDate { get; set; }
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
        public uint? AdsPage { get; set; }
        public uint? AdsGroup { get; set; }
        public uint? AdsEvent { get; set; }
        public string AdsPlacement { get; set; }
        public string AdsImage { get; set; }
        public DateTime CampaignCreatedDate { get; set; }
        public string CampaignIsActive { get; set; }
        public uint CampaignViews { get; set; }
        public uint CampaignClicks { get; set; }
    }
}
