using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Social.Models
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

        public virtual DbSet<AdsCampaigns> AdsCampaigns { get; set; }
        public virtual DbSet<AdsSystem> AdsSystem { get; set; }
        public virtual DbSet<AdsUsersWalletTransactions> AdsUsersWalletTransactions { get; set; }
        public virtual DbSet<AffiliatesPayments> AffiliatesPayments { get; set; }
        public virtual DbSet<Announcements> Announcements { get; set; }
        public virtual DbSet<AnnouncementsUsers> AnnouncementsUsers { get; set; }
        public virtual DbSet<BankTransfers> BankTransfers { get; set; }
        public virtual DbSet<Blacklist> Blacklist { get; set; }
        public virtual DbSet<BlogsCategories> BlogsCategories { get; set; }
        public virtual DbSet<CoinpaymentsTransactions> CoinpaymentsTransactions { get; set; }
        public virtual DbSet<Conversations> Conversations { get; set; }
        public virtual DbSet<ConversationsCallsAudio> ConversationsCallsAudio { get; set; }
        public virtual DbSet<ConversationsCallsVideo> ConversationsCallsVideo { get; set; }
        public virtual DbSet<ConversationsMessages> ConversationsMessages { get; set; }
        public virtual DbSet<ConversationsUsers> ConversationsUsers { get; set; }
        public virtual DbSet<CustomFields> CustomFields { get; set; }
        public virtual DbSet<CustomFieldsValues> CustomFieldsValues { get; set; }
        public virtual DbSet<DevelopersApps> DevelopersApps { get; set; }
        public virtual DbSet<DevelopersAppsCategories> DevelopersAppsCategories { get; set; }
        public virtual DbSet<DevelopersAppsUsers> DevelopersAppsUsers { get; set; }
        public virtual DbSet<Emojis> Emojis { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<EventsCategories> EventsCategories { get; set; }
        public virtual DbSet<EventsMembers> EventsMembers { get; set; }
        public virtual DbSet<Followings> Followings { get; set; }
        public virtual DbSet<Forums> Forums { get; set; }
        public virtual DbSet<ForumsReplies> ForumsReplies { get; set; }
        public virtual DbSet<ForumsThreads> ForumsThreads { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<GamesPlayers> GamesPlayers { get; set; }
        public virtual DbSet<Gifts> Gifts { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<GroupsAdmins> GroupsAdmins { get; set; }
        public virtual DbSet<GroupsCategories> GroupsCategories { get; set; }
        public virtual DbSet<GroupsMembers> GroupsMembers { get; set; }
        public virtual DbSet<Hashtags> Hashtags { get; set; }
        public virtual DbSet<HashtagsPosts> HashtagsPosts { get; set; }
        public virtual DbSet<InvitationCodes> InvitationCodes { get; set; }
        public virtual DbSet<JobsCategories> JobsCategories { get; set; }
        public virtual DbSet<MarketCategories> MarketCategories { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<MoviesGenres> MoviesGenres { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<OffersCategories> OffersCategories { get; set; }
        public virtual DbSet<Packages> Packages { get; set; }
        public virtual DbSet<PackagesPayments> PackagesPayments { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PagesAdmins> PagesAdmins { get; set; }
        public virtual DbSet<PagesCategories> PagesCategories { get; set; }
        public virtual DbSet<PagesInvites> PagesInvites { get; set; }
        public virtual DbSet<PagesLikes> PagesLikes { get; set; }
        public virtual DbSet<PointsPayments> PointsPayments { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<PostsArticles> PostsArticles { get; set; }
        public virtual DbSet<PostsAudios> PostsAudios { get; set; }
        public virtual DbSet<PostsColoredPatterns> PostsColoredPatterns { get; set; }
        public virtual DbSet<PostsComments> PostsComments { get; set; }
        public virtual DbSet<PostsCommentsReactions> PostsCommentsReactions { get; set; }
        public virtual DbSet<PostsFiles> PostsFiles { get; set; }
        public virtual DbSet<PostsHidden> PostsHidden { get; set; }
        public virtual DbSet<PostsJobs> PostsJobs { get; set; }
        public virtual DbSet<PostsJobsApplications> PostsJobsApplications { get; set; }
        public virtual DbSet<PostsLinks> PostsLinks { get; set; }
        public virtual DbSet<PostsLive> PostsLive { get; set; }
        public virtual DbSet<PostsLiveUsers> PostsLiveUsers { get; set; }
        public virtual DbSet<PostsMedia> PostsMedia { get; set; }
        public virtual DbSet<PostsOffers> PostsOffers { get; set; }
        public virtual DbSet<PostsPhotos> PostsPhotos { get; set; }
        public virtual DbSet<PostsPhotosAlbums> PostsPhotosAlbums { get; set; }
        public virtual DbSet<PostsPhotosReactions> PostsPhotosReactions { get; set; }
        public virtual DbSet<PostsPolls> PostsPolls { get; set; }
        public virtual DbSet<PostsPollsOptions> PostsPollsOptions { get; set; }
        public virtual DbSet<PostsPollsOptionsUsers> PostsPollsOptionsUsers { get; set; }
        public virtual DbSet<PostsProducts> PostsProducts { get; set; }
        public virtual DbSet<PostsReactions> PostsReactions { get; set; }
        public virtual DbSet<PostsSaved> PostsSaved { get; set; }
        public virtual DbSet<PostsVideos> PostsVideos { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<StaticPages> StaticPages { get; set; }
        public virtual DbSet<Stickers> Stickers { get; set; }
        public virtual DbSet<Stories> Stories { get; set; }
        public virtual DbSet<StoriesMedia> StoriesMedia { get; set; }
        public virtual DbSet<SystemCountries> SystemCountries { get; set; }
        public virtual DbSet<SystemCurrencies> SystemCurrencies { get; set; }
        public virtual DbSet<SystemLanguages> SystemLanguages { get; set; }
        public virtual DbSet<SystemOptions> SystemOptions { get; set; }
        public virtual DbSet<SystemThemes> SystemThemes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersBlocks> UsersBlocks { get; set; }
        public virtual DbSet<UsersGifts> UsersGifts { get; set; }
        public virtual DbSet<UsersInvitations> UsersInvitations { get; set; }
        public virtual DbSet<UsersPokes> UsersPokes { get; set; }
        public virtual DbSet<UsersSearches> UsersSearches { get; set; }
        public virtual DbSet<UsersSessions> UsersSessions { get; set; }
        public virtual DbSet<VerificationRequests> VerificationRequests { get; set; }
        public virtual DbSet<Widgets> Widgets { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=1234;database=socialdb");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdsCampaigns>(entity =>
            {
                entity.HasKey(e => e.CampaignId)
                    .HasName("PRIMARY");

                entity.ToTable("ads_campaigns");

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.AdsDescription)
                    .HasColumnName("ads_description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.AdsEvent)
                    .HasColumnName("ads_event")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AdsGroup)
                    .HasColumnName("ads_group")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AdsImage)
                    .IsRequired()
                    .HasColumnName("ads_image")
                    .HasMaxLength(256);

                entity.Property(e => e.AdsPage)
                    .HasColumnName("ads_page")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AdsPlacement)
                    .IsRequired()
                    .HasColumnName("ads_placement")
                    .HasColumnType("enum('newsfeed','sidebar')");

                entity.Property(e => e.AdsTitle)
                    .HasColumnName("ads_title")
                    .HasMaxLength(255);

                entity.Property(e => e.AdsType)
                    .IsRequired()
                    .HasColumnName("ads_type")
                    .HasMaxLength(32);

                entity.Property(e => e.AdsUrl)
                    .HasColumnName("ads_url")
                    .HasMaxLength(256);

                entity.Property(e => e.AudienceCountries)
                    .IsRequired()
                    .HasColumnName("audience_countries")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.AudienceGender)
                    .IsRequired()
                    .HasColumnName("audience_gender")
                    .HasMaxLength(32);

                entity.Property(e => e.AudienceRelationship)
                    .IsRequired()
                    .HasColumnName("audience_relationship")
                    .HasMaxLength(64);

                entity.Property(e => e.CampaignBidding)
                    .IsRequired()
                    .HasColumnName("campaign_bidding")
                    .HasColumnType("enum('click','view')");

                entity.Property(e => e.CampaignBudget).HasColumnName("campaign_budget");

                entity.Property(e => e.CampaignClicks)
                    .HasColumnName("campaign_clicks")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CampaignIsActive)
                    .IsRequired()
                    .HasColumnName("campaign_is_active")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CampaignSpend).HasColumnName("campaign_spend");

                entity.Property(e => e.CampaignTitle)
                    .IsRequired()
                    .HasColumnName("campaign_title")
                    .HasMaxLength(256);

                entity.Property(e => e.CampaignUserId)
                    .HasColumnName("campaign_user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CampaignViews)
                    .HasColumnName("campaign_views")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<AdsSystem>(entity =>
            {
                entity.HasKey(e => e.AdsId)
                    .HasName("PRIMARY");

                entity.ToTable("ads_system");

                entity.Property(e => e.AdsId).HasColumnName("ads_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnName("place")
                    .HasMaxLength(32);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AdsUsersWalletTransactions>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("ads_users_wallet_transactions");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnName("amount")
                    .HasMaxLength(32);

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnName("node_type")
                    .HasMaxLength(32);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('in','out')");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<AffiliatesPayments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PRIMARY");

                entity.ToTable("affiliates_payments");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnName("amount")
                    .HasMaxLength(32);

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnName("method")
                    .HasMaxLength(64);

                entity.Property(e => e.MethodValue)
                    .IsRequired()
                    .HasColumnName("method_value");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Announcements>(entity =>
            {
                entity.HasKey(e => e.AnnouncementId)
                    .HasName("PRIMARY");

                entity.ToTable("announcements");

                entity.Property(e => e.AnnouncementId).HasColumnName("announcement_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<AnnouncementsUsers>(entity =>
            {
                entity.ToTable("announcements_users");

                entity.HasIndex(e => new { e.AnnouncementId, e.UserId })
                    .HasName("announcement_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AnnouncementId)
                    .HasColumnName("announcement_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<BankTransfers>(entity =>
            {
                entity.HasKey(e => e.TransferId)
                    .HasName("PRIMARY");

                entity.ToTable("bank_transfers");

                entity.Property(e => e.TransferId)
                    .HasColumnName("transfer_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.BankReceipt)
                    .IsRequired()
                    .HasColumnName("bank_receipt")
                    .HasMaxLength(256);

                entity.Property(e => e.Handle)
                    .IsRequired()
                    .HasColumnName("handle")
                    .HasMaxLength(32);

                entity.Property(e => e.PackageId)
                    .HasColumnName("package_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(32);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Blacklist>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PRIMARY");

                entity.ToTable("blacklist");

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnName("node_type")
                    .HasColumnType("enum('ip','email','username')");

                entity.Property(e => e.NodeValue)
                    .IsRequired()
                    .HasColumnName("node_value")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<BlogsCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("blogs_categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(256);

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CoinpaymentsTransactions>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("coinpayments_transactions");

                entity.Property(e => e.TransactionId)
                    .HasColumnName("transaction_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnName("amount")
                    .HasMaxLength(32);

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasColumnName("product");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("tinyint unsigned");

                entity.Property(e => e.StatusMessage).HasColumnName("status_message");

                entity.Property(e => e.TransactionTxnId).HasColumnName("transaction_txn_id");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Conversations>(entity =>
            {
                entity.HasKey(e => e.ConversationId)
                    .HasName("PRIMARY");

                entity.ToTable("conversations");

                entity.Property(e => e.ConversationId)
                    .HasColumnName("conversation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Color)
                    .HasColumnName("color")
                    .HasMaxLength(32);

                entity.Property(e => e.LastMessageId)
                    .HasColumnName("last_message_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<ConversationsCallsAudio>(entity =>
            {
                entity.HasKey(e => e.CallId)
                    .HasName("PRIMARY");

                entity.ToTable("conversations_calls_audio");

                entity.Property(e => e.CallId)
                    .HasColumnName("call_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Answered)
                    .IsRequired()
                    .HasColumnName("answered")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Declined)
                    .IsRequired()
                    .HasColumnName("declined")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FromUserId)
                    .HasColumnName("from_user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.FromUserToken)
                    .IsRequired()
                    .HasColumnName("from_user_token")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Room)
                    .IsRequired()
                    .HasColumnName("room")
                    .HasMaxLength(64);

                entity.Property(e => e.ToUserId)
                    .HasColumnName("to_user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ToUserToken)
                    .IsRequired()
                    .HasColumnName("to_user_token")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<ConversationsCallsVideo>(entity =>
            {
                entity.HasKey(e => e.CallId)
                    .HasName("PRIMARY");

                entity.ToTable("conversations_calls_video");

                entity.Property(e => e.CallId)
                    .HasColumnName("call_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Answered)
                    .IsRequired()
                    .HasColumnName("answered")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Declined)
                    .IsRequired()
                    .HasColumnName("declined")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FromUserId)
                    .HasColumnName("from_user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.FromUserToken)
                    .IsRequired()
                    .HasColumnName("from_user_token");

                entity.Property(e => e.Room)
                    .IsRequired()
                    .HasColumnName("room")
                    .HasMaxLength(64);

                entity.Property(e => e.ToUserId)
                    .HasColumnName("to_user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ToUserToken)
                    .IsRequired()
                    .HasColumnName("to_user_token");
            });

            modelBuilder.Entity<ConversationsMessages>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PRIMARY");

                entity.ToTable("conversations_messages");

                entity.Property(e => e.MessageId)
                    .HasColumnName("message_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ConversationId)
                    .HasColumnName("conversation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(256);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.VoiceNote)
                    .IsRequired()
                    .HasColumnName("voice_note")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ConversationsUsers>(entity =>
            {
                entity.ToTable("conversations_users");

                entity.HasIndex(e => new { e.ConversationId, e.UserId })
                    .HasName("conversation_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ConversationId)
                    .HasColumnName("conversation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Deleted)
                    .IsRequired()
                    .HasColumnName("deleted")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Seen)
                    .IsRequired()
                    .HasColumnName("seen")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Typing)
                    .IsRequired()
                    .HasColumnName("typing")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<CustomFields>(entity =>
            {
                entity.HasKey(e => e.FieldId)
                    .HasName("PRIMARY");

                entity.ToTable("custom_fields");

                entity.Property(e => e.FieldId)
                    .HasColumnName("field_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.FieldFor)
                    .IsRequired()
                    .HasColumnName("field_for")
                    .HasColumnType("enum('user','page','group','event')")
                    .HasDefaultValueSql("'user'");

                entity.Property(e => e.FieldOrder)
                    .HasColumnName("field_order")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.InProfile)
                    .IsRequired()
                    .HasColumnName("in_profile")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InRegistration)
                    .IsRequired()
                    .HasColumnName("in_registration")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
                    .HasMaxLength(256);

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasDefaultValueSql("'32'");

                entity.Property(e => e.Mandatory)
                    .IsRequired()
                    .HasColumnName("mandatory")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnName("place")
                    .HasMaxLength(32);

                entity.Property(e => e.SelectOptions)
                    .IsRequired()
                    .HasColumnName("select_options")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<CustomFieldsValues>(entity =>
            {
                entity.HasKey(e => e.ValueId)
                    .HasName("PRIMARY");

                entity.ToTable("custom_fields_values");

                entity.HasIndex(e => new { e.FieldId, e.NodeId, e.NodeType })
                    .HasName("field_id_node_id_node_type")
                    .IsUnique();

                entity.Property(e => e.ValueId)
                    .HasColumnName("value_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.FieldId)
                    .HasColumnName("field_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnName("node_type")
                    .HasColumnType("enum('user','page','group','event')");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<DevelopersApps>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PRIMARY");

                entity.ToTable("developers_apps");

                entity.HasIndex(e => e.AppAuthId)
                    .HasName("app_auth_id")
                    .IsUnique();

                entity.HasIndex(e => e.AppAuthSecret)
                    .HasName("app_auth_secret")
                    .IsUnique();

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AppAuthId)
                    .IsRequired()
                    .HasColumnName("app_auth_id")
                    .HasMaxLength(128);

                entity.Property(e => e.AppAuthSecret)
                    .IsRequired()
                    .HasColumnName("app_auth_secret")
                    .HasMaxLength(128);

                entity.Property(e => e.AppCategoryId)
                    .HasColumnName("app_category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AppDescription)
                    .IsRequired()
                    .HasColumnName("app_description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.AppDomain)
                    .IsRequired()
                    .HasColumnName("app_domain")
                    .HasMaxLength(256);

                entity.Property(e => e.AppIcon)
                    .IsRequired()
                    .HasColumnName("app_icon")
                    .HasMaxLength(256);

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnName("app_name")
                    .HasMaxLength(256);

                entity.Property(e => e.AppRedirectUrl)
                    .IsRequired()
                    .HasColumnName("app_redirect_url")
                    .HasMaxLength(256);

                entity.Property(e => e.AppUserId)
                    .HasColumnName("app_user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<DevelopersAppsCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("developers_apps_categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(256);

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<DevelopersAppsUsers>(entity =>
            {
                entity.ToTable("developers_apps_users");

                entity.HasIndex(e => new { e.AppId, e.UserId })
                    .HasName("page_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AccessToken)
                    .HasColumnName("access_token")
                    .HasMaxLength(128);

                entity.Property(e => e.AppId)
                    .HasColumnName("app_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AuthKey)
                    .IsRequired()
                    .HasColumnName("auth_key")
                    .HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Emojis>(entity =>
            {
                entity.HasKey(e => e.EmojiId)
                    .HasName("PRIMARY");

                entity.ToTable("emojis");

                entity.Property(e => e.EmojiId)
                    .HasColumnName("emoji_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasColumnName("class")
                    .HasMaxLength(256);

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasColumnName("pattern")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PRIMARY");

                entity.ToTable("events");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventAdmin)
                    .HasColumnName("event_admin")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventAlbumCovers).HasColumnName("event_album_covers");

                entity.Property(e => e.EventAlbumTimeline).HasColumnName("event_album_timeline");

                entity.Property(e => e.EventCategory)
                    .HasColumnName("event_category")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventCover)
                    .HasColumnName("event_cover")
                    .HasMaxLength(256);

                entity.Property(e => e.EventCoverId)
                    .HasColumnName("event_cover_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventCoverPosition)
                    .HasColumnName("event_cover_position")
                    .HasMaxLength(256);

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasColumnName("event_description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.EventGoing)
                    .HasColumnName("event_going")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventInterested)
                    .HasColumnName("event_interested")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventInvited)
                    .HasColumnName("event_invited")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventLocation)
                    .HasColumnName("event_location")
                    .HasMaxLength(256);

                entity.Property(e => e.EventPinnedPost).HasColumnName("event_pinned_post");

                entity.Property(e => e.EventPrivacy)
                    .HasColumnName("event_privacy")
                    .HasColumnType("enum('secret','closed','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.EventPublishApprovalEnabled)
                    .IsRequired()
                    .HasColumnName("event_publish_approval_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventPublishEnabled)
                    .IsRequired()
                    .HasColumnName("event_publish_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EventTitle)
                    .IsRequired()
                    .HasColumnName("event_title")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<EventsCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("events_categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(256);

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<EventsMembers>(entity =>
            {
                entity.ToTable("events_members");

                entity.HasIndex(e => new { e.EventId, e.UserId })
                    .HasName("group_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.IsGoing)
                    .HasColumnName("is_going")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsInterested)
                    .HasColumnName("is_interested")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsInvited)
                    .HasColumnName("is_invited")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Followings>(entity =>
            {
                entity.ToTable("followings");

                entity.HasIndex(e => new { e.UserId, e.FollowingId })
                    .HasName("user_id_following_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.FollowingId)
                    .HasColumnName("following_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Forums>(entity =>
            {
                entity.HasKey(e => e.ForumId)
                    .HasName("PRIMARY");

                entity.ToTable("forums");

                entity.Property(e => e.ForumId)
                    .HasColumnName("forum_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ForumDescription)
                    .HasColumnName("forum_description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.ForumName)
                    .IsRequired()
                    .HasColumnName("forum_name")
                    .HasMaxLength(256);

                entity.Property(e => e.ForumOrder)
                    .HasColumnName("forum_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ForumReplies)
                    .HasColumnName("forum_replies")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ForumSection)
                    .HasColumnName("forum_section")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ForumThreads)
                    .HasColumnName("forum_threads")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<ForumsReplies>(entity =>
            {
                entity.HasKey(e => e.ReplyId)
                    .HasName("PRIMARY");

                entity.ToTable("forums_replies");

                entity.Property(e => e.ReplyId)
                    .HasColumnName("reply_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("longtext");

                entity.Property(e => e.ThreadId)
                    .HasColumnName("thread_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<ForumsThreads>(entity =>
            {
                entity.HasKey(e => e.ThreadId)
                    .HasName("PRIMARY");

                entity.ToTable("forums_threads");

                entity.Property(e => e.ThreadId)
                    .HasColumnName("thread_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ForumId)
                    .HasColumnName("forum_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Replies)
                    .HasColumnName("replies")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("longtext");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Friends>(entity =>
            {
                entity.ToTable("friends");

                entity.HasIndex(e => new { e.UserOneId, e.UserTwoId })
                    .HasName("user_one_id_user_two_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserOneId)
                    .HasColumnName("user_one_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserTwoId)
                    .HasColumnName("user_two_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.HasKey(e => e.GameId)
                    .HasName("PRIMARY");

                entity.ToTable("games");

                entity.Property(e => e.GameId).HasColumnName("game_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnName("thumbnail")
                    .HasMaxLength(256);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<GamesPlayers>(entity =>
            {
                entity.ToTable("games_players");

                entity.HasIndex(e => new { e.GameId, e.UserId })
                    .HasName("game_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GameId)
                    .HasColumnName("game_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Gifts>(entity =>
            {
                entity.HasKey(e => e.GiftId)
                    .HasName("PRIMARY");

                entity.ToTable("gifts");

                entity.Property(e => e.GiftId)
                    .HasColumnName("gift_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("groups");

                entity.HasIndex(e => e.GroupName)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GroupAdmin)
                    .HasColumnName("group_admin")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GroupAlbumCovers).HasColumnName("group_album_covers");

                entity.Property(e => e.GroupAlbumPictures).HasColumnName("group_album_pictures");

                entity.Property(e => e.GroupAlbumTimeline).HasColumnName("group_album_timeline");

                entity.Property(e => e.GroupCategory)
                    .HasColumnName("group_category")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GroupCover)
                    .HasColumnName("group_cover")
                    .HasMaxLength(256);

                entity.Property(e => e.GroupCoverId)
                    .HasColumnName("group_cover_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GroupCoverPosition)
                    .HasColumnName("group_cover_position")
                    .HasMaxLength(256);

                entity.Property(e => e.GroupDescription)
                    .IsRequired()
                    .HasColumnName("group_description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.GroupMembers)
                    .HasColumnName("group_members")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name")
                    .HasMaxLength(64);

                entity.Property(e => e.GroupPicture)
                    .HasColumnName("group_picture")
                    .HasMaxLength(256);

                entity.Property(e => e.GroupPictureId)
                    .HasColumnName("group_picture_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GroupPinnedPost).HasColumnName("group_pinned_post");

                entity.Property(e => e.GroupPrivacy)
                    .HasColumnName("group_privacy")
                    .HasColumnType("enum('secret','closed','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.GroupPublishApprovalEnabled)
                    .IsRequired()
                    .HasColumnName("group_publish_approval_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupPublishEnabled)
                    .IsRequired()
                    .HasColumnName("group_publish_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GroupTitle)
                    .IsRequired()
                    .HasColumnName("group_title")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<GroupsAdmins>(entity =>
            {
                entity.ToTable("groups_admins");

                entity.HasIndex(e => new { e.GroupId, e.UserId })
                    .HasName("group_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<GroupsCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("groups_categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(256);

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<GroupsMembers>(entity =>
            {
                entity.ToTable("groups_members");

                entity.HasIndex(e => new { e.GroupId, e.UserId })
                    .HasName("group_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Approved)
                    .IsRequired()
                    .HasColumnName("approved")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Hashtags>(entity =>
            {
                entity.HasKey(e => e.HashtagId)
                    .HasName("PRIMARY");

                entity.ToTable("hashtags");

                entity.Property(e => e.HashtagId)
                    .HasColumnName("hashtag_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Hashtag)
                    .IsRequired()
                    .HasColumnName("hashtag")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<HashtagsPosts>(entity =>
            {
                entity.ToTable("hashtags_posts");

                entity.HasIndex(e => new { e.PostId, e.HashtagId })
                    .HasName("post_id_hashtag_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.HashtagId)
                    .HasColumnName("hashtag_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<InvitationCodes>(entity =>
            {
                entity.HasKey(e => e.CodeId)
                    .HasName("PRIMARY");

                entity.ToTable("invitation_codes");

                entity.Property(e => e.CodeId)
                    .HasColumnName("code_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(64);

                entity.Property(e => e.Valid)
                    .IsRequired()
                    .HasColumnName("valid")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<JobsCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("jobs_categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(256);

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MarketCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("market_categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(256);

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.HasKey(e => e.MovieId)
                    .HasName("PRIMARY");

                entity.ToTable("movies");

                entity.Property(e => e.MovieId)
                    .HasColumnName("movie_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Genres)
                    .HasColumnName("genres")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.ImdbUrl).HasColumnName("imdb_url");

                entity.Property(e => e.Poster)
                    .HasColumnName("poster")
                    .HasMaxLength(256);

                entity.Property(e => e.ReleaseYear).HasColumnName("release_year");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source");

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnName("source_type")
                    .HasMaxLength(64);

                entity.Property(e => e.Stars).HasColumnName("stars");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<MoviesGenres>(entity =>
            {
                entity.HasKey(e => e.GenreId)
                    .HasName("PRIMARY");

                entity.ToTable("movies_genres");

                entity.Property(e => e.GenreId)
                    .HasColumnName("genre_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GenreDescription)
                    .IsRequired()
                    .HasColumnName("genre_description");

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnName("genre_name")
                    .HasMaxLength(256);

                entity.Property(e => e.GenreOrder)
                    .HasColumnName("genre_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PRIMARY");

                entity.ToTable("notifications");

                entity.Property(e => e.NotificationId)
                    .HasColumnName("notification_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action")
                    .HasMaxLength(256);

                entity.Property(e => e.FromUserId)
                    .HasColumnName("from_user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnName("node_type")
                    .HasMaxLength(256);

                entity.Property(e => e.NodeUrl)
                    .IsRequired()
                    .HasColumnName("node_url")
                    .HasMaxLength(256);

                entity.Property(e => e.NotifyId)
                    .HasColumnName("notify_id")
                    .HasMaxLength(256);

                entity.Property(e => e.Seen)
                    .IsRequired()
                    .HasColumnName("seen")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ToUserId)
                    .HasColumnName("to_user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<OffersCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("offers_categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(256);

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Packages>(entity =>
            {
                entity.HasKey(e => e.PackageId)
                    .HasName("PRIMARY");

                entity.ToTable("packages");

                entity.Property(e => e.PackageId).HasColumnName("package_id");

                entity.Property(e => e.BoostPages)
                    .HasColumnName("boost_pages")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.BoostPagesEnabled)
                    .IsRequired()
                    .HasColumnName("boost_pages_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BoostPosts)
                    .HasColumnName("boost_posts")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.BoostPostsEnabled)
                    .IsRequired()
                    .HasColumnName("boost_posts_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasColumnName("color")
                    .HasMaxLength(32);

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(256);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Period)
                    .IsRequired()
                    .HasColumnName("period")
                    .HasMaxLength(32);

                entity.Property(e => e.PeriodNum)
                    .HasColumnName("period_num")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasMaxLength(32);

                entity.Property(e => e.VerificationBadgeEnabled)
                    .IsRequired()
                    .HasColumnName("verification_badge_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PackagesPayments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PRIMARY");

                entity.ToTable("packages_payments");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasColumnName("package_name")
                    .HasMaxLength(256);

                entity.Property(e => e.PackagePrice)
                    .IsRequired()
                    .HasColumnName("package_price")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Pages>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("PRIMARY");

                entity.ToTable("pages");

                entity.HasIndex(e => e.PageName)
                    .HasName("username")
                    .IsUnique();

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageActionColor)
                    .HasColumnName("page_action_color")
                    .HasMaxLength(32);

                entity.Property(e => e.PageActionText)
                    .HasColumnName("page_action_text")
                    .HasMaxLength(32);

                entity.Property(e => e.PageActionUrl)
                    .HasColumnName("page_action_url")
                    .HasMaxLength(256);

                entity.Property(e => e.PageAdmin)
                    .HasColumnName("page_admin")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageAlbumCovers)
                    .HasColumnName("page_album_covers")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageAlbumPictures)
                    .HasColumnName("page_album_pictures")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageAlbumTimeline)
                    .HasColumnName("page_album_timeline")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageBoosted)
                    .IsRequired()
                    .HasColumnName("page_boosted")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PageBoostedBy)
                    .HasColumnName("page_boosted_by")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageCategory)
                    .HasColumnName("page_category")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageCompany)
                    .HasColumnName("page_company")
                    .HasMaxLength(256);

                entity.Property(e => e.PageCover)
                    .HasColumnName("page_cover")
                    .HasMaxLength(256);

                entity.Property(e => e.PageCoverId)
                    .HasColumnName("page_cover_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageCoverPosition)
                    .HasColumnName("page_cover_position")
                    .HasMaxLength(256);

                entity.Property(e => e.PageDescription)
                    .IsRequired()
                    .HasColumnName("page_description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.PageLikes)
                    .HasColumnName("page_likes")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageLocation)
                    .HasColumnName("page_location")
                    .HasMaxLength(256);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasColumnName("page_name")
                    .HasMaxLength(64);

                entity.Property(e => e.PagePhone)
                    .HasColumnName("page_phone")
                    .HasMaxLength(256);

                entity.Property(e => e.PagePicture)
                    .HasColumnName("page_picture")
                    .HasMaxLength(256);

                entity.Property(e => e.PagePictureId)
                    .HasColumnName("page_picture_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PagePinnedPost)
                    .HasColumnName("page_pinned_post")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageSocialFacebook)
                    .HasColumnName("page_social_facebook")
                    .HasMaxLength(256);

                entity.Property(e => e.PageSocialInstagram)
                    .HasColumnName("page_social_instagram")
                    .HasMaxLength(256);

                entity.Property(e => e.PageSocialLinkedin)
                    .HasColumnName("page_social_linkedin")
                    .HasMaxLength(256);

                entity.Property(e => e.PageSocialTwitter)
                    .HasColumnName("page_social_twitter")
                    .HasMaxLength(256);

                entity.Property(e => e.PageSocialVkontakte)
                    .HasColumnName("page_social_vkontakte")
                    .HasMaxLength(256);

                entity.Property(e => e.PageSocialYoutube)
                    .HasColumnName("page_social_youtube")
                    .HasMaxLength(256);

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnName("page_title")
                    .HasMaxLength(256);

                entity.Property(e => e.PageVerified)
                    .IsRequired()
                    .HasColumnName("page_verified")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PageWebsite)
                    .HasColumnName("page_website")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<PagesAdmins>(entity =>
            {
                entity.ToTable("pages_admins");

                entity.HasIndex(e => new { e.PageId, e.UserId })
                    .HasName("page_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PagesCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("pages_categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name")
                    .HasMaxLength(256);

                entity.Property(e => e.CategoryOrder)
                    .HasColumnName("category_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PagesInvites>(entity =>
            {
                entity.ToTable("pages_invites");

                entity.HasIndex(e => new { e.PageId, e.UserId, e.FromUserId })
                    .HasName("page_id_user_id_from_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.FromUserId)
                    .HasColumnName("from_user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PagesLikes>(entity =>
            {
                entity.ToTable("pages_likes");

                entity.HasIndex(e => new { e.PageId, e.UserId })
                    .HasName("page_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PageId)
                    .HasColumnName("page_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PointsPayments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PRIMARY");

                entity.ToTable("points_payments");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.Amount)
                    .IsRequired()
                    .HasColumnName("amount")
                    .HasMaxLength(32);

                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnName("method")
                    .HasMaxLength(64);

                entity.Property(e => e.MethodValue)
                    .IsRequired()
                    .HasColumnName("method_value");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PRIMARY");

                entity.ToTable("posts");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Boosted)
                    .IsRequired()
                    .HasColumnName("boosted")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BoostedBy)
                    .HasColumnName("boosted_by")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ColoredPattern)
                    .HasColumnName("colored_pattern")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CommentsDisabled)
                    .IsRequired()
                    .HasColumnName("comments_disabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventApproved)
                    .IsRequired()
                    .HasColumnName("event_approved")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.FeelingAction)
                    .HasColumnName("feeling_action")
                    .HasMaxLength(32);

                entity.Property(e => e.FeelingValue)
                    .HasColumnName("feeling_value")
                    .HasMaxLength(256);

                entity.Property(e => e.GroupApproved)
                    .IsRequired()
                    .HasColumnName("group_approved")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.InEvent)
                    .IsRequired()
                    .HasColumnName("in_event")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InGroup)
                    .IsRequired()
                    .HasColumnName("in_group")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InWall)
                    .IsRequired()
                    .HasColumnName("in_wall")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsAnonymous)
                    .IsRequired()
                    .HasColumnName("is_anonymous")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsHidden)
                    .IsRequired()
                    .HasColumnName("is_hidden")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(256);

                entity.Property(e => e.OriginId)
                    .HasColumnName("origin_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PointsEarned)
                    .IsRequired()
                    .HasColumnName("points_earned")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PostType)
                    .IsRequired()
                    .HasColumnName("post_type")
                    .HasMaxLength(32);

                entity.Property(e => e.Privacy)
                    .IsRequired()
                    .HasColumnName("privacy")
                    .HasMaxLength(32);

                entity.Property(e => e.ReactionAngryCount)
                    .HasColumnName("reaction_angry_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionHahaCount)
                    .HasColumnName("reaction_haha_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionLikeCount)
                    .HasColumnName("reaction_like_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionLoveCount)
                    .HasColumnName("reaction_love_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionSadCount)
                    .HasColumnName("reaction_sad_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionWowCount)
                    .HasColumnName("reaction_wow_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionYayCount)
                    .HasColumnName("reaction_yay_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Shares)
                    .HasColumnName("shares")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnName("user_type")
                    .HasColumnType("enum('user','page')");

                entity.Property(e => e.WallId)
                    .HasColumnName("wall_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsArticles>(entity =>
            {
                entity.HasKey(e => e.ArticleId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_articles");

                entity.Property(e => e.ArticleId)
                    .HasColumnName("article_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Cover)
                    .IsRequired()
                    .HasColumnName("cover")
                    .HasMaxLength(256);

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasColumnName("tags")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("longtext");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);

                entity.Property(e => e.Views)
                    .HasColumnName("views")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsAudios>(entity =>
            {
                entity.HasKey(e => e.AudioId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_audios");

                entity.Property(e => e.AudioId)
                    .HasColumnName("audio_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(256);

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<PostsColoredPatterns>(entity =>
            {
                entity.HasKey(e => e.PatternId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_colored_patterns");

                entity.Property(e => e.PatternId)
                    .HasColumnName("pattern_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.BackgroundColor1)
                    .HasColumnName("background_color_1")
                    .HasMaxLength(32);

                entity.Property(e => e.BackgroundColor2)
                    .HasColumnName("background_color_2")
                    .HasMaxLength(32);

                entity.Property(e => e.BackgroundImage)
                    .HasColumnName("background_image")
                    .HasMaxLength(256);

                entity.Property(e => e.TextColor)
                    .HasColumnName("text_color")
                    .HasMaxLength(32);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("enum('color','image')")
                    .HasDefaultValueSql("'color'");
            });

            modelBuilder.Entity<PostsComments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_comments");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(256);

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnName("node_type")
                    .HasColumnType("enum('post','photo','comment')");

                entity.Property(e => e.PointsEarned)
                    .IsRequired()
                    .HasColumnName("points_earned")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReactionAngryCount)
                    .HasColumnName("reaction_angry_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionHahaCount)
                    .HasColumnName("reaction_haha_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionLikeCount)
                    .HasColumnName("reaction_like_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionLoveCount)
                    .HasColumnName("reaction_love_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionSadCount)
                    .HasColumnName("reaction_sad_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionWowCount)
                    .HasColumnName("reaction_wow_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionYayCount)
                    .HasColumnName("reaction_yay_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Replies)
                    .HasColumnName("replies")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnName("user_type")
                    .HasColumnType("enum('user','page')");

                entity.Property(e => e.VoiceNote)
                    .HasColumnName("voice_note")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<PostsCommentsReactions>(entity =>
            {
                entity.ToTable("posts_comments_reactions");

                entity.HasIndex(e => new { e.CommentId, e.UserId })
                    .HasName("comment_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PointsEarned)
                    .IsRequired()
                    .HasColumnName("points_earned")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reaction)
                    .HasColumnName("reaction")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("'like'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsFiles>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_files");

                entity.Property(e => e.FileId)
                    .HasColumnName("file_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<PostsHidden>(entity =>
            {
                entity.ToTable("posts_hidden");

                entity.HasIndex(e => new { e.PostId, e.UserId })
                    .HasName("post_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsJobs>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_jobs");

                entity.Property(e => e.JobId)
                    .HasColumnName("job_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasColumnName("available")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CoverImage)
                    .IsRequired()
                    .HasColumnName("cover_image")
                    .HasMaxLength(256);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(100);

                entity.Property(e => e.PaySalaryPer)
                    .IsRequired()
                    .HasColumnName("pay_salary_per")
                    .HasMaxLength(100);

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Question1Choices).HasColumnName("question_1_choices");

                entity.Property(e => e.Question1Title)
                    .HasColumnName("question_1_title")
                    .HasMaxLength(256);

                entity.Property(e => e.Question1Type)
                    .HasColumnName("question_1_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Question2Choices).HasColumnName("question_2_choices");

                entity.Property(e => e.Question2Title)
                    .HasColumnName("question_2_title")
                    .HasMaxLength(256);

                entity.Property(e => e.Question2Type)
                    .HasColumnName("question_2_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Question3Choices).HasColumnName("question_3_choices");

                entity.Property(e => e.Question3Title)
                    .HasColumnName("question_3_title")
                    .HasMaxLength(256);

                entity.Property(e => e.Question3Type)
                    .HasColumnName("question_3_type")
                    .HasMaxLength(100);

                entity.Property(e => e.SalaryMaximum)
                    .IsRequired()
                    .HasColumnName("salary_maximum")
                    .HasMaxLength(100);

                entity.Property(e => e.SalaryMinimum)
                    .IsRequired()
                    .HasColumnName("salary_minimum")
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PostsJobsApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_jobs_applications");

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("application_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(100);

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Question1Answer).HasColumnName("question_1_answer");

                entity.Property(e => e.Question2Answer).HasColumnName("question_2_answer");

                entity.Property(e => e.Question3Answer).HasColumnName("question_3_answer");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.WorkDescription).HasColumnName("work_description");

                entity.Property(e => e.WorkFrom)
                    .HasColumnName("work_from")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkNow)
                    .HasColumnName("work_now")
                    .HasColumnType("enum('0','1')");

                entity.Property(e => e.WorkPlace)
                    .HasColumnName("work_place")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkPosition)
                    .HasColumnName("work_position")
                    .HasMaxLength(100);

                entity.Property(e => e.WorkTo)
                    .HasColumnName("work_to")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PostsLinks>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_links");

                entity.Property(e => e.LinkId)
                    .HasColumnName("link_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.SourceHost)
                    .IsRequired()
                    .HasColumnName("source_host")
                    .HasMaxLength(256);

                entity.Property(e => e.SourceText)
                    .IsRequired()
                    .HasColumnName("source_text")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.SourceThumbnail)
                    .IsRequired()
                    .HasColumnName("source_thumbnail");

                entity.Property(e => e.SourceTitle)
                    .IsRequired()
                    .HasColumnName("source_title")
                    .HasMaxLength(256);

                entity.Property(e => e.SourceUrl)
                    .IsRequired()
                    .HasColumnName("source_url");
            });

            modelBuilder.Entity<PostsLive>(entity =>
            {
                entity.HasKey(e => e.LiveId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_live");

                entity.Property(e => e.LiveId)
                    .HasColumnName("live_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AgoraChannelName)
                    .IsRequired()
                    .HasColumnName("agora_channel_name")
                    .HasMaxLength(256);

                entity.Property(e => e.AgoraFile).HasColumnName("agora_file");

                entity.Property(e => e.AgoraResourceId).HasColumnName("agora_resource_id");

                entity.Property(e => e.AgoraSid)
                    .HasColumnName("agora_sid")
                    .HasMaxLength(256);

                entity.Property(e => e.AgoraUid).HasColumnName("agora_uid");

                entity.Property(e => e.LiveEnded)
                    .IsRequired()
                    .HasColumnName("live_ended")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LiveRecorded)
                    .IsRequired()
                    .HasColumnName("live_recorded")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.VideoThumbnail)
                    .IsRequired()
                    .HasColumnName("video_thumbnail")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<PostsLiveUsers>(entity =>
            {
                entity.ToTable("posts_live_users");

                entity.HasIndex(e => new { e.UserId, e.PostId })
                    .HasName("user_id_post_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsMedia>(entity =>
            {
                entity.HasKey(e => e.MediaId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_media");

                entity.Property(e => e.MediaId)
                    .HasColumnName("media_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.SourceHtml)
                    .HasColumnName("source_html")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.SourceProvider)
                    .IsRequired()
                    .HasColumnName("source_provider")
                    .HasMaxLength(256);

                entity.Property(e => e.SourceText)
                    .HasColumnName("source_text")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.SourceThumbnail).HasColumnName("source_thumbnail");

                entity.Property(e => e.SourceTitle)
                    .HasColumnName("source_title")
                    .HasMaxLength(256);

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasColumnName("source_type")
                    .HasMaxLength(256);

                entity.Property(e => e.SourceUrl)
                    .IsRequired()
                    .HasColumnName("source_url")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<PostsOffers>(entity =>
            {
                entity.HasKey(e => e.OfferId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_offers");

                entity.Property(e => e.OfferId)
                    .HasColumnName("offer_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AmountY)
                    .IsRequired()
                    .HasColumnName("amount_y")
                    .HasMaxLength(100);

                entity.Property(e => e.BuyX)
                    .IsRequired()
                    .HasColumnName("buy_x")
                    .HasMaxLength(100);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.DiscountAmount)
                    .IsRequired()
                    .HasColumnName("discount_amount")
                    .HasMaxLength(100);

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("discount_percent")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.DiscountType)
                    .IsRequired()
                    .HasColumnName("discount_type")
                    .HasMaxLength(32);

                entity.Property(e => e.GetY)
                    .IsRequired()
                    .HasColumnName("get_y")
                    .HasMaxLength(100);

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.SpendX)
                    .IsRequired()
                    .HasColumnName("spend_x")
                    .HasMaxLength(100);

                entity.Property(e => e.Thumbnail)
                    .IsRequired()
                    .HasColumnName("thumbnail")
                    .HasMaxLength(256);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PostsPhotos>(entity =>
            {
                entity.HasKey(e => e.PhotoId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_photos");

                entity.Property(e => e.PhotoId)
                    .HasColumnName("photo_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AlbumId)
                    .HasColumnName("album_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Blur)
                    .IsRequired()
                    .HasColumnName("blur")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionAngryCount)
                    .HasColumnName("reaction_angry_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionHahaCount)
                    .HasColumnName("reaction_haha_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionLikeCount)
                    .HasColumnName("reaction_like_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionLoveCount)
                    .HasColumnName("reaction_love_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionSadCount)
                    .HasColumnName("reaction_sad_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionWowCount)
                    .HasColumnName("reaction_wow_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReactionYayCount)
                    .HasColumnName("reaction_yay_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<PostsPhotosAlbums>(entity =>
            {
                entity.HasKey(e => e.AlbumId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_photos_albums");

                entity.Property(e => e.AlbumId)
                    .HasColumnName("album_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.InEvent)
                    .IsRequired()
                    .HasColumnName("in_event")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InGroup)
                    .IsRequired()
                    .HasColumnName("in_group")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Privacy)
                    .IsRequired()
                    .HasColumnName("privacy")
                    .HasColumnType("enum('me','friends','public','custom')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserType)
                    .IsRequired()
                    .HasColumnName("user_type")
                    .HasColumnType("enum('user','page')");
            });

            modelBuilder.Entity<PostsPhotosReactions>(entity =>
            {
                entity.ToTable("posts_photos_reactions");

                entity.HasIndex(e => new { e.UserId, e.PhotoId })
                    .HasName("user_id_photo_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PhotoId)
                    .HasColumnName("photo_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PointsEarned)
                    .HasColumnName("points_earned")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reaction)
                    .IsRequired()
                    .HasColumnName("reaction")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("'like'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsPolls>(entity =>
            {
                entity.HasKey(e => e.PollId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_polls");

                entity.Property(e => e.PollId)
                    .HasColumnName("poll_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Votes)
                    .HasColumnName("votes")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsPollsOptions>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_polls_options");

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PollId)
                    .HasColumnName("poll_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<PostsPollsOptionsUsers>(entity =>
            {
                entity.ToTable("posts_polls_options_users");

                entity.HasIndex(e => new { e.UserId, e.PollId })
                    .HasName("user_id_poll_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PollId)
                    .HasColumnName("poll_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_products");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasColumnName("available")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasMaxLength(32);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("enum('new','old')")
                    .HasDefaultValueSql("'new'");
            });

            modelBuilder.Entity<PostsReactions>(entity =>
            {
                entity.ToTable("posts_reactions");

                entity.HasIndex(e => new { e.PostId, e.UserId })
                    .HasName("post_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PointsEarned)
                    .IsRequired()
                    .HasColumnName("points_earned")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Reaction)
                    .IsRequired()
                    .HasColumnName("reaction")
                    .HasMaxLength(32)
                    .HasDefaultValueSql("'like'");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsSaved>(entity =>
            {
                entity.ToTable("posts_saved");

                entity.HasIndex(e => new { e.PostId, e.UserId })
                    .HasName("post_id_user_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<PostsVideos>(entity =>
            {
                entity.HasKey(e => e.VideoId)
                    .HasName("PRIMARY");

                entity.ToTable("posts_videos");

                entity.Property(e => e.VideoId)
                    .HasColumnName("video_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PostId)
                    .HasColumnName("post_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(256);

                entity.Property(e => e.Thumbnail)
                    .HasColumnName("thumbnail")
                    .HasMaxLength(256);

                entity.Property(e => e.Views).HasColumnName("views");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PRIMARY");

                entity.ToTable("reports");

                entity.Property(e => e.ReportId)
                    .HasColumnName("report_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnName("node_type")
                    .HasMaxLength(32);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<StaticPages>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("PRIMARY");

                entity.ToTable("static_pages");

                entity.HasIndex(e => e.PageUrl)
                    .HasName("page_url")
                    .IsUnique();

                entity.Property(e => e.PageId).HasColumnName("page_id");

                entity.Property(e => e.PageInFooter)
                    .IsRequired()
                    .HasColumnName("page_in_footer")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PageOrder)
                    .HasColumnName("page_order")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PageText)
                    .IsRequired()
                    .HasColumnName("page_text")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.PageTitle)
                    .IsRequired()
                    .HasColumnName("page_title")
                    .HasMaxLength(256);

                entity.Property(e => e.PageUrl)
                    .IsRequired()
                    .HasColumnName("page_url")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Stickers>(entity =>
            {
                entity.HasKey(e => e.StickerId)
                    .HasName("PRIMARY");

                entity.ToTable("stickers");

                entity.Property(e => e.StickerId)
                    .HasColumnName("sticker_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Stories>(entity =>
            {
                entity.HasKey(e => e.StoryId)
                    .HasName("PRIMARY");

                entity.ToTable("stories");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<StoriesMedia>(entity =>
            {
                entity.HasKey(e => e.MediaId)
                    .HasName("PRIMARY");

                entity.ToTable("stories_media");

                entity.Property(e => e.MediaId)
                    .HasColumnName("media_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.IsPhoto)
                    .IsRequired()
                    .HasColumnName("is_photo")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("source")
                    .HasMaxLength(256);

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<SystemCountries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PRIMARY");

                entity.ToTable("system_countries");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(2);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<SystemCurrencies>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PRIMARY");

                entity.ToTable("system_currencies");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("currency_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(32);

                entity.Property(e => e.Default)
                    .IsRequired()
                    .HasColumnName("default")
                    .HasColumnType("enum('0','1')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(256);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasColumnName("symbol")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<SystemLanguages>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PRIMARY");

                entity.ToTable("system_languages");

                entity.HasIndex(e => e.Code)
                    .HasName("code")
                    .IsUnique();

                entity.Property(e => e.LanguageId)
                    .HasColumnName("language_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(32);

                entity.Property(e => e.Default)
                    .IsRequired()
                    .HasColumnName("default")
                    .HasColumnType("enum('0','1')");

                entity.Property(e => e.Dir)
                    .IsRequired()
                    .HasColumnName("dir")
                    .HasColumnType("enum('LTR','RTL')");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasColumnName("enabled")
                    .HasColumnType("enum('0','1')");

                entity.Property(e => e.Flag)
                    .IsRequired()
                    .HasColumnName("flag")
                    .HasMaxLength(256);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<SystemOptions>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("system_options");

                entity.HasIndex(e => e.OptionName)
                    .HasName("option_name")
                    .IsUnique();

                entity.Property(e => e.OptionId)
                    .HasColumnName("option_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.OptionName)
                    .IsRequired()
                    .HasColumnName("option_name")
                    .HasMaxLength(128);

                entity.Property(e => e.OptionValue)
                    .HasColumnName("option_value")
                    .HasMaxLength(2048);
            });

            modelBuilder.Entity<SystemThemes>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PRIMARY");

                entity.ToTable("system_themes");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.ThemeId)
                    .HasColumnName("theme_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Default)
                    .IsRequired()
                    .HasColumnName("default")
                    .HasColumnType("enum('0','1')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.HasIndex(e => e.FacebookId)
                    .HasName("facebook_id")
                    .IsUnique();

                entity.HasIndex(e => e.GoogleId)
                    .HasName("google_id")
                    .IsUnique();

                entity.HasIndex(e => e.InstagramId)
                    .HasName("instagram_id")
                    .IsUnique();

                entity.HasIndex(e => e.LinkedinId)
                    .HasName("linkedin_id")
                    .IsUnique();

                entity.HasIndex(e => e.TwitterId)
                    .HasName("twitter_id")
                    .IsUnique();

                entity.HasIndex(e => e.UserEmail)
                    .HasName("user_email")
                    .IsUnique();

                entity.HasIndex(e => e.UserName)
                    .HasName("username")
                    .IsUnique();

                entity.HasIndex(e => e.UserPhone)
                    .HasName("user_phone")
                    .IsUnique();

                entity.HasIndex(e => e.VkontakteId)
                    .HasName("vkontakte_id")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ChatSound)
                    .IsRequired()
                    .HasColumnName("chat_sound")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EmailFriendRequests)
                    .IsRequired()
                    .HasColumnName("email_friend_requests")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EmailMentions)
                    .IsRequired()
                    .HasColumnName("email_mentions")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EmailPostComments)
                    .IsRequired()
                    .HasColumnName("email_post_comments")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EmailPostLikes)
                    .IsRequired()
                    .HasColumnName("email_post_likes")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EmailPostShares)
                    .IsRequired()
                    .HasColumnName("email_post_shares")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EmailProfileVisits)
                    .IsRequired()
                    .HasColumnName("email_profile_visits")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EmailWallPosts)
                    .IsRequired()
                    .HasColumnName("email_wall_posts")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FacebookConnected)
                    .IsRequired()
                    .HasColumnName("facebook_connected")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FacebookId)
                    .HasColumnName("facebook_id")
                    .HasMaxLength(128);

                entity.Property(e => e.GoogleConnected)
                    .IsRequired()
                    .HasColumnName("google_connected")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GoogleId)
                    .HasColumnName("google_id")
                    .HasMaxLength(128);

                entity.Property(e => e.InstagramConnected)
                    .IsRequired()
                    .HasColumnName("instagram_connected")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.InstagramId)
                    .HasColumnName("instagram_id")
                    .HasMaxLength(128);

                entity.Property(e => e.LinkedinConnected)
                    .IsRequired()
                    .HasColumnName("linkedin_connected")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LinkedinId)
                    .HasColumnName("linkedin_id")
                    .HasMaxLength(128);

                entity.Property(e => e.NotificationsSound)
                    .IsRequired()
                    .HasColumnName("notifications_sound")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.OnesignalUserId)
                    .HasColumnName("onesignal_user_id")
                    .HasMaxLength(100);

                entity.Property(e => e.TwitterConnected)
                    .IsRequired()
                    .HasColumnName("twitter_connected")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TwitterId)
                    .HasColumnName("twitter_id")
                    .HasMaxLength(128);

                entity.Property(e => e.UserActivated)
                    .IsRequired()
                    .HasColumnName("user_activated")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserAffiliateBalance)
                    .IsRequired()
                    .HasColumnName("user_affiliate_balance")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserAlbumCovers)
                    .HasColumnName("user_album_covers")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserAlbumPictures)
                    .HasColumnName("user_album_pictures")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserAlbumTimeline)
                    .HasColumnName("user_album_timeline")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserBanned)
                    .IsRequired()
                    .HasColumnName("user_banned")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserBiography).HasColumnName("user_biography");

                entity.Property(e => e.UserBirthdate)
                    .HasColumnName("user_birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.UserBoostedPages)
                    .HasColumnName("user_boosted_pages")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserBoostedPosts)
                    .HasColumnName("user_boosted_posts")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserChatEnabled)
                    .IsRequired()
                    .HasColumnName("user_chat_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserCountry)
                    .HasColumnName("user_country")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserCover)
                    .HasColumnName("user_cover")
                    .HasMaxLength(256);

                entity.Property(e => e.UserCoverId)
                    .HasColumnName("user_cover_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserCoverPosition)
                    .HasColumnName("user_cover_position")
                    .HasMaxLength(256);

                entity.Property(e => e.UserCurrentCity)
                    .HasColumnName("user_current_city")
                    .HasMaxLength(256);

                entity.Property(e => e.UserEduClass)
                    .HasColumnName("user_edu_class")
                    .HasMaxLength(256);

                entity.Property(e => e.UserEduMajor)
                    .HasColumnName("user_edu_major")
                    .HasMaxLength(256);

                entity.Property(e => e.UserEduSchool)
                    .HasColumnName("user_edu_school")
                    .HasMaxLength(256);

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasMaxLength(64);

                entity.Property(e => e.UserEmailVerificationCode)
                    .HasColumnName("user_email_verification_code")
                    .HasMaxLength(64);

                entity.Property(e => e.UserEmailVerified)
                    .IsRequired()
                    .HasColumnName("user_email_verified")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserFailedLoginCount)
                    .HasColumnName("user_failed_login_count")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserFailedLoginIp)
                    .HasColumnName("user_failed_login_ip")
                    .HasMaxLength(64);

                entity.Property(e => e.UserFirstname)
                    .IsRequired()
                    .HasColumnName("user_firstname")
                    .HasMaxLength(256);

                entity.Property(e => e.UserGender)
                    .IsRequired()
                    .HasColumnName("user_gender")
                    .HasColumnType("enum('male','female','other')");

                entity.Property(e => e.UserGroup)
                    .HasColumnName("user_group")
                    .HasColumnType("tinyint unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.UserHometown)
                    .HasColumnName("user_hometown")
                    .HasMaxLength(256);

                entity.Property(e => e.UserLanguage)
                    .HasColumnName("user_language")
                    .HasMaxLength(16)
                    .HasDefaultValueSql("'en_us'");

                entity.Property(e => e.UserLastname)
                    .HasColumnName("user_lastname")
                    .HasMaxLength(256);

                entity.Property(e => e.UserLatitude)
                    .IsRequired()
                    .HasColumnName("user_latitude")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserLiveMessagesCounter)
                    .HasColumnName("user_live_messages_counter")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserLiveMessagesLastid)
                    .HasColumnName("user_live_messages_lastid")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserLiveNotificationsCounter)
                    .HasColumnName("user_live_notifications_counter")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserLiveNotificationsLastid)
                    .HasColumnName("user_live_notifications_lastid")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserLiveRequestsCounter)
                    .HasColumnName("user_live_requests_counter")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserLiveRequestsLastid)
                    .HasColumnName("user_live_requests_lastid")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserLongitude)
                    .IsRequired()
                    .HasColumnName("user_longitude")
                    .HasMaxLength(256)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(64);

                entity.Property(e => e.UserPackage)
                    .HasColumnName("user_package")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password")
                    .HasMaxLength(64);

                entity.Property(e => e.UserPhone)
                    .HasColumnName("user_phone")
                    .HasMaxLength(64);

                entity.Property(e => e.UserPhoneVerificationCode)
                    .HasColumnName("user_phone_verification_code")
                    .HasMaxLength(64);

                entity.Property(e => e.UserPhoneVerified)
                    .IsRequired()
                    .HasColumnName("user_phone_verified")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserPicture)
                    .HasColumnName("user_picture")
                    .HasMaxLength(255);

                entity.Property(e => e.UserPictureId)
                    .HasColumnName("user_picture_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserPinnedPost)
                    .HasColumnName("user_pinned_post")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserPoints).HasColumnName("user_points");

                entity.Property(e => e.UserPrivacyBasic)
                    .IsRequired()
                    .HasColumnName("user_privacy_basic")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyBirthdate)
                    .IsRequired()
                    .HasColumnName("user_privacy_birthdate")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyEducation)
                    .IsRequired()
                    .HasColumnName("user_privacy_education")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyEvents)
                    .IsRequired()
                    .HasColumnName("user_privacy_events")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyFriends)
                    .IsRequired()
                    .HasColumnName("user_privacy_friends")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyGifts)
                    .IsRequired()
                    .HasColumnName("user_privacy_gifts")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyGroups)
                    .IsRequired()
                    .HasColumnName("user_privacy_groups")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyLocation)
                    .IsRequired()
                    .HasColumnName("user_privacy_location")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyNewsletter)
                    .IsRequired()
                    .HasColumnName("user_privacy_newsletter")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserPrivacyOther)
                    .IsRequired()
                    .HasColumnName("user_privacy_other")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyPages)
                    .IsRequired()
                    .HasColumnName("user_privacy_pages")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyPhotos)
                    .IsRequired()
                    .HasColumnName("user_privacy_photos")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyPoke)
                    .IsRequired()
                    .HasColumnName("user_privacy_poke")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyRelationship)
                    .IsRequired()
                    .HasColumnName("user_privacy_relationship")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserPrivacyWall)
                    .IsRequired()
                    .HasColumnName("user_privacy_wall")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'friends'");

                entity.Property(e => e.UserPrivacyWork)
                    .IsRequired()
                    .HasColumnName("user_privacy_work")
                    .HasColumnType("enum('me','friends','public')")
                    .HasDefaultValueSql("'public'");

                entity.Property(e => e.UserProfileBackground)
                    .HasColumnName("user_profile_background")
                    .HasMaxLength(256);

                entity.Property(e => e.UserReferrerId).HasColumnName("user_referrer_id");

                entity.Property(e => e.UserRelationship)
                    .HasColumnName("user_relationship")
                    .HasMaxLength(256);

                entity.Property(e => e.UserResetKey)
                    .HasColumnName("user_reset_key")
                    .HasMaxLength(64);

                entity.Property(e => e.UserReseted)
                    .IsRequired()
                    .HasColumnName("user_reseted")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserSocialFacebook)
                    .HasColumnName("user_social_facebook")
                    .HasMaxLength(256);

                entity.Property(e => e.UserSocialInstagram)
                    .HasColumnName("user_social_instagram")
                    .HasMaxLength(256);

                entity.Property(e => e.UserSocialLinkedin)
                    .HasColumnName("user_social_linkedin")
                    .HasMaxLength(256);

                entity.Property(e => e.UserSocialTwitter)
                    .HasColumnName("user_social_twitter")
                    .HasMaxLength(256);

                entity.Property(e => e.UserSocialVkontakte)
                    .HasColumnName("user_social_vkontakte")
                    .HasMaxLength(256);

                entity.Property(e => e.UserSocialYoutube)
                    .HasColumnName("user_social_youtube")
                    .HasMaxLength(256);

                entity.Property(e => e.UserStarted)
                    .IsRequired()
                    .HasColumnName("user_started")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserSubscribed)
                    .IsRequired()
                    .HasColumnName("user_subscribed")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTwoFactorEnabled)
                    .IsRequired()
                    .HasColumnName("user_two_factor_enabled")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserTwoFactorGsecret)
                    .HasColumnName("user_two_factor_gsecret")
                    .HasMaxLength(64);

                entity.Property(e => e.UserTwoFactorKey)
                    .HasColumnName("user_two_factor_key")
                    .HasMaxLength(64);

                entity.Property(e => e.UserTwoFactorType)
                    .HasColumnName("user_two_factor_type")
                    .HasColumnType("enum('email','sms','google')");

                entity.Property(e => e.UserVerified)
                    .IsRequired()
                    .HasColumnName("user_verified")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserWalletBalance)
                    .IsRequired()
                    .HasColumnName("user_wallet_balance")
                    .HasMaxLength(64)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UserWebsite)
                    .HasColumnName("user_website")
                    .HasMaxLength(256);

                entity.Property(e => e.UserWorkPlace)
                    .HasColumnName("user_work_place")
                    .HasMaxLength(256);

                entity.Property(e => e.UserWorkTitle)
                    .HasColumnName("user_work_title")
                    .HasMaxLength(256);

                entity.Property(e => e.UserWorkUrl)
                    .HasColumnName("user_work_url")
                    .HasMaxLength(256);

                entity.Property(e => e.VkontakteConnected)
                    .IsRequired()
                    .HasColumnName("vkontakte_connected")
                    .HasColumnType("enum('0','1')")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VkontakteId)
                    .HasColumnName("vkontakte_id")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<UsersBlocks>(entity =>
            {
                entity.ToTable("users_blocks");

                entity.HasIndex(e => new { e.UserId, e.BlockedId })
                    .HasName("user_id_blocked_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.BlockedId)
                    .HasColumnName("blocked_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<UsersGifts>(entity =>
            {
                entity.ToTable("users_gifts");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.FromUserId)
                    .HasColumnName("from_user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.GiftId)
                    .HasColumnName("gift_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ToUserId)
                    .HasColumnName("to_user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<UsersInvitations>(entity =>
            {
                entity.ToTable("users_invitations");

                entity.HasIndex(e => new { e.UserId, e.Email })
                    .HasName("user_id_email")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(64);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<UsersPokes>(entity =>
            {
                entity.ToTable("users_pokes");

                entity.HasIndex(e => new { e.UserId, e.PokedId })
                    .HasName("user_id_blocked_id")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.PokedId)
                    .HasColumnName("poked_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<UsersSearches>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PRIMARY");

                entity.ToTable("users_searches");

                entity.HasIndex(e => new { e.NodeId, e.NodeType })
                    .HasName("node_id_node_type")
                    .IsUnique();

                entity.Property(e => e.LogId)
                    .HasColumnName("log_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnName("node_type")
                    .HasMaxLength(32);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");
            });

            modelBuilder.Entity<UsersSessions>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("users_sessions");

                entity.HasIndex(e => e.SessionToken)
                    .HasName("session_token")
                    .IsUnique();

                entity.HasIndex(e => e.UserIp)
                    .HasName("user_ip");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.SessionToken)
                    .IsRequired()
                    .HasColumnName("session_token")
                    .HasMaxLength(64);

                entity.Property(e => e.UserBrowser)
                    .IsRequired()
                    .HasColumnName("user_browser")
                    .HasMaxLength(64);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UserIp)
                    .IsRequired()
                    .HasColumnName("user_ip")
                    .HasMaxLength(64);

                entity.Property(e => e.UserOs)
                    .IsRequired()
                    .HasColumnName("user_os")
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<VerificationRequests>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PRIMARY");

                entity.ToTable("verification_requests");

                entity.HasIndex(e => new { e.NodeId, e.NodeType })
                    .HasName("node_id_node_type")
                    .IsUnique();

                entity.Property(e => e.RequestId)
                    .HasColumnName("request_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.NodeId)
                    .HasColumnName("node_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasColumnName("node_type")
                    .HasMaxLength(32);

                entity.Property(e => e.Passport)
                    .HasColumnName("passport")
                    .HasMaxLength(256);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(256);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Widgets>(entity =>
            {
                entity.HasKey(e => e.WidgetId)
                    .HasName("PRIMARY");

                entity.ToTable("widgets");

                entity.Property(e => e.WidgetId)
                    .HasColumnName("widget_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Place)
                    .IsRequired()
                    .HasColumnName("place")
                    .HasMaxLength(32);

                entity.Property(e => e.PlaceOrder)
                    .HasColumnName("place_order")
                    .HasColumnType("int unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
