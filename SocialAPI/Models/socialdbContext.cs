using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SocialAPI.Models
{
    public partial class socialdbContext : DbContext
    {
        public socialdbContext()
        {
        }

        public socialdbContext(DbContextOptions<socialdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdsCampaign> AdsCampaigns { get; set; }
        public virtual DbSet<AdsSystem> AdsSystems { get; set; }
        public virtual DbSet<AdsUsersWalletTransaction> AdsUsersWalletTransactions { get; set; }
        public virtual DbSet<AffiliatesPayment> AffiliatesPayments { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<AnnouncementsUser> AnnouncementsUsers { get; set; }
        public virtual DbSet<BankTransfer> BankTransfers { get; set; }
        public virtual DbSet<Blacklist> Blacklists { get; set; }
        public virtual DbSet<BlogsCategory> BlogsCategories { get; set; }
        public virtual DbSet<CoinpaymentsTransaction> CoinpaymentsTransactions { get; set; }
        public virtual DbSet<Conversation> Conversations { get; set; }
        public virtual DbSet<ConversationsCallsAudio> ConversationsCallsAudios { get; set; }
        public virtual DbSet<ConversationsCallsVideo> ConversationsCallsVideos { get; set; }
        public virtual DbSet<ConversationsMessage> ConversationsMessages { get; set; }
        public virtual DbSet<ConversationsUser> ConversationsUsers { get; set; }
        public virtual DbSet<CustomField> CustomFields { get; set; }
        public virtual DbSet<CustomFieldsValue> CustomFieldsValues { get; set; }
        public virtual DbSet<DevelopersApp> DevelopersApps { get; set; }
        public virtual DbSet<DevelopersAppsCategory> DevelopersAppsCategories { get; set; }
        public virtual DbSet<DevelopersAppsUser> DevelopersAppsUsers { get; set; }
        public virtual DbSet<Emoji> Emojis { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventsCategory> EventsCategories { get; set; }
        public virtual DbSet<EventsMember> EventsMembers { get; set; }
        public virtual DbSet<Following> Followings { get; set; }
        public virtual DbSet<Forum> Forums { get; set; }
        public virtual DbSet<ForumsReply> ForumsReplies { get; set; }
        public virtual DbSet<ForumsThread> ForumsThreads { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GamesPlayer> GamesPlayers { get; set; }
        public virtual DbSet<Gift> Gifts { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupsAdmin> GroupsAdmins { get; set; }
        public virtual DbSet<GroupsCategory> GroupsCategories { get; set; }
        public virtual DbSet<GroupsMember> GroupsMembers { get; set; }
        public virtual DbSet<Hashtag> Hashtags { get; set; }
        public virtual DbSet<HashtagsPost> HashtagsPosts { get; set; }
        public virtual DbSet<InvitationCode> InvitationCodes { get; set; }
        public virtual DbSet<JobsCategory> JobsCategories { get; set; }
        public virtual DbSet<MarketCategory> MarketCategories { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MoviesGenre> MoviesGenres { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OffersCategory> OffersCategories { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<PackagesPayment> PackagesPayments { get; set; }
        public virtual DbSet<Page> Pages { get; set; }
        public virtual DbSet<PagesAdmin> PagesAdmins { get; set; }
        public virtual DbSet<PagesCategory> PagesCategories { get; set; }
        public virtual DbSet<PagesInvite> PagesInvites { get; set; }
        public virtual DbSet<PagesLike> PagesLikes { get; set; }
        public virtual DbSet<PointsPayment> PointsPayments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostsArticle> PostsArticles { get; set; }
        public virtual DbSet<PostsAudio> PostsAudios { get; set; }
        public virtual DbSet<PostsColoredPattern> PostsColoredPatterns { get; set; }
        public virtual DbSet<PostsComment> PostsComments { get; set; }
        public virtual DbSet<PostsCommentsReaction> PostsCommentsReactions { get; set; }
        public virtual DbSet<PostsFile> PostsFiles { get; set; }
        public virtual DbSet<PostsHidden> PostsHiddens { get; set; }
        public virtual DbSet<PostsJob> PostsJobs { get; set; }
        public virtual DbSet<PostsJobsApplication> PostsJobsApplications { get; set; }
        public virtual DbSet<PostsLink> PostsLinks { get; set; }
        public virtual DbSet<PostsLive> PostsLives { get; set; }
        public virtual DbSet<PostsLiveUser> PostsLiveUsers { get; set; }
        public virtual DbSet<PostsMedium> PostsMedia { get; set; }
        public virtual DbSet<PostsOffer> PostsOffers { get; set; }
        public virtual DbSet<PostsPhoto> PostsPhotos { get; set; }
        public virtual DbSet<PostsPhotosAlbum> PostsPhotosAlbums { get; set; }
        public virtual DbSet<PostsPhotosReaction> PostsPhotosReactions { get; set; }
        public virtual DbSet<PostsPoll> PostsPolls { get; set; }
        public virtual DbSet<PostsPollsOption> PostsPollsOptions { get; set; }
        public virtual DbSet<PostsPollsOptionsUser> PostsPollsOptionsUsers { get; set; }
        public virtual DbSet<PostsProduct> PostsProducts { get; set; }
        public virtual DbSet<PostsReaction> PostsReactions { get; set; }
        public virtual DbSet<PostsSaved> PostsSaveds { get; set; }
        public virtual DbSet<PostsVideo> PostsVideos { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<StaticPage> StaticPages { get; set; }
        public virtual DbSet<Sticker> Stickers { get; set; }
        public virtual DbSet<StoriesMedium> StoriesMedia { get; set; }
        public virtual DbSet<Story> Stories { get; set; }
        public virtual DbSet<SystemCountry> SystemCountries { get; set; }
        public virtual DbSet<SystemCurrency> SystemCurrencies { get; set; }
        public virtual DbSet<SystemLanguage> SystemLanguages { get; set; }
        public virtual DbSet<SystemOption> SystemOptions { get; set; }
        public virtual DbSet<SystemTheme> SystemThemes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersBlock> UsersBlocks { get; set; }
        public virtual DbSet<UsersGift> UsersGifts { get; set; }
        public virtual DbSet<UsersInvitation> UsersInvitations { get; set; }
        public virtual DbSet<UsersPoke> UsersPokes { get; set; }
        public virtual DbSet<UsersSearch> UsersSearches { get; set; }
        public virtual DbSet<UsersSession> UsersSessions { get; set; }
        public virtual DbSet<VerificationRequest> VerificationRequests { get; set; }
        public virtual DbSet<Widget> Widgets { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySql("server=localhost;database=socialdb;user=root;password=1234;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.FromString("8.0.21-mysql"));
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdsCampaign>(entity =>
            {
                entity.HasKey(e => e.CampaignId)
                    .HasName("PRIMARY");

                entity.ToTable("ads_campaigns");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.AdsDescription)
                    .HasColumnType("mediumtext")
                    .HasColumnName("ads_description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AdsEvent).HasColumnName("ads_event");

                entity.Property(e => e.AdsGroup).HasColumnName("ads_group");

                entity.Property(e => e.AdsImage)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("ads_image")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AdsPage).HasColumnName("ads_page");

                entity.Property(e => e.AdsPlacement)
                    .IsRequired()
                    .HasColumnType("enum('newsfeed','sidebar')")
                    .HasColumnName("ads_placement")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AdsTitle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ads_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AdsType)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("ads_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AdsUrl)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("ads_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AudienceCountries)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("audience_countries")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AudienceGender)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("audience_gender")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AudienceRelationship)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("audience_relationship")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CampaignBidding)
                    .IsRequired()
                    .HasColumnType("enum('click','view')")
                    .HasColumnName("campaign_bidding")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CampaignBudget).HasColumnName("campaign_budget");

                entity.Property(e => e.CampaignClicks).HasColumnName("campaign_clicks");

                entity.Property(e => e.CampaignCreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("campaign_created_date");

                entity.Property(e => e.CampaignEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("campaign_end_date");

                entity.Property(e => e.CampaignIsActive)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("campaign_is_active")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CampaignSpend).HasColumnName("campaign_spend");

                entity.Property(e => e.CampaignStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("campaign_start_date");

                entity.Property(e => e.CampaignTitle)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("campaign_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CampaignUserId).HasColumnName("campaign_user_id");

                entity.Property(e => e.CampaignViews).HasColumnName("campaign_views");
            });

            modelBuilder.Entity<AdsSystem>(entity =>
            {
                entity.HasKey(e => e.AdsId)
                    .HasName("PRIMARY");

                entity.ToTable("ads_system");

                entity.Property(e => e.AdsId).HasColumnName("ads_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("place")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<AdsUsersWalletTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("ads_users_wallet_transactions");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("amount")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.NodeId).HasColumnName("node_id");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("node_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('in','out')")
                    .HasColumnName("type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<AffiliatesPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PRIMARY");

                entity.ToTable("affiliates_payments");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("amount")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("method")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MethodValue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("method_value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("announcements");

                entity.Property(e => e.AnnouncementId).HasColumnName("announcement_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<AnnouncementsUser>(entity =>
            {
                entity.ToTable("announcements_users");

                entity.HasIndex(e => new { e.AnnouncementId, e.UserId }, "announcement_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnnouncementId).HasColumnName("announcement_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<BankTransfer>(entity =>
            {
                entity.HasKey(e => e.TransferId)
                    .HasName("PRIMARY");

                entity.ToTable("bank_transfers");

                entity.Property(e => e.TransferId).HasColumnName("transfer_id");

                entity.Property(e => e.BankReceipt)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("bank_receipt")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Handle)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("handle")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PackageId).HasColumnName("package_id");

                entity.Property(e => e.Price)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("price")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Blacklist>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PRIMARY");

                entity.ToTable("blacklist");

                entity.Property(e => e.NodeId).HasColumnName("node_id");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnType("enum('ip','email','username')")
                    .HasColumnName("node_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NodeValue)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("node_value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<BlogsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("blogs_categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("category_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CoinpaymentsTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("coinpayments_transactions");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("amount")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_update");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("product")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusMessage)
                    .HasColumnType("text")
                    .HasColumnName("status_message")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TransactionTxnId)
                    .HasColumnType("text")
                    .HasColumnName("transaction_txn_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.ToTable("conversations");

                entity.Property(e => e.ConversationId).HasColumnName("conversation_id");

                entity.Property(e => e.Color)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("color")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LastMessageId).HasColumnName("last_message_id");
            });

            modelBuilder.Entity<ConversationsCallsAudio>(entity =>
            {
                entity.HasKey(e => e.CallId)
                    .HasName("PRIMARY");

                entity.ToTable("conversations_calls_audio");

                entity.Property(e => e.CallId).HasColumnName("call_id");

                entity.Property(e => e.Answered)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("answered")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.Declined)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("declined")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.FromUserToken)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("from_user_token")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Room)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("room")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ToUserId).HasColumnName("to_user_id");

                entity.Property(e => e.ToUserToken)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("to_user_token")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<ConversationsCallsVideo>(entity =>
            {
                entity.HasKey(e => e.CallId)
                    .HasName("PRIMARY");

                entity.ToTable("conversations_calls_video");

                entity.Property(e => e.CallId).HasColumnName("call_id");

                entity.Property(e => e.Answered)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("answered")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.Declined)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("declined")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.FromUserToken)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("from_user_token")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Room)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("room")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ToUserId).HasColumnName("to_user_id");

                entity.Property(e => e.ToUserToken)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("to_user_token")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UpdatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_time");
            });

            modelBuilder.Entity<ConversationsMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PRIMARY");

                entity.ToTable("conversations_messages");

                entity.Property(e => e.MessageId).HasColumnName("message_id");

                entity.Property(e => e.ConversationId).HasColumnName("conversation_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("image")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("message")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.VoiceNote)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("voice_note")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<ConversationsUser>(entity =>
            {
                entity.ToTable("conversations_users");

                entity.HasIndex(e => new { e.ConversationId, e.UserId }, "conversation_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConversationId).HasColumnName("conversation_id");

                entity.Property(e => e.Deleted)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Seen)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("seen")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Typing)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("typing")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<CustomField>(entity =>
            {
                entity.HasKey(e => e.FieldId)
                    .HasName("PRIMARY");

                entity.ToTable("custom_fields");

                entity.Property(e => e.FieldId).HasColumnName("field_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FieldFor)
                    .IsRequired()
                    .HasColumnType("enum('user','page','group','event')")
                    .HasColumnName("field_for")
                    .HasDefaultValueSql("'user'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FieldOrder)
                    .HasColumnName("field_order")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.InProfile)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("in_profile")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InRegistration)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("in_registration")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("label")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasDefaultValueSql("'32'");

                entity.Property(e => e.Mandatory)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("mandatory")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("place")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SelectOptions)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("select_options")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<CustomFieldsValue>(entity =>
            {
                entity.HasKey(e => e.ValueId)
                    .HasName("PRIMARY");

                entity.ToTable("custom_fields_values");

                entity.HasIndex(e => new { e.FieldId, e.NodeId, e.NodeType }, "field_id_node_id_node_type")
                    .IsUnique();

                entity.Property(e => e.ValueId).HasColumnName("value_id");

                entity.Property(e => e.FieldId).HasColumnName("field_id");

                entity.Property(e => e.NodeId).HasColumnName("node_id");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnType("enum('user','page','group','event')")
                    .HasColumnName("node_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<DevelopersApp>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PRIMARY");

                entity.ToTable("developers_apps");

                entity.HasIndex(e => e.AppAuthId, "app_auth_id")
                    .IsUnique();

                entity.HasIndex(e => e.AppAuthSecret, "app_auth_secret")
                    .IsUnique();

                entity.Property(e => e.AppId).HasColumnName("app_id");

                entity.Property(e => e.AppAuthId)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("app_auth_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AppAuthSecret)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("app_auth_secret")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AppCategoryId).HasColumnName("app_category_id");

                entity.Property(e => e.AppDate)
                    .HasColumnType("datetime")
                    .HasColumnName("app_date");

                entity.Property(e => e.AppDescription)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("app_description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AppDomain)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("app_domain")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AppIcon)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("app_icon")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("app_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AppRedirectUrl)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("app_redirect_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AppUserId).HasColumnName("app_user_id");
            });

            modelBuilder.Entity<DevelopersAppsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("developers_apps_categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("category_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DevelopersAppsUser>(entity =>
            {
                entity.ToTable("developers_apps_users");

                entity.HasIndex(e => new { e.AppId, e.UserId }, "page_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccessToken)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("access_token")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AccessTokenDate)
                    .HasColumnType("datetime")
                    .HasColumnName("access_token_date");

                entity.Property(e => e.AppId).HasColumnName("app_id");

                entity.Property(e => e.AuthKey)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("auth_key")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Emoji>(entity =>
            {
                entity.ToTable("emojis");

                entity.Property(e => e.EmojiId).HasColumnName("emoji_id");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("class")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("pattern")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.ToTable("events");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.EventAdmin).HasColumnName("event_admin");

                entity.Property(e => e.EventAlbumCovers).HasColumnName("event_album_covers");

                entity.Property(e => e.EventAlbumTimeline).HasColumnName("event_album_timeline");

                entity.Property(e => e.EventCategory).HasColumnName("event_category");

                entity.Property(e => e.EventCover)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("event_cover")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventCoverId).HasColumnName("event_cover_id");

                entity.Property(e => e.EventCoverPosition)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("event_cover_position")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventDate)
                    .HasColumnType("datetime")
                    .HasColumnName("event_date");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("event_description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("event_end_date");

                entity.Property(e => e.EventGoing).HasColumnName("event_going");

                entity.Property(e => e.EventInterested).HasColumnName("event_interested");

                entity.Property(e => e.EventInvited).HasColumnName("event_invited");

                entity.Property(e => e.EventLocation)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("event_location")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventPinnedPost).HasColumnName("event_pinned_post");

                entity.Property(e => e.EventPrivacy)
                    .HasColumnType("enum('secret','closed','public')")
                    .HasColumnName("event_privacy")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventPublishApprovalEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("event_publish_approval_enabled")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventPublishEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("event_publish_enabled")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("event_start_date");

                entity.Property(e => e.EventTitle)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("event_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<EventsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("events_categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("category_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<EventsMember>(entity =>
            {
                entity.ToTable("events_members");

                entity.HasIndex(e => new { e.EventId, e.UserId }, "group_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IsGoing)
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("is_going")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.IsInterested)
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("is_interested")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.IsInvited)
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("is_invited")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Following>(entity =>
            {
                entity.ToTable("followings");

                entity.HasIndex(e => new { e.UserId, e.FollowingId }, "user_id_following_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FollowingId).HasColumnName("following_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Forum>(entity =>
            {
                entity.ToTable("forums");

                entity.Property(e => e.ForumId).HasColumnName("forum_id");

                entity.Property(e => e.ForumDescription)
                    .HasColumnType("mediumtext")
                    .HasColumnName("forum_description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ForumName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("forum_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ForumOrder)
                    .HasColumnName("forum_order")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ForumReplies).HasColumnName("forum_replies");

                entity.Property(e => e.ForumSection).HasColumnName("forum_section");

                entity.Property(e => e.ForumThreads).HasColumnName("forum_threads");
            });

            modelBuilder.Entity<ForumsReply>(entity =>
            {
                entity.HasKey(e => e.ReplyId)
                    .HasName("PRIMARY");

                entity.ToTable("forums_replies");

                entity.Property(e => e.ReplyId).HasColumnName("reply_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ThreadId).HasColumnName("thread_id");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ForumsThread>(entity =>
            {
                entity.HasKey(e => e.ThreadId)
                    .HasName("PRIMARY");

                entity.ToTable("forums_threads");

                entity.Property(e => e.ThreadId).HasColumnName("thread_id");

                entity.Property(e => e.ForumId).HasColumnName("forum_id");

                entity.Property(e => e.LastReply)
                    .HasColumnType("datetime")
                    .HasColumnName("last_reply");

                entity.Property(e => e.Replies).HasColumnName("replies");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<Friend>(entity =>
            {
                entity.ToTable("friends");

                entity.HasIndex(e => new { e.UserOneId, e.UserTwoId }, "user_one_id_user_two_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserOneId).HasColumnName("user_one_id");

                entity.Property(e => e.UserTwoId).HasColumnName("user_two_id");
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("games");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("source")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("thumbnail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<GamesPlayer>(entity =>
            {
                entity.ToTable("games_players");

                entity.HasIndex(e => new { e.GameId, e.UserId }, "game_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.LastPlayedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("last_played_time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Gift>(entity =>
            {
                entity.ToTable("gifts");

                entity.Property(e => e.GiftId).HasColumnName("gift_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("image")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");

                entity.HasIndex(e => e.GroupName, "username")
                    .IsUnique();

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.GroupAdmin).HasColumnName("group_admin");

                entity.Property(e => e.GroupAlbumCovers).HasColumnName("group_album_covers");

                entity.Property(e => e.GroupAlbumPictures).HasColumnName("group_album_pictures");

                entity.Property(e => e.GroupAlbumTimeline).HasColumnName("group_album_timeline");

                entity.Property(e => e.GroupCategory).HasColumnName("group_category");

                entity.Property(e => e.GroupCover)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("group_cover")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupCoverId).HasColumnName("group_cover_id");

                entity.Property(e => e.GroupCoverPosition)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("group_cover_position")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupDate)
                    .HasColumnType("datetime")
                    .HasColumnName("group_date");

                entity.Property(e => e.GroupDescription)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("group_description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupMembers).HasColumnName("group_members");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("group_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupPicture)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("group_picture")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupPictureId).HasColumnName("group_picture_id");

                entity.Property(e => e.GroupPinnedPost).HasColumnName("group_pinned_post");

                entity.Property(e => e.GroupPrivacy)
                    .HasColumnType("enum('secret','closed','public')")
                    .HasColumnName("group_privacy")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupPublishApprovalEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("group_publish_approval_enabled")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupPublishEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("group_publish_enabled")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupTitle)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("group_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<GroupsAdmin>(entity =>
            {
                entity.ToTable("groups_admins");

                entity.HasIndex(e => new { e.GroupId, e.UserId }, "group_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<GroupsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("groups_categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("category_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<GroupsMember>(entity =>
            {
                entity.ToTable("groups_members");

                entity.HasIndex(e => new { e.GroupId, e.UserId }, "group_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("approved")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Hashtag>(entity =>
            {
                entity.ToTable("hashtags");

                entity.Property(e => e.HashtagId).HasColumnName("hashtag_id");

                entity.Property(e => e.Hashtag1)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("hashtag")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<HashtagsPost>(entity =>
            {
                entity.ToTable("hashtags_posts");

                entity.HasIndex(e => new { e.PostId, e.HashtagId }, "post_id_hashtag_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.HashtagId).HasColumnName("hashtag_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");
            });

            modelBuilder.Entity<InvitationCode>(entity =>
            {
                entity.HasKey(e => e.CodeId)
                    .HasName("PRIMARY");

                entity.ToTable("invitation_codes");

                entity.Property(e => e.CodeId).HasColumnName("code_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Valid)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<JobsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jobs_categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("category_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MarketCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("market_categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("category_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Genres)
                    .HasColumnType("mediumtext")
                    .HasColumnName("genres")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ImdbUrl)
                    .HasColumnType("text")
                    .HasColumnName("imdb_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Poster)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("poster")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ReleaseYear).HasColumnName("release_year");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("source")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("source_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Stars)
                    .HasColumnType("text")
                    .HasColumnName("stars")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<MoviesGenre>(entity =>
            {
                entity.HasKey(e => e.GenreId)
                    .HasName("PRIMARY");

                entity.ToTable("movies_genres");

                entity.Property(e => e.GenreId).HasColumnName("genre_id");

                entity.Property(e => e.GenreDescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("genre_description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("genre_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GenreOrder)
                    .HasColumnName("genre_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notifications");

                entity.Property(e => e.NotificationId).HasColumnName("notification_id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("action")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.Message)
                    .HasColumnType("mediumtext")
                    .HasColumnName("message")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("node_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NodeUrl)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("node_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NotifyId)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("notify_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Seen)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("seen")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.ToUserId).HasColumnName("to_user_id");
            });

            modelBuilder.Entity<OffersCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("offers_categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("category_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.ToTable("packages");

                entity.Property(e => e.PackageId).HasColumnName("package_id");

                entity.Property(e => e.BoostPages).HasColumnName("boost_pages");

                entity.Property(e => e.BoostPagesEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("boost_pages_enabled")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BoostPosts).HasColumnName("boost_posts");

                entity.Property(e => e.BoostPostsEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("boost_posts_enabled")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("color")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("icon")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("period")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PeriodNum).HasColumnName("period_num");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("price")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VerificationBadgeEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("verification_badge_enabled")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PackagesPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PRIMARY");

                entity.ToTable("packages_payments");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("package_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PackagePrice)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("package_price")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("payment_date");
            });

            modelBuilder.Entity<Page>(entity =>
            {
                entity.ToTable("pages");

                entity.HasIndex(e => e.PageName, "username")
                    .IsUnique();

                entity.Property(e => e.PageId).HasColumnName("page_id");

                entity.Property(e => e.PageActionColor)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("page_action_color")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageActionText)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("page_action_text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageActionUrl)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_action_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageAdmin).HasColumnName("page_admin");

                entity.Property(e => e.PageAlbumCovers).HasColumnName("page_album_covers");

                entity.Property(e => e.PageAlbumPictures).HasColumnName("page_album_pictures");

                entity.Property(e => e.PageAlbumTimeline).HasColumnName("page_album_timeline");

                entity.Property(e => e.PageBoosted)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("page_boosted")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageBoostedBy).HasColumnName("page_boosted_by");

                entity.Property(e => e.PageCategory).HasColumnName("page_category");

                entity.Property(e => e.PageCompany)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_company")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageCover)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_cover")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageCoverId).HasColumnName("page_cover_id");

                entity.Property(e => e.PageCoverPosition)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_cover_position")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("page_date");

                entity.Property(e => e.PageDescription)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("page_description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageLikes).HasColumnName("page_likes");

                entity.Property(e => e.PageLocation)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_location")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("page_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PagePhone)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_phone")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PagePicture)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_picture")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PagePictureId).HasColumnName("page_picture_id");

                entity.Property(e => e.PagePinnedPost).HasColumnName("page_pinned_post");

                entity.Property(e => e.PageSocialFacebook)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_social_facebook")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageSocialInstagram)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_social_instagram")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageSocialLinkedin)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_social_linkedin")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageSocialTwitter)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_social_twitter")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageSocialVkontakte)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_social_vkontakte")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageSocialYoutube)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_social_youtube")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageVerified)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("page_verified")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageWebsite)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_website")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PagesAdmin>(entity =>
            {
                entity.ToTable("pages_admins");

                entity.HasIndex(e => new { e.PageId, e.UserId }, "page_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PageId).HasColumnName("page_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PagesCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("pages_categories");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("category_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PagesInvite>(entity =>
            {
                entity.ToTable("pages_invites");

                entity.HasIndex(e => new { e.PageId, e.UserId, e.FromUserId }, "page_id_user_id_from_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.PageId).HasColumnName("page_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PagesLike>(entity =>
            {
                entity.ToTable("pages_likes");

                entity.HasIndex(e => new { e.PageId, e.UserId }, "page_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PageId).HasColumnName("page_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PointsPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PRIMARY");

                entity.ToTable("points_payments");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("amount")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("method")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MethodValue)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("method_value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("posts");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Boosted)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("boosted")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BoostedBy).HasColumnName("boosted_by");

                entity.Property(e => e.ColoredPattern).HasColumnName("colored_pattern");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CommentsDisabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("comments_disabled")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventApproved)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("event_approved")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FeelingAction)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("feeling_action")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FeelingValue)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("feeling_value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupApproved)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("group_approved")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.InEvent)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("in_event")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InGroup)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("in_group")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InWall)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("in_wall")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.IsAnonymous)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("is_anonymous")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.IsHidden)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("is_hidden")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Location)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("location")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.OriginId).HasColumnName("origin_id");

                entity.Property(e => e.PointsEarned)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("points_earned")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PostType)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("post_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Privacy)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("privacy")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ReactionAngryCount).HasColumnName("reaction_angry_count");

                entity.Property(e => e.ReactionHahaCount).HasColumnName("reaction_haha_count");

                entity.Property(e => e.ReactionLikeCount).HasColumnName("reaction_like_count");

                entity.Property(e => e.ReactionLoveCount).HasColumnName("reaction_love_count");

                entity.Property(e => e.ReactionSadCount).HasColumnName("reaction_sad_count");

                entity.Property(e => e.ReactionWowCount).HasColumnName("reaction_wow_count");

                entity.Property(e => e.ReactionYayCount).HasColumnName("reaction_yay_count");

                entity.Property(e => e.Shares).HasColumnName("shares");

                entity.Property(e => e.Text)
                    .HasColumnType("longtext")
                    .HasColumnName("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnType("enum('user','page')")
                    .HasColumnName("user_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WallId).HasColumnName("wall_id");
            });

            modelBuilder.Entity<PostsArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_articles");

                entity.Property(e => e.ArticleId).HasColumnName("article_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("cover")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("tags")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<PostsAudio>(entity =>
            {
                entity.HasKey(e => e.AudioId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_audios");

                entity.Property(e => e.AudioId).HasColumnName("audio_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<PostsColoredPattern>(entity =>
            {
                entity.HasKey(e => e.PatternId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_colored_patterns");

                entity.Property(e => e.PatternId).HasColumnName("pattern_id");

                entity.Property(e => e.BackgroundColor1)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("background_color_1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BackgroundColor2)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("background_color_2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BackgroundImage)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("background_image")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TextColor)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("text_color")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("enum('color','image')")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'color'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_comments");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.Image)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("image")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NodeId).HasColumnName("node_id");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnType("enum('post','photo','comment')")
                    .HasColumnName("node_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PointsEarned)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("points_earned")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ReactionAngryCount).HasColumnName("reaction_angry_count");

                entity.Property(e => e.ReactionHahaCount).HasColumnName("reaction_haha_count");

                entity.Property(e => e.ReactionLikeCount).HasColumnName("reaction_like_count");

                entity.Property(e => e.ReactionLoveCount).HasColumnName("reaction_love_count");

                entity.Property(e => e.ReactionSadCount).HasColumnName("reaction_sad_count");

                entity.Property(e => e.ReactionWowCount).HasColumnName("reaction_wow_count");

                entity.Property(e => e.ReactionYayCount).HasColumnName("reaction_yay_count");

                entity.Property(e => e.Replies).HasColumnName("replies");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnType("enum('user','page')")
                    .HasColumnName("user_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VoiceNote)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("voice_note")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsCommentsReaction>(entity =>
            {
                entity.ToTable("posts_comments_reactions");

                entity.HasIndex(e => new { e.CommentId, e.UserId }, "comment_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CommentId).HasColumnName("comment_id");

                entity.Property(e => e.PointsEarned)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("points_earned")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Reaction)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("reaction")
                    .HasDefaultValueSql("'like'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ReactionTime)
                    .HasColumnType("datetime")
                    .HasColumnName("reaction_time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostsFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_files");

                entity.Property(e => e.FileId).HasColumnName("file_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsHidden>(entity =>
            {
                entity.ToTable("posts_hidden");

                entity.HasIndex(e => new { e.PostId, e.UserId }, "post_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostsJob>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_jobs");

                entity.Property(e => e.JobId).HasColumnName("job_id");

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("available")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CoverImage)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("cover_image")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("location")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PaySalaryPer)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("pay_salary_per")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Question1Choices)
                    .HasColumnType("text")
                    .HasColumnName("question_1_choices")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question1Title)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("question_1_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question1Type)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("question_1_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question2Choices)
                    .HasColumnType("text")
                    .HasColumnName("question_2_choices")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question2Title)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("question_2_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question2Type)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("question_2_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question3Choices)
                    .HasColumnType("text")
                    .HasColumnName("question_3_choices")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question3Title)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("question_3_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question3Type)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("question_3_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SalaryMaximum)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("salary_maximum")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SalaryMinimum)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("salary_minimum")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsJobsApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_jobs_applications");

                entity.Property(e => e.ApplicationId).HasColumnName("application_id");

                entity.Property(e => e.AppliedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("applied_time");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("email")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("location")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("phone")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Question1Answer)
                    .HasColumnType("text")
                    .HasColumnName("question_1_answer")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question2Answer)
                    .HasColumnType("text")
                    .HasColumnName("question_2_answer")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Question3Answer)
                    .HasColumnType("text")
                    .HasColumnName("question_3_answer")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WorkDescription)
                    .HasColumnType("text")
                    .HasColumnName("work_description")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WorkFrom)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("work_from")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WorkNow)
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("work_now")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WorkPlace)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("work_place")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WorkPosition)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("work_position")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.WorkTo)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("work_to")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_links");

                entity.Property(e => e.LinkId).HasColumnName("link_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.SourceHost)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source_host")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceText)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("source_text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceThumbnail)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("source_thumbnail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceTitle)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceUrl)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("source_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsLive>(entity =>
            {
                entity.HasKey(e => e.LiveId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_live");

                entity.Property(e => e.LiveId).HasColumnName("live_id");

                entity.Property(e => e.AgoraChannelName)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("agora_channel_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AgoraFile)
                    .HasColumnType("text")
                    .HasColumnName("agora_file")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AgoraResourceId)
                    .HasColumnType("text")
                    .HasColumnName("agora_resource_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AgoraSid)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("agora_sid")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.AgoraUid).HasColumnName("agora_uid");

                entity.Property(e => e.LiveEnded)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("live_ended")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LiveRecorded)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("live_recorded")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.VideoThumbnail)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("video_thumbnail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsLiveUser>(entity =>
            {
                entity.ToTable("posts_live_users");

                entity.HasIndex(e => new { e.UserId, e.PostId }, "user_id_post_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostsMedium>(entity =>
            {
                entity.HasKey(e => e.MediaId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_media");

                entity.Property(e => e.MediaId).HasColumnName("media_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.SourceHtml)
                    .HasColumnType("mediumtext")
                    .HasColumnName("source_html")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceProvider)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source_provider")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceText)
                    .HasColumnType("mediumtext")
                    .HasColumnName("source_text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceThumbnail)
                    .HasColumnType("text")
                    .HasColumnName("source_thumbnail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceTitle)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.SourceUrl)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("source_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsOffer>(entity =>
            {
                entity.HasKey(e => e.OfferId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_offers");

                entity.Property(e => e.OfferId).HasColumnName("offer_id");

                entity.Property(e => e.AmountY)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("amount_y")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.BuyX)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("buy_x")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.DiscountAmount)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("discount_amount")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DiscountPercent).HasColumnName("discount_percent");

                entity.Property(e => e.DiscountType)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("discount_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.GetY)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("get_y")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.SpendX)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("spend_x")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("thumbnail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsPhoto>(entity =>
            {
                entity.HasKey(e => e.PhotoId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_photos");

                entity.Property(e => e.PhotoId).HasColumnName("photo_id");

                entity.Property(e => e.AlbumId).HasColumnName("album_id");

                entity.Property(e => e.Blur)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("blur")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.ReactionAngryCount).HasColumnName("reaction_angry_count");

                entity.Property(e => e.ReactionHahaCount).HasColumnName("reaction_haha_count");

                entity.Property(e => e.ReactionLikeCount).HasColumnName("reaction_like_count");

                entity.Property(e => e.ReactionLoveCount).HasColumnName("reaction_love_count");

                entity.Property(e => e.ReactionSadCount).HasColumnName("reaction_sad_count");

                entity.Property(e => e.ReactionWowCount).HasColumnName("reaction_wow_count");

                entity.Property(e => e.ReactionYayCount).HasColumnName("reaction_yay_count");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsPhotosAlbum>(entity =>
            {
                entity.HasKey(e => e.AlbumId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_photos_albums");

                entity.Property(e => e.AlbumId).HasColumnName("album_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.InEvent)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("in_event")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InGroup)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("in_group")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Privacy)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public','custom')")
                    .HasColumnName("privacy")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnType("enum('user','page')")
                    .HasColumnName("user_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsPhotosReaction>(entity =>
            {
                entity.ToTable("posts_photos_reactions");

                entity.HasIndex(e => new { e.UserId, e.PhotoId }, "user_id_photo_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PhotoId).HasColumnName("photo_id");

                entity.Property(e => e.PointsEarned)
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("points_earned")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Reaction)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("reaction")
                    .HasDefaultValueSql("'like'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ReactionTime)
                    .HasColumnType("datetime")
                    .HasColumnName("reaction_time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostsPoll>(entity =>
            {
                entity.HasKey(e => e.PollId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_polls");

                entity.Property(e => e.PollId).HasColumnName("poll_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Votes).HasColumnName("votes");
            });

            modelBuilder.Entity<PostsPollsOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_polls_options");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.PollId).HasColumnName("poll_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsPollsOptionsUser>(entity =>
            {
                entity.ToTable("posts_polls_options_users");

                entity.HasIndex(e => new { e.UserId, e.PollId }, "user_id_poll_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.PollId).HasColumnName("poll_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostsProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_products");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("available")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("location")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("price")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("enum('new','old')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'new'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<PostsReaction>(entity =>
            {
                entity.ToTable("posts_reactions");

                entity.HasIndex(e => new { e.PostId, e.UserId }, "post_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PointsEarned)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("points_earned")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Reaction)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("reaction")
                    .HasDefaultValueSql("'like'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.ReactionTime)
                    .HasColumnType("datetime")
                    .HasColumnName("reaction_time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostsSaved>(entity =>
            {
                entity.ToTable("posts_saved");

                entity.HasIndex(e => new { e.PostId, e.UserId }, "post_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<PostsVideo>(entity =>
            {
                entity.HasKey(e => e.VideoId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_videos");

                entity.Property(e => e.VideoId).HasColumnName("video_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Thumbnail)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("thumbnail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("reports");

                entity.Property(e => e.ReportId).HasColumnName("report_id");

                entity.Property(e => e.NodeId).HasColumnName("node_id");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("node_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<StaticPage>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("PRIMARY");

                entity.ToTable("static_pages");

                entity.HasIndex(e => e.PageUrl, "page_url")
                    .IsUnique();

                entity.Property(e => e.PageId).HasColumnName("page_id");

                entity.Property(e => e.PageInFooter)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("page_in_footer")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageOrder)
                    .HasColumnName("page_order")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PageText)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("page_text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("page_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PageUrl)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("page_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Sticker>(entity =>
            {
                entity.ToTable("stickers");

                entity.Property(e => e.StickerId).HasColumnName("sticker_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("image")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<StoriesMedium>(entity =>
            {
                entity.HasKey(e => e.MediaId)
                    .HasName("PRIMARY");

                entity.ToTable("stories_media");

                entity.Property(e => e.MediaId).HasColumnName("media_id");

                entity.Property(e => e.IsPhoto)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("is_photo")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("source")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Story>(entity =>
            {
                entity.ToTable("stories");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<SystemCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PRIMARY");

                entity.ToTable("system_countries");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnType("varchar(2)")
                    .HasColumnName("country_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("country_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<SystemCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PRIMARY");

                entity.ToTable("system_currencies");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Default)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("default")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("symbol")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<SystemLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PRIMARY");

                entity.ToTable("system_languages");

                entity.HasIndex(e => e.Code, "code")
                    .IsUnique();

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Default)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("default")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Dir)
                    .IsRequired()
                    .HasColumnType("enum('LTR','RTL')")
                    .HasColumnName("dir")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("enabled")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("flag")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<SystemOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("system_options");

                entity.HasIndex(e => e.OptionName, "option_name")
                    .IsUnique();

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasColumnType("varchar(128)")
                    .HasColumnName("option_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.OptionValue)
                    .HasColumnType("varchar(2048)")
                    .HasColumnName("option_value")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<SystemTheme>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PRIMARY");

                entity.ToTable("system_themes");

                entity.HasIndex(e => e.Name, "name")
                    .IsUnique();

                entity.Property(e => e.ThemeId).HasColumnName("theme_id");

                entity.Property(e => e.Default)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("default")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.FacebookId, "facebook_id")
                    .IsUnique();

                entity.HasIndex(e => e.GoogleId, "google_id")
                    .IsUnique();

                entity.HasIndex(e => e.InstagramId, "instagram_id")
                    .IsUnique();

                entity.HasIndex(e => e.LinkedinId, "linkedin_id")
                    .IsUnique();

                entity.HasIndex(e => e.TwitterId, "twitter_id")
                    .IsUnique();

                entity.HasIndex(e => e.UserEmail, "user_email")
                    .IsUnique();

                entity.HasIndex(e => e.UserPhone, "user_phone")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "username")
                    .IsUnique();

                entity.HasIndex(e => e.VkontakteId, "vkontakte_id")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ChatSound)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("chat_sound")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EmailFriendRequests)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("email_friend_requests")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EmailMentions)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("email_mentions")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EmailPostComments)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("email_post_comments")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EmailPostLikes)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("email_post_likes")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EmailPostShares)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("email_post_shares")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EmailProfileVisits)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("email_profile_visits")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.EmailWallPosts)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("email_wall_posts")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FacebookConnected)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("facebook_connected")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.FacebookId)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("facebook_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GoogleConnected)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("google_connected")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.GoogleId)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("google_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InstagramConnected)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("instagram_connected")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InstagramId)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("instagram_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LinkedinConnected)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("linkedin_connected")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.LinkedinId)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("linkedin_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NotificationsSound)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("notifications_sound")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.OnesignalUserId)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("onesignal_user_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TwitterConnected)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("twitter_connected")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TwitterId)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("twitter_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserActivated)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_activated")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserAffiliateBalance)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_affiliate_balance")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserAlbumCovers).HasColumnName("user_album_covers");

                entity.Property(e => e.UserAlbumPictures).HasColumnName("user_album_pictures");

                entity.Property(e => e.UserAlbumTimeline).HasColumnName("user_album_timeline");

                entity.Property(e => e.UserBanned)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_banned")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserBiography)
                    .HasColumnType("text")
                    .HasColumnName("user_biography")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserBirthdate)
                    .HasColumnType("date")
                    .HasColumnName("user_birthdate");

                entity.Property(e => e.UserBoostedPages).HasColumnName("user_boosted_pages");

                entity.Property(e => e.UserBoostedPosts).HasColumnName("user_boosted_posts");

                entity.Property(e => e.UserChatEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_chat_enabled")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserCountry).HasColumnName("user_country");

                entity.Property(e => e.UserCover)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_cover")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserCoverId).HasColumnName("user_cover_id");

                entity.Property(e => e.UserCoverPosition)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_cover_position")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserCurrentCity)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_current_city")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserEduClass)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_edu_class")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserEduMajor)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_edu_major")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserEduSchool)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_edu_school")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_email")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserEmailVerificationCode)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_email_verification_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserEmailVerified)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_email_verified")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserFailedLoginCount).HasColumnName("user_failed_login_count");

                entity.Property(e => e.UserFailedLoginIp)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_failed_login_ip")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserFirstFailedLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("user_first_failed_login");

                entity.Property(e => e.UserFirstname)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_firstname")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserGender)
                    .IsRequired()
                    .HasColumnType("enum('male','female','other')")
                    .HasColumnName("user_gender")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserGroup)
                    .HasColumnName("user_group")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.UserHometown)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_hometown")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserLanguage)
                    .HasColumnType("varchar(16)")
                    .HasColumnName("user_language")
                    .HasDefaultValueSql("'en_us'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserLastSeen)
                    .HasColumnType("timestamp")
                    .HasColumnName("user_last_seen")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                entity.Property(e => e.UserLastname)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_lastname")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserLatitude)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_latitude")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserLiveMessagesCounter).HasColumnName("user_live_messages_counter");

                entity.Property(e => e.UserLiveMessagesLastid).HasColumnName("user_live_messages_lastid");

                entity.Property(e => e.UserLiveNotificationsCounter).HasColumnName("user_live_notifications_counter");

                entity.Property(e => e.UserLiveNotificationsLastid).HasColumnName("user_live_notifications_lastid");

                entity.Property(e => e.UserLiveRequestsCounter).HasColumnName("user_live_requests_counter");

                entity.Property(e => e.UserLiveRequestsLastid).HasColumnName("user_live_requests_lastid");

                entity.Property(e => e.UserLocationUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("user_location_updated");

                entity.Property(e => e.UserLongitude)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_longitude")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPackage).HasColumnName("user_package");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_password")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPhone)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_phone")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPhoneVerificationCode)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_phone_verification_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPhoneVerified)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_phone_verified")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPicture)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_picture")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPictureId).HasColumnName("user_picture_id");

                entity.Property(e => e.UserPinnedPost).HasColumnName("user_pinned_post");

                entity.Property(e => e.UserPoints).HasColumnName("user_points");

                entity.Property(e => e.UserPrivacyBasic)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_basic")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyBirthdate)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_birthdate")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyEducation)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_education")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyEvents)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_events")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyFriends)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_friends")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyGifts)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_gifts")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyGroups)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_groups")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyLocation)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_location")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyNewsletter)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_privacy_newsletter")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyOther)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_other")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyPages)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_pages")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyPhotos)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_photos")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyPoke)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_poke")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyRelationship)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_relationship")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyWall)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_wall")
                    .HasDefaultValueSql("'friends'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserPrivacyWork)
                    .IsRequired()
                    .HasColumnType("enum('me','friends','public')")
                    .HasColumnName("user_privacy_work")
                    .HasDefaultValueSql("'public'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserProfileBackground)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_profile_background")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserReferrerId).HasColumnName("user_referrer_id");

                entity.Property(e => e.UserRegistered)
                    .HasColumnType("datetime")
                    .HasColumnName("user_registered");

                entity.Property(e => e.UserRelationship)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_relationship")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserResetKey)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_reset_key")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserReseted)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_reseted")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserSocialFacebook)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_social_facebook")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserSocialInstagram)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_social_instagram")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserSocialLinkedin)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_social_linkedin")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserSocialTwitter)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_social_twitter")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserSocialVkontakte)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_social_vkontakte")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserSocialYoutube)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_social_youtube")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserStarted)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_started")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserSubscribed)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_subscribed")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserSubscriptionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("user_subscription_date");

                entity.Property(e => e.UserTwoFactorEnabled)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_two_factor_enabled")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserTwoFactorGsecret)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_two_factor_gsecret")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserTwoFactorKey)
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_two_factor_key")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserTwoFactorType)
                    .HasColumnType("enum('email','sms','google')")
                    .HasColumnName("user_two_factor_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserVerified)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("user_verified")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserWalletBalance)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_wallet_balance")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserWebsite)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_website")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserWorkPlace)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_work_place")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserWorkTitle)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_work_title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserWorkUrl)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("user_work_url")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VkontakteConnected)
                    .IsRequired()
                    .HasColumnType("enum('0','1')")
                    .HasColumnName("vkontakte_connected")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.VkontakteId)
                    .HasColumnType("varchar(128)")
                    .HasColumnName("vkontakte_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<UsersBlock>(entity =>
            {
                entity.ToTable("users_blocks");

                entity.HasIndex(e => new { e.UserId, e.BlockedId }, "user_id_blocked_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BlockedId).HasColumnName("blocked_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UsersGift>(entity =>
            {
                entity.ToTable("users_gifts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FromUserId).HasColumnName("from_user_id");

                entity.Property(e => e.GiftId).HasColumnName("gift_id");

                entity.Property(e => e.ToUserId).HasColumnName("to_user_id");
            });

            modelBuilder.Entity<UsersInvitation>(entity =>
            {
                entity.ToTable("users_invitations");

                entity.HasIndex(e => new { e.UserId, e.Email }, "user_id_email")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("email")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.InvitationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("invitation_date");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UsersPoke>(entity =>
            {
                entity.ToTable("users_pokes");

                entity.HasIndex(e => new { e.UserId, e.PokedId }, "user_id_blocked_id")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PokedId).HasColumnName("poked_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UsersSearch>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("users_searches");

                entity.HasIndex(e => new { e.NodeId, e.NodeType }, "node_id_node_type")
                    .IsUnique();

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.NodeId).HasColumnName("node_id");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("node_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<UsersSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("users_sessions");

                entity.HasIndex(e => e.SessionToken, "session_token")
                    .IsUnique();

                entity.HasIndex(e => e.UserIp, "user_ip");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.SessionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("session_date");

                entity.Property(e => e.SessionToken)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("session_token")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserBrowser)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_browser")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_ip")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.UserOs)
                    .IsRequired()
                    .HasColumnType("varchar(64)")
                    .HasColumnName("user_os")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<VerificationRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PRIMARY");

                entity.ToTable("verification_requests");

                entity.HasIndex(e => new { e.NodeId, e.NodeType }, "node_id_node_type")
                    .IsUnique();

                entity.Property(e => e.RequestId).HasColumnName("request_id");

                entity.Property(e => e.Message)
                    .HasColumnType("text")
                    .HasColumnName("message")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NodeId).HasColumnName("node_id");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("node_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Passport)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("passport")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Photo)
                    .HasColumnType("varchar(256)")
                    .HasColumnName("photo")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Widget>(entity =>
            {
                entity.ToTable("widgets");

                entity.Property(e => e.WidgetId).HasColumnName("widget_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasColumnName("place")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PlaceOrder)
                    .HasColumnName("place_order")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(256)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
