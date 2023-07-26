using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BHI.SalesArchitect.Model.DB;

public partial class SalesArchitectContext : DbContext
{
    public SalesArchitectContext()
    {
    }

    public SalesArchitectContext(DbContextOptions<SalesArchitectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActivityState> ActivityStates { get; set; }

    public virtual DbSet<ApiDataImportLog> ApiDataImportLogs { get; set; }

    public virtual DbSet<ApiLog> ApiLogs { get; set; }

    public virtual DbSet<AssetType> AssetTypes { get; set; }

    public virtual DbSet<BuilderBrand> BuilderBrands { get; set; }

    public virtual DbSet<BuilderBrandListing> BuilderBrandListings { get; set; }

    public virtual DbSet<Community> Communities { get; set; }

    public virtual DbSet<CommunityAsset> CommunityAssets { get; set; }

    public virtual DbSet<CommunityBuilderBrand> CommunityBuilderBrands { get; set; }

    public virtual DbSet<CommunityConfiguration> CommunityConfigurations { get; set; }

    public virtual DbSet<CommunityImage> CommunityImages { get; set; }

    public virtual DbSet<CommunityNearByPoi> CommunityNearByPois { get; set; }

    public virtual DbSet<CommunityPointOfInterest> CommunityPointOfInterests { get; set; }

    public virtual DbSet<CommunitySite> CommunitySites { get; set; }

    public virtual DbSet<CommunitySiteGeoJson> CommunitySiteGeoJsons { get; set; }

    public virtual DbSet<CommunityUser> CommunityUsers { get; set; }

    public virtual DbSet<CommunityVideo> CommunityVideos { get; set; }

    public virtual DbSet<CommunityVideoTour> CommunityVideoTours { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }

    public virtual DbSet<Consumer> Consumers { get; set; }

    public virtual DbSet<ConsumerAppConfigurable> ConsumerAppConfigurables { get; set; }

    public virtual DbSet<ConsumerAppResource> ConsumerAppResources { get; set; }

    public virtual DbSet<ConsumerAppVersion> ConsumerAppVersions { get; set; }

    public virtual DbSet<ConsumerDevice> ConsumerDevices { get; set; }

    public virtual DbSet<ConsumerProspect> ConsumerProspects { get; set; }

    public virtual DbSet<ConsumerSessionEventLog> ConsumerSessionEventLogs { get; set; }

    public virtual DbSet<CustomizedContent> CustomizedContents { get; set; }

    public virtual DbSet<CustomizedContentType> CustomizedContentTypes { get; set; }

    public virtual DbSet<CustomizedLocation> CustomizedLocations { get; set; }

    public virtual DbSet<DataImportTime> DataImportTimes { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<FeedbackCategory> FeedbackCategories { get; set; }

    public virtual DbSet<GuestConsumerLog> GuestConsumerLogs { get; set; }

    public virtual DbSet<HiddenLotConfiguration> HiddenLotConfigurations { get; set; }

    public virtual DbSet<HiddenSiteBlock> HiddenSiteBlocks { get; set; }

    public virtual DbSet<InteractiveMedium> InteractiveMedia { get; set; }

    public virtual DbSet<Listing> Listings { get; set; }

    public virtual DbSet<ListingAmenity> ListingAmenities { get; set; }

    public virtual DbSet<ListingImage> ListingImages { get; set; }

    public virtual DbSet<ListingInteractiveMedium> ListingInteractiveMedia { get; set; }

    public virtual DbSet<Lot> Lots { get; set; }

    public virtual DbSet<LotConfiguration> LotConfigurations { get; set; }

    public virtual DbSet<LotListing> LotListings { get; set; }

    public virtual DbSet<LotReservationLog> LotReservationLogs { get; set; }

    public virtual DbSet<LotState> LotStates { get; set; }

    public virtual DbSet<Market> Markets { get; set; }

    public virtual DbSet<MasterPlan> MasterPlans { get; set; }

    public virtual DbSet<OneTimePassword> OneTimePasswords { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnerBuilderBrand> PartnerBuilderBrands { get; set; }

    public virtual DbSet<PartnerCommunity> PartnerCommunities { get; set; }

    public virtual DbSet<PartnerListing> PartnerListings { get; set; }

    public virtual DbSet<PartnerMasterPlan> PartnerMasterPlans { get; set; }

    public virtual DbSet<PartnerSetting> PartnerSettings { get; set; }

    public virtual DbSet<PointOfInterest> PointOfInterests { get; set; }

    public virtual DbSet<Prospect> Prospects { get; set; }

    public virtual DbSet<ProspectAsset> ProspectAssets { get; set; }

    public virtual DbSet<ProspectCommunity> ProspectCommunities { get; set; }

    public virtual DbSet<ProspectCommunityVisitDetail> ProspectCommunityVisitDetails { get; set; }

    public virtual DbSet<ProspectConfiguration> ProspectConfigurations { get; set; }

    public virtual DbSet<ProspectLead> ProspectLeads { get; set; }

    public virtual DbSet<ProspectListing> ProspectListings { get; set; }

    public virtual DbSet<ProspectLot> ProspectLots { get; set; }

    public virtual DbSet<ProspectReferralSource> ProspectReferralSources { get; set; }

    public virtual DbSet<ReferralSource> ReferralSources { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleAction> RoleActions { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<SyncAction> SyncActions { get; set; }

    public virtual DbSet<SyncActionType> SyncActionTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserSessionEventLog> UserSessionEventLogs { get; set; }

    public virtual DbSet<UupuserLot> UupuserLots { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=172.17.1.100;Database=SalesArchitect;uid=sa;pwd=Master@123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Action>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<ActivityState>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_ActivityStates").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApiDataImportLog>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SyncEndTime).HasColumnType("datetime");
            entity.Property(e => e.SyncStartTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ApiLog>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Api)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("API");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LogId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<AssetType>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_AssetTypes").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BuilderBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Builders");

            entity.HasIndex(e => e.Bdxid, "IX_BuilderBrands").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bdxid).HasColumnName("BDXID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<BuilderBrandListing>(entity =>
        {
            entity.HasIndex(e => new { e.PartnerId, e.BuilderBrandId, e.CommunityId, e.ListingId }, "IX_BuilderListings").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BuilderBrandId).HasColumnName("BuilderBrandID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.DateDeleted).HasColumnType("date");
            entity.Property(e => e.DeletedBy).HasMaxLength(200);
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.BuilderBrand).WithMany(p => p.BuilderBrandListings)
                .HasForeignKey(d => d.BuilderBrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BuilderBrandListings_BuilderBrands");

            entity.HasOne(d => d.Community).WithMany(p => p.BuilderBrandListings)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BuilderBrandListings_Communities");

            entity.HasOne(d => d.Listing).WithMany(p => p.BuilderBrandListings)
                .HasForeignKey(d => d.ListingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BuilderBrandListings_Listings");

            entity.HasOne(d => d.Partner).WithMany(p => p.BuilderBrandListings)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BuilderBrandListings_Partners");
        });

        modelBuilder.Entity<Community>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityStateId).HasColumnName("ActivityStateID");
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.Bdxid).HasColumnName("BDXID");
            entity.Property(e => e.BrandLogoMedium)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.BrandLogoSmall)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CustomDescription)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.Dwstatus).HasColumnName("DWStatus");
            entity.Property(e => e.EnvisionDesignCenter)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.GeospatialZoomLevel).HasDefaultValueSql("((17))");
            entity.Property(e => e.Hours)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.IsOverwriteName).HasDefaultValueSql("((0))");
            entity.Property(e => e.Ispname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ISPName");
            entity.Property(e => e.LastUpdated).HasColumnType("datetime");
            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.MarketId).HasColumnName("MarketID");
            entity.Property(e => e.MasterPlanId).HasColumnName("MasterPlanID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Overview).HasMaxLength(2000);
            entity.Property(e => e.Phone)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PreferredCommunityAssetId).HasColumnName("PreferredCommunityAssetID");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.VendorReference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(11)
                .IsUnicode(false);

            entity.HasOne(d => d.ActivityState).WithMany(p => p.Communities)
                .HasForeignKey(d => d.ActivityStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Communities_ActivityStates");

            entity.HasOne(d => d.Market).WithMany(p => p.Communities)
                .HasForeignKey(d => d.MarketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Communities_Markets");

            entity.HasOne(d => d.MasterPlan).WithMany(p => p.Communities)
                .HasForeignKey(d => d.MasterPlanId)
                .HasConstraintName("FK_Communities_MasterPlans");
        });

        modelBuilder.Entity<CommunityAsset>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.Description).HasMaxLength(2000);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.AssetType).WithMany()
                .HasForeignKey(d => d.AssetTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityAssets_AssetTypes");

            entity.HasOne(d => d.Community).WithMany()
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityAssets_Communities");

            entity.HasOne(d => d.Partner).WithMany()
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityAssets_Partners");
        });

        modelBuilder.Entity<CommunityBuilderBrand>(entity =>
        {
            entity.HasIndex(e => new { e.PartnerId, e.CommunityId, e.BuilderBrandId }, "IX_CommunityBuilderBrands").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BuilderBrandId).HasColumnName("BuilderBrandID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.BuilderBrand).WithMany(p => p.CommunityBuilderBrands)
                .HasForeignKey(d => d.BuilderBrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityBuilderBrands_BuilderBrands");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunityBuilderBrands)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityBuilderBrands_Communities");

            entity.HasOne(d => d.Partner).WithMany(p => p.CommunityBuilderBrands)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityBuilderBrands_Partners");
        });

        modelBuilder.Entity<CommunityConfiguration>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityStateId).HasColumnName("ActivityStateID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.ConfigurationId).HasColumnName("ConfigurationID");
            entity.Property(e => e.HoldAlotButtonText)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HoldALotButtonText");
            entity.Property(e => e.HoldAlotStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("HoldALotStatus");
            entity.Property(e => e.IncludeDwstatus).HasColumnName("IncludeDWStatus");

            entity.HasOne(d => d.ActivityState).WithMany(p => p.CommunityConfigurations)
                .HasForeignKey(d => d.ActivityStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityConfigurations_ActivityStateID");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunityConfigurations)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityConfigurations_Communities");

            entity.HasOne(d => d.Configuration).WithMany(p => p.CommunityConfigurations)
                .HasForeignKey(d => d.ConfigurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityConfigurations_Configurations");
        });

        modelBuilder.Entity<CommunityImage>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunityImages)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityImages_Communities");

            entity.HasOne(d => d.Partner).WithMany(p => p.CommunityImages)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityImages_Partners");
        });

        modelBuilder.Entity<CommunityNearByPoi>(entity =>
        {
            entity.ToTable("CommunityNearByPOI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PointOfInterestId).HasColumnName("PointOfInterestID");
            entity.Property(e => e.State).HasMaxLength(50);

            entity.HasOne(d => d.Community).WithMany(p => p.CommunityNearByPois)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityNearByPOI_Communities");

            entity.HasOne(d => d.PointOfInterest).WithMany(p => p.CommunityNearByPois)
                .HasForeignKey(d => d.PointOfInterestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityNearByPOI_PointOfInterests");
        });

        modelBuilder.Entity<CommunityPointOfInterest>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.PointOfInterestId).HasColumnName("PointOfInterestID");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunityPointOfInterests)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityPointOfInterests_Communities");

            entity.HasOne(d => d.PointOfInterest).WithMany(p => p.CommunityPointOfInterests)
                .HasForeignKey(d => d.PointOfInterestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityPointOfInterests_PointOfInterests");
        });

        modelBuilder.Entity<CommunitySite>(entity =>
        {
            entity.HasIndex(e => new { e.CommunityId, e.SiteId }, "IX_CommunitySites").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunitySites)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunitySites_Communities");

            entity.HasOne(d => d.Site).WithMany(p => p.CommunitySites)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunitySites_Sites");
        });

        modelBuilder.Entity<CommunitySiteGeoJson>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityStateId).HasColumnName("ActivityStateID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GeoJsonfileName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GeoJSONFileName");
            entity.Property(e => e.GeoJsonfilePath)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("GeoJSONFilePath");
            entity.Property(e => e.GeoJsontype).HasColumnName("GeoJSONType");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Version)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Community).WithMany(p => p.CommunitySiteGeoJsons)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunitySiteGeoJsons_Communities");

            entity.HasOne(d => d.Site).WithMany(p => p.CommunitySiteGeoJsons)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunitySiteGeoJsons_Sites");
        });

        modelBuilder.Entity<CommunityUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CommunityUsers_1");

            entity.HasIndex(e => new { e.CommunityId, e.UserId }, "IX_CommunityUsers").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityStateId).HasColumnName("ActivityStateID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.ActivityState).WithMany(p => p.CommunityUsers)
                .HasForeignKey(d => d.ActivityStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityUsers_ActivityStates");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunityUsers)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityUsers_Communities");

            entity.HasOne(d => d.User).WithMany(p => p.CommunityUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityUsers_Users");
        });

        modelBuilder.Entity<CommunityVideo>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ThumbnailUrl)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("ThumbnailURL");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunityVideos)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityVideos_Communities");

            entity.HasOne(d => d.Partner).WithMany(p => p.CommunityVideos)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityVideos_CommunityVideos");
        });

        modelBuilder.Entity<CommunityVideoTour>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunityVideoTours)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityVideoTours_Communities");

            entity.HasOne(d => d.Partner).WithMany(p => p.CommunityVideoTours)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CommunityVideoTours_Partners");
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.HasIndex(e => new { e.Code, e.PartnerId }, "IX_Configurations").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.Configurations)
                .HasForeignKey(d => d.AssetTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Configurations_AssetTypes");

            entity.HasOne(d => d.Partner).WithMany(p => p.Configurations)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK_Configurations_Partners");
        });

        modelBuilder.Entity<Consumer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Consumer__3214EC272FCF1A8A");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FacebookEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FacebookId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FacebookID");
            entity.Property(e => e.GoogleEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GoogleId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GoogleID");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Password).HasMaxLength(200);

            entity.HasOne(d => d.Partner).WithMany(p => p.Consumers)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK_Consumers_Partners");
        });

        modelBuilder.Entity<ConsumerAppConfigurable>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BuilderBrandId).HasColumnName("BuilderBrandID");

            entity.HasOne(d => d.BuilderBrand).WithMany(p => p.ConsumerAppConfigurables)
                .HasForeignKey(d => d.BuilderBrandId)
                .HasConstraintName("FK_BuilderBrands_ConsumerAppConfigurables");

            entity.HasOne(d => d.Partner).WithMany(p => p.ConsumerAppConfigurables)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsumerAppConfigurables_Communities");
        });

        modelBuilder.Entity<ConsumerAppResource>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BuilderBrandId).HasColumnName("BuilderBrandID");
            entity.Property(e => e.Title).HasMaxLength(1000);
            entity.Property(e => e.Url)
                .HasMaxLength(1000)
                .HasColumnName("URL");

            entity.HasOne(d => d.BuilderBrand).WithMany(p => p.ConsumerAppResources)
                .HasForeignKey(d => d.BuilderBrandId)
                .HasConstraintName("FK_BuilderBrands_ConsumerAppResources");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_ConsumerAppResources_ConsumerAppResources");

            entity.HasOne(d => d.Partner).WithMany(p => p.ConsumerAppResources)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK_ConsumerAppResources_Partners");
        });

        modelBuilder.Entity<ConsumerAppVersion>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConsumerDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Consumer__3214EC2737703C52");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.DeviceToken)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConsumerProspect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Consumer__3214EC27339FAB6E");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.ProspectId).HasColumnName("ProspectID");
        });

        modelBuilder.Entity<ConsumerSessionEventLog>(entity =>
        {
            entity.ToTable("ConsumerSessionEventLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.LogoutTime).HasColumnType("datetime");

            entity.HasOne(d => d.Consumer).WithMany(p => p.ConsumerSessionEventLogs)
                .HasForeignKey(d => d.ConsumerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsumerSessionEventLog_Consumers");
        });

        modelBuilder.Entity<CustomizedContent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomizedContent");

            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.CustomizedContentTypeId).HasColumnName("CustomizedContentTypeID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");

            entity.HasOne(d => d.CustomizedContentType).WithMany()
                .HasForeignKey(d => d.CustomizedContentTypeId)
                .HasConstraintName("FK__Customize__Custo__01BE3717");
        });

        modelBuilder.Entity<CustomizedContentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customiz__3214EC27DE1A3185");

            entity.ToTable("CustomizedContentType");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContentType).HasMaxLength(200);
            entity.Property(e => e.CustomizedLocationId).HasColumnName("CustomizedLocationID");

            entity.HasOne(d => d.CustomizedLocation).WithMany(p => p.CustomizedContentTypes)
                .HasForeignKey(d => d.CustomizedLocationId)
                .HasConstraintName("FK__Customize__Custo__7A1D154F");
        });

        modelBuilder.Entity<CustomizedLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customiz__3214EC27C4073D34");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(400);
            entity.Property(e => e.LocationCode).HasMaxLength(200);
        });

        modelBuilder.Entity<DataImportTime>(entity =>
        {
            entity.HasIndex(e => new { e.PartnerId, e.FileExportTime }, "IX_DataImportTimes").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FileExportTime).HasColumnType("datetime");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.TimeProcessed).HasColumnType("datetime");

            entity.HasOne(d => d.Partner).WithMany(p => p.DataImportTimes)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DataImportTimes_Partners");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.FeedbackCategoryId).HasColumnName("FeedbackCategoryID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.Consumer).WithMany()
                .HasForeignKey(d => d.ConsumerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Feedbacks__Consu__5B78929E");

            entity.HasOne(d => d.Partner).WithMany()
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK__Feedbacks__Partn__5A846E65");
        });

        modelBuilder.Entity<FeedbackCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Feedback__3214EC27896C8C27");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GuestConsumerLog>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Consumer).WithMany(p => p.GuestConsumerLogs)
                .HasForeignKey(d => d.ConsumerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GuestConsumerLogs_Consumers");
        });

        modelBuilder.Entity<HiddenLotConfiguration>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ConfigName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LotInternalReference)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HiddenSiteBlock>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<InteractiveMedium>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Url)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Community).WithMany(p => p.InteractiveMedia)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InteractiveMedia_Communities");

            entity.HasOne(d => d.Partner).WithMany(p => p.InteractiveMedia)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InteractiveMedia_Partners");
        });

        modelBuilder.Entity<Listing>(entity =>
        {
            entity.HasIndex(e => new { e.Bdxid, e.Type }, "IX_Listings").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.BasePrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Baths).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.Bdxid).HasColumnName("BDXID");
            entity.Property(e => e.BuilderListingUrl)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("BuilderListingURL");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.EnvisionDesignCenter)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Garage).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.MasterBedLocation)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PlanType)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VendorReference)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VirtualTour)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ListingAmenity>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amenity)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.Listing).WithMany(p => p.ListingAmenities)
                .HasForeignKey(d => d.ListingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListingAmenities_Listings");

            entity.HasOne(d => d.Partner).WithMany(p => p.ListingAmenities)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListingAmenities_Partners");
        });

        modelBuilder.Entity<ListingImage>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.ProcessDate).HasColumnType("datetime");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Listing).WithMany(p => p.ListingImages)
                .HasForeignKey(d => d.ListingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListingImages_Listings");

            entity.HasOne(d => d.Partner).WithMany(p => p.ListingImages)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListingImages_Partners");
        });

        modelBuilder.Entity<ListingInteractiveMedium>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Url)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.Listing).WithMany(p => p.ListingInteractiveMedia)
                .HasForeignKey(d => d.ListingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListingInteractiveMedia_Listings");

            entity.HasOne(d => d.Partner).WithMany(p => p.ListingInteractiveMedia)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListingInteractiveMedia_Partners");
        });

        modelBuilder.Entity<Lot>(entity =>
        {
            entity.HasIndex(e => new { e.SiteId, e.InternalReference }, "IX_Lots").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.Block)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ButtonText)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactLink)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.Elevation)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ExternalReference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImagePath)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.InternalReference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LotDescription)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.LotStateId).HasColumnName("LotStateID");
            entity.Property(e => e.Phase)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ReservationFee).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SiteId).HasColumnName("SiteID");
            entity.Property(e => e.Size)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Swing)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VideoUrl)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("VideoURL");

            entity.HasOne(d => d.LotState).WithMany(p => p.Lots)
                .HasForeignKey(d => d.LotStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lots_LotStates");

            entity.HasOne(d => d.Site).WithMany(p => p.Lots)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lots_Sites");
        });

        modelBuilder.Entity<LotConfiguration>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ConfigType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LotListing>(entity =>
        {
            entity.HasIndex(e => new { e.LotId, e.ListingId }, "IX_LotListings").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.ListingImagesId).HasColumnName("ListingImagesID");
            entity.Property(e => e.LotId).HasColumnName("LotID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Listing).WithMany(p => p.LotListings)
                .HasForeignKey(d => d.ListingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LotListings_Listings");

            entity.HasOne(d => d.Lot).WithMany(p => p.LotListings)
                .HasForeignKey(d => d.LotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LotListings_Lots");
        });

        modelBuilder.Entity<LotReservationLog>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LotId).HasColumnName("LotID");
            entity.Property(e => e.NewLotStateId).HasColumnName("NewLotStateID");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PaymentID");
            entity.Property(e => e.PreviousLotStateId).HasColumnName("PreviousLotStateID");
            entity.Property(e => e.ReservationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<LotState>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.Partner).WithMany(p => p.LotStates)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK_LotStates_Partners");
        });

        modelBuilder.Entity<Market>(entity =>
        {
            entity.HasIndex(e => e.Bdxid, "IX_Markets").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bdxid).HasColumnName("BDXID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<MasterPlan>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GeospatialMapImage).HasMaxLength(1000);
            entity.Property(e => e.GeospatialPdfImage).HasMaxLength(1000);
            entity.Property(e => e.IsMasterGeoSvg)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsMasterGeoSVG");
            entity.Property(e => e.MapImage).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PdfImage)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OneTimePassword>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConsumerId).HasColumnName("ConsumerID");
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Otp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OTP");

            entity.HasOne(d => d.Consumer).WithMany(p => p.OneTimePasswords)
                .HasForeignKey(d => d.ConsumerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OneTimePasswords_Consumers");
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Partners_1");

            entity.HasIndex(e => e.Id, "IX_Partners_1").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bdxid).HasColumnName("BDXID");
            entity.Property(e => e.DataKey)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Ispname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ISPName");
            entity.Property(e => e.LeadPostingPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MappedPartnerId).HasColumnName("MappedPartnerID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.UploadDataMappingConfiguration)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PartnerBuilderBrand>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BuilderBrandId).HasColumnName("BuilderBrandID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.BuilderBrand).WithMany(p => p.PartnerBuilderBrands)
                .HasForeignKey(d => d.BuilderBrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartnerBuilderBrands_BuilderBrands");

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerBuilderBrands)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartnerBuilderBrands_Partners");
        });

        modelBuilder.Entity<PartnerCommunity>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BuilderWebsiteQrcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BuilderWebsiteQRCode");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.DateDeleted).HasColumnType("date");
            entity.Property(e => e.DeletedBy).HasMaxLength(200);
            entity.Property(e => e.Nhsqrcode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NHSQRCode");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.Community).WithMany(p => p.PartnerCommunities)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartnerCommunities_Communities");

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerCommunities)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartnerCommunities_Partners");
        });

        modelBuilder.Entity<PartnerListing>(entity =>
        {
            entity.HasIndex(e => new { e.PartnerId, e.ListingId }, "IX_PartnerListings").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.Listing).WithMany(p => p.PartnerListings)
                .HasForeignKey(d => d.ListingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartnerListings_Listings");

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerListings)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartnerListings_Partners");
        });

        modelBuilder.Entity<PartnerMasterPlan>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MasterPlanId).HasColumnName("MasterPlanID");
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

            entity.HasOne(d => d.MasterPlan).WithMany(p => p.PartnerMasterPlans)
                .HasForeignKey(d => d.MasterPlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartnerMasterPlans_MasterPlans");

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerMasterPlans)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PartnerMasterPlans_Partners");
        });

        modelBuilder.Entity<PartnerSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PartnerS__3214EC273E1D39E1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Key).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Value).HasMaxLength(100);

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnerSettings)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK_Partner_Settings_Partners");
        });

        modelBuilder.Entity<PointOfInterest>(entity =>
        {
            entity.HasIndex(e => e.Name, "IX_PointOfInterests").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Prospect>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccessKey)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.CardNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.HomePhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProspectAsset>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.ProspectId).HasColumnName("ProspectID");

            entity.HasOne(d => d.AssetType).WithMany(p => p.ProspectAssets)
                .HasForeignKey(d => d.AssetTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectAssets_AssetTypes");

            entity.HasOne(d => d.Listing).WithMany(p => p.ProspectAssets)
                .HasForeignKey(d => d.ListingId)
                .HasConstraintName("FK_ProspectAssets_Listings");

            entity.HasOne(d => d.Prospect).WithMany(p => p.ProspectAssets)
                .HasForeignKey(d => d.ProspectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectAssets_Prospects");
        });

        modelBuilder.Entity<ProspectCommunity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PropectCommunities");

            entity.HasIndex(e => new { e.ProspectId, e.CommunityId }, "IX_PropectCommunities").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityStateId)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ActivityStateID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.ConsumerPrivateNotes)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.LastDateOfVisit).HasColumnType("datetime");
            entity.Property(e => e.PrivateNotes)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.ProspectId).HasColumnName("ProspectID");
            entity.Property(e => e.SharedNotes)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.ActivityState).WithMany(p => p.ProspectCommunities)
                .HasForeignKey(d => d.ActivityStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectCommunities_ActivityStates");

            entity.HasOne(d => d.Community).WithMany(p => p.ProspectCommunities)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PropectCommunities_Communities");

            entity.HasOne(d => d.Prospect).WithMany(p => p.ProspectCommunities)
                .HasForeignKey(d => d.ProspectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PropectCommunities_Prospects");

            entity.HasOne(d => d.User).WithMany(p => p.ProspectCommunities)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_PropectCommunities_Users");
        });

        modelBuilder.Entity<ProspectCommunityVisitDetail>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.VisitDate).HasColumnType("datetime");

            entity.HasOne(d => d.ProspectCommunity).WithMany(p => p.ProspectCommunityVisitDetails)
                .HasForeignKey(d => d.ProspectCommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectCommunityVisitDetails_ProspectCommunities");
        });

        modelBuilder.Entity<ProspectConfiguration>(entity =>
        {
            entity.ToTable("ProspectConfiguration");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddModelHomesBanner).HasDefaultValueSql("((0))");
            entity.Property(e => e.BuilderDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BuilderEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BuilderPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DisplayLotList).HasDefaultValueSql("((0))");
            entity.Property(e => e.DisplaySpecAddress).HasDefaultValueSql("((0))");
            entity.Property(e => e.GoogleApikey)
                .HasMaxLength(500)
                .HasColumnName("GoogleAPIKey");
            entity.Property(e => e.GoogleClientId).HasMaxLength(500);
            entity.Property(e => e.HoldAlot)
                .HasDefaultValueSql("((0))")
                .HasColumnName("HoldALot");
            entity.Property(e => e.HoldAlotButtonText)
                .HasMaxLength(100)
                .HasColumnName("HoldALotButtonText");
            entity.Property(e => e.HoldAlotDisclaimer)
                .HasMaxLength(2000)
                .HasColumnName("HoldALotDisclaimer");
            entity.Property(e => e.HoldAlotHeaderText)
                .HasMaxLength(200)
                .HasColumnName("HoldALotHeaderText");
            entity.Property(e => e.IsDreamweaver).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsIsp).HasColumnName("IsISP");
            entity.Property(e => e.IsSecured).HasDefaultValueSql("((0))");
            entity.Property(e => e.IspPartnerType).HasDefaultValueSql("((1))");
            entity.Property(e => e.LotOutlineColor).HasMaxLength(50);
            entity.Property(e => e.LotPremiumOptionalDisplay).HasDefaultValueSql("((0))");
            entity.Property(e => e.NhtbuilderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NHTBuilderNumber");
            entity.Property(e => e.OpenSpecDefault).HasDefaultValueSql("((0))");
            entity.Property(e => e.Pdfdisclaimer)
                .HasMaxLength(2000)
                .HasColumnName("PDFDisclaimer");
            entity.Property(e => e.PreviewIspplugin)
                .HasDefaultValueSql("((0))")
                .HasColumnName("PreviewISPPlugin");
            entity.Property(e => e.ReplaceKeyIcon).HasDefaultValueSql("((0))");
            entity.Property(e => e.ShowAllPlans)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ShowAllSpecs)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.ShowExteriorColorScheme).HasDefaultValueSql("((0))");
            entity.Property(e => e.ShowHomesiteFilter)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.SuppressBottomCommunityName).HasDefaultValueSql("((0))");
            entity.Property(e => e.SuppressBuilderLogo).HasDefaultValueSql("((0))");
            entity.Property(e => e.SuppressTopCommunityName).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.Partner).WithMany(p => p.ProspectConfigurations)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectConfiguration_Partners");

            entity.HasOne(d => d.User).WithMany(p => p.ProspectConfigurations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectConfiguration_Users");
        });

        modelBuilder.Entity<ProspectLead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProspectLead");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionOwner)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BuilderId).HasColumnName("BuilderID");
            entity.Property(e => e.Comments).HasMaxLength(1000);
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.IsApilead).HasColumnName("IsAPILead");
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.LeadAction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadPostingPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeadType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProspectId).HasColumnName("ProspectID");
            entity.Property(e => e.Response)
                .HasMaxLength(3000)
                .IsUnicode(false);
            entity.Property(e => e.SubmitDate).HasColumnType("datetime");
            entity.Property(e => e.ZipCode)
                .HasMaxLength(11)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProspectListing>(entity =>
        {
            entity.HasIndex(e => new { e.ListingId, e.ProspectId }, "IX_ProspectListings").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ListingId).HasColumnName("ListingID");
            entity.Property(e => e.ProspectId).HasColumnName("ProspectID");

            entity.HasOne(d => d.Listing).WithMany(p => p.ProspectListings)
                .HasForeignKey(d => d.ListingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectListings_Listings");

            entity.HasOne(d => d.Prospect).WithMany(p => p.ProspectListings)
                .HasForeignKey(d => d.ProspectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectListings_Prospects");
        });

        modelBuilder.Entity<ProspectLot>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CommunityId).HasColumnName("CommunityID");
            entity.Property(e => e.LotId).HasColumnName("LotID");
            entity.Property(e => e.ProspectId).HasColumnName("ProspectID");

            entity.HasOne(d => d.Community).WithMany(p => p.ProspectLots)
                .HasForeignKey(d => d.CommunityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectLots_Communities");

            entity.HasOne(d => d.Lot).WithMany(p => p.ProspectLots)
                .HasForeignKey(d => d.LotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectLots_Lots");

            entity.HasOne(d => d.Prospect).WithMany(p => p.ProspectLots)
                .HasForeignKey(d => d.ProspectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectLots_ProspectLots");
        });

        modelBuilder.Entity<ProspectReferralSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ProspectReferrals");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CustomValue)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Prospect).WithMany(p => p.ProspectReferralSources)
                .HasForeignKey(d => d.ProspectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectReferralSources_Prospects");

            entity.HasOne(d => d.ReferralSource).WithMany(p => p.ProspectReferralSources)
                .HasForeignKey(d => d.ReferralSourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProspectReferralSources_ReferralSources");
        });

        modelBuilder.Entity<ReferralSource>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PlaceholderText)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_Roles").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoleAction>(entity =>
        {
            entity.HasIndex(e => new { e.RoleId, e.ActionId }, "IX_RoleActions").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionId).HasColumnName("ActionID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.HasOne(d => d.Action).WithMany(p => p.RoleActions)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleActions_Actions");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleActions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RoleActions_Roles");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GeospatialPluginImage).HasMaxLength(1000);
            entity.Property(e => e.GeospatialPluginPdfImage).HasMaxLength(1000);
            entity.Property(e => e.IsGeoSvg).HasColumnName("IsGeoSVG");
            entity.Property(e => e.MapImage).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.PdfImage)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SyncAction>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActionOwner).HasMaxLength(100);
            entity.Property(e => e.EffectiveTime).HasColumnType("datetime");
            entity.Property(e => e.Entity)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.SyncActionTypeId).HasColumnName("SyncActionTypeID");

            entity.HasOne(d => d.SyncActionType).WithMany(p => p.SyncActions)
                .HasForeignKey(d => d.SyncActionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SyncActions_SyncActionTypes");
        });

        modelBuilder.Entity<SyncActionType>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_SyncActionTypes").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.UserName, "IX_Users").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActivityStateId).HasColumnName("ActivityStateID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ActivityState).WithMany(p => p.Users)
                .HasForeignKey(d => d.ActivityStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_ActivityStates");

            entity.HasOne(d => d.Partner).WithMany(p => p.Users)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("FK_Users_Partners");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.RoleId }, "IX_UserRoles").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserRoles_Users");
        });

        modelBuilder.Entity<UserSessionEventLog>(entity =>
        {
            entity.ToTable("UserSessionEventLog");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LoginTime).HasColumnType("datetime");
            entity.Property(e => e.LogoutTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.UserSessionEventLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSessionEventLog_Users");
        });

        modelBuilder.Entity<UupuserLot>(entity =>
        {
            entity.ToTable("UUPUserLots");

            entity.HasIndex(e => new { e.UupuserId, e.LotId }, "IX_UUPUserLots").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BdxcommunityId).HasColumnName("BDXCommunityID");
            entity.Property(e => e.BdxpartnerId).HasColumnName("BDXPartnerID");
            entity.Property(e => e.DisplayName).HasMaxLength(200);
            entity.Property(e => e.LotId).HasColumnName("LotID");
            entity.Property(e => e.SiteImageName).HasMaxLength(200);
            entity.Property(e => e.UupuserId)
                .HasMaxLength(200)
                .HasColumnName("UUPUserID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
