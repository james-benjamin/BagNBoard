using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace DataBroker_API.Model.GCDMySQL;

public partial class GcdContext : DbContext
{
    public GcdContext()
    {
    }

    public GcdContext(DbContextOptions<GcdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }

    public virtual DbSet<GcdAward> GcdAwards { get; set; }

    public virtual DbSet<GcdBiblioEntry> GcdBiblioEntries { get; set; }

    public virtual DbSet<GcdBrand> GcdBrands { get; set; }

    public virtual DbSet<GcdBrandEmblemGroup> GcdBrandEmblemGroups { get; set; }

    public virtual DbSet<GcdBrandGroup> GcdBrandGroups { get; set; }

    public virtual DbSet<GcdBrandUse> GcdBrandUses { get; set; }

    public virtual DbSet<GcdCharacter> GcdCharacters { get; set; }

    public virtual DbSet<GcdCharacterNameDetail> GcdCharacterNameDetails { get; set; }

    public virtual DbSet<GcdCharacterRelation> GcdCharacterRelations { get; set; }

    public virtual DbSet<GcdCharacterRelationType> GcdCharacterRelationTypes { get; set; }

    public virtual DbSet<GcdCharacterRole> GcdCharacterRoles { get; set; }

    public virtual DbSet<GcdCreator> GcdCreators { get; set; }

    public virtual DbSet<GcdCreatorArtInfluence> GcdCreatorArtInfluences { get; set; }

    public virtual DbSet<GcdCreatorDegree> GcdCreatorDegrees { get; set; }

    public virtual DbSet<GcdCreatorMembership> GcdCreatorMemberships { get; set; }

    public virtual DbSet<GcdCreatorNameDetail> GcdCreatorNameDetails { get; set; }

    public virtual DbSet<GcdCreatorNonComicWork> GcdCreatorNonComicWorks { get; set; }

    public virtual DbSet<GcdCreatorRelation> GcdCreatorRelations { get; set; }

    public virtual DbSet<GcdCreatorRelationCreatorName> GcdCreatorRelationCreatorNames { get; set; }

    public virtual DbSet<GcdCreatorSchool> GcdCreatorSchools { get; set; }

    public virtual DbSet<GcdCreatorSignature> GcdCreatorSignatures { get; set; }

    public virtual DbSet<GcdCreditType> GcdCreditTypes { get; set; }

    public virtual DbSet<GcdDegree> GcdDegrees { get; set; }

    public virtual DbSet<GcdFeature> GcdFeatures { get; set; }

    public virtual DbSet<GcdFeatureLogo> GcdFeatureLogos { get; set; }

    public virtual DbSet<GcdFeatureLogo2Feature> GcdFeatureLogo2Features { get; set; }

    public virtual DbSet<GcdFeatureRelation> GcdFeatureRelations { get; set; }

    public virtual DbSet<GcdFeatureRelationType> GcdFeatureRelationTypes { get; set; }

    public virtual DbSet<GcdFeatureType> GcdFeatureTypes { get; set; }

    public virtual DbSet<GcdGroup> GcdGroups { get; set; }

    public virtual DbSet<GcdGroupCharacter> GcdGroupCharacters { get; set; }

    public virtual DbSet<GcdGroupMembership> GcdGroupMemberships { get; set; }

    public virtual DbSet<GcdGroupMembershipType> GcdGroupMembershipTypes { get; set; }

    public virtual DbSet<GcdGroupNameDetail> GcdGroupNameDetails { get; set; }

    public virtual DbSet<GcdGroupRelation> GcdGroupRelations { get; set; }

    public virtual DbSet<GcdGroupRelationType> GcdGroupRelationTypes { get; set; }

    public virtual DbSet<GcdIndiciaPrinter> GcdIndiciaPrinters { get; set; }

    public virtual DbSet<GcdIndiciaPublisher> GcdIndiciaPublishers { get; set; }

    public virtual DbSet<GcdIssue> GcdIssues { get; set; }

    public virtual DbSet<GcdIssueCredit> GcdIssueCredits { get; set; }

    public virtual DbSet<GcdIssueIndiciaPrinter> GcdIssueIndiciaPrinters { get; set; }

    public virtual DbSet<GcdMembershipType> GcdMembershipTypes { get; set; }

    public virtual DbSet<GcdMultiverse> GcdMultiverses { get; set; }

    public virtual DbSet<GcdNameType> GcdNameTypes { get; set; }

    public virtual DbSet<GcdNonComicWorkRole> GcdNonComicWorkRoles { get; set; }

    public virtual DbSet<GcdNonComicWorkType> GcdNonComicWorkTypes { get; set; }

    public virtual DbSet<GcdNonComicWorkYear> GcdNonComicWorkYears { get; set; }

    public virtual DbSet<GcdPrinter> GcdPrinters { get; set; }

    public virtual DbSet<GcdPublisher> GcdPublishers { get; set; }

    public virtual DbSet<GcdReceivedAward> GcdReceivedAwards { get; set; }

    public virtual DbSet<GcdRelationType> GcdRelationTypes { get; set; }

    public virtual DbSet<GcdReprint> GcdReprints { get; set; }

    public virtual DbSet<GcdSchool> GcdSchools { get; set; }

    public virtual DbSet<GcdSeries> GcdSeries { get; set; }

    public virtual DbSet<GcdSeriesBond> GcdSeriesBonds { get; set; }

    public virtual DbSet<GcdSeriesBondType> GcdSeriesBondTypes { get; set; }

    public virtual DbSet<GcdSeriesPublicationType> GcdSeriesPublicationTypes { get; set; }

    public virtual DbSet<GcdStory> GcdStories { get; set; }

    public virtual DbSet<GcdStoryCharacter> GcdStoryCharacters { get; set; }

    public virtual DbSet<GcdStoryCharacterGroup> GcdStoryCharacterGroups { get; set; }

    public virtual DbSet<GcdStoryCredit> GcdStoryCredits { get; set; }

    public virtual DbSet<GcdStoryFeatureLogo> GcdStoryFeatureLogos { get; set; }

    public virtual DbSet<GcdStoryFeatureObject> GcdStoryFeatureObjects { get; set; }

    public virtual DbSet<GcdStoryType> GcdStoryTypes { get; set; }

    public virtual DbSet<GcdUniverse> GcdUniverses { get; set; }

    public virtual DbSet<StddataCountry> StddataCountries { get; set; }

    public virtual DbSet<StddataDate> StddataDates { get; set; }

    public virtual DbSet<StddataLanguage> StddataLanguages { get; set; }

    public virtual DbSet<StddataScript> StddataScripts { get; set; }

    public virtual DbSet<TaggitTag> TaggitTags { get; set; }

    public virtual DbSet<TaggitTaggeditem> TaggitTaggeditems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=GCD;uid=root;pwd=P@&&w0rd!", Microsoft.EntityFrameworkCore.ServerVersion.Parse("9.3.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<DjangoContentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("django_content_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.AppLabel, e.Model }, "app_label").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AppLabel)
                .HasMaxLength(100)
                .HasColumnName("app_label");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("model");
        });

        modelBuilder.Entity<GcdAward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_award")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Modified, "gcd_award_9ae73c65");

            entity.HasIndex(e => e.Deleted, "gcd_award_da602f0b");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
        });

        modelBuilder.Entity<GcdBiblioEntry>(entity =>
        {
            entity.HasKey(e => e.StoryPtrId).HasName("PRIMARY");

            entity
                .ToTable("gcd_biblio_entry")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.StoryPtrId)
                .ValueGeneratedNever()
                .HasColumnName("story_ptr_id");
            entity.Property(e => e.Abstract).HasColumnName("abstract");
            entity.Property(e => e.Doi).HasColumnName("doi");
            entity.Property(e => e.PageBegan).HasColumnName("page_began");
            entity.Property(e => e.PageEnded).HasColumnName("page_ended");

            entity.HasOne(d => d.StoryPtr).WithOne(p => p.GcdBiblioEntry)
                .HasForeignKey<GcdBiblioEntry>(d => d.StoryPtrId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_biblio_entry_story_ptr_id_d8f3d929_fk_gcd_story_id");
        });

        modelBuilder.Entity<GcdBrand>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_brand")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "deleted");

            entity.HasIndex(e => e.Modified, "gcd_brand_modified_5eff80882349f141_uniq");

            entity.HasIndex(e => e.YearOverallBegan, "gcd_brand_year_overall_began_ddc19cc8");

            entity.HasIndex(e => e.YearOverallBeganUncertain, "gcd_brand_year_overall_began_uncertain_31ef576d");

            entity.HasIndex(e => e.YearOverallEndedUncertain, "gcd_brand_year_overall_ended_uncertain_e0e3902a");

            entity.HasIndex(e => e.Name, "name");

            entity.HasIndex(e => e.YearBegan, "year_began");

            entity.HasIndex(e => e.YearBeganUncertain, "year_began_uncertain");

            entity.HasIndex(e => e.YearEndedUncertain, "year_ended_uncertain");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Generic).HasColumnName("generic");
            entity.Property(e => e.IssueCount).HasColumnName("issue_count");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");
            entity.Property(e => e.YearOverallBegan).HasColumnName("year_overall_began");
            entity.Property(e => e.YearOverallBeganUncertain).HasColumnName("year_overall_began_uncertain");
            entity.Property(e => e.YearOverallEnded).HasColumnName("year_overall_ended");
            entity.Property(e => e.YearOverallEndedUncertain).HasColumnName("year_overall_ended_uncertain");
        });

        modelBuilder.Entity<GcdBrandEmblemGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_brand_emblem_group")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.BrandId, "gcd_brand_emblem_group_74876276");

            entity.HasIndex(e => e.BrandgroupId, "gcd_brand_emblem_group_9eac909a");

            entity.HasIndex(e => new { e.BrandId, e.BrandgroupId }, "gcd_brand_emblem_group_brand_id_4dd3b49d7f79dbe3_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandgroupId).HasColumnName("brandgroup_id");

            entity.HasOne(d => d.Brand).WithMany(p => p.GcdBrandEmblemGroups)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("brand_id_refs_id_499c2f828021a0a5");

            entity.HasOne(d => d.Brandgroup).WithMany(p => p.GcdBrandEmblemGroups)
                .HasForeignKey(d => d.BrandgroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("brandgroup_id_refs_id_3d239edd15609953");
        });

        modelBuilder.Entity<GcdBrandGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_brand_group")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "gcd_brand_group_52094d6e");

            entity.HasIndex(e => e.ParentId, "gcd_brand_group_63f17a16");

            entity.HasIndex(e => e.Deleted, "gcd_brand_group_6cc99b0b");

            entity.HasIndex(e => e.YearEndedUncertain, "gcd_brand_group_8c53af9d");

            entity.HasIndex(e => e.YearBeganUncertain, "gcd_brand_group_b5b058a2");

            entity.HasIndex(e => e.YearBegan, "gcd_brand_group_d4f3f470");

            entity.HasIndex(e => e.Modified, "gcd_brand_group_modified_2a3c89f27446d469_uniq");

            entity.HasIndex(e => e.YearOverallBegan, "gcd_brand_group_year_overall_began_146c13e6");

            entity.HasIndex(e => e.YearOverallBeganUncertain, "gcd_brand_group_year_overall_began_uncertain_04003dcc");

            entity.HasIndex(e => e.YearOverallEndedUncertain, "gcd_brand_group_year_overall_ended_uncertain_099d9624");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IssueCount).HasColumnName("issue_count");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");
            entity.Property(e => e.YearOverallBegan).HasColumnName("year_overall_began");
            entity.Property(e => e.YearOverallBeganUncertain).HasColumnName("year_overall_began_uncertain");
            entity.Property(e => e.YearOverallEnded).HasColumnName("year_overall_ended");
            entity.Property(e => e.YearOverallEndedUncertain).HasColumnName("year_overall_ended_uncertain");

            entity.HasOne(d => d.Parent).WithMany(p => p.GcdBrandGroups)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("parent_id_refs_id_37eff265bd014aa2");
        });

        modelBuilder.Entity<GcdBrandUse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_brand_use")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.PublisherId, "gcd_brand_use_22dd9c39");

            entity.HasIndex(e => e.EmblemId, "gcd_brand_use_7c3d3954");

            entity.HasIndex(e => e.YearEndedUncertain, "gcd_brand_use_8c53af9d");

            entity.HasIndex(e => e.YearBeganUncertain, "gcd_brand_use_b5b058a2");

            entity.HasIndex(e => e.YearBegan, "gcd_brand_use_d4f3f470");

            entity.HasIndex(e => e.Modified, "gcd_brand_use_modified_2f953692");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.EmblemId).HasColumnName("emblem_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PublisherId).HasColumnName("publisher_id");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");

            entity.HasOne(d => d.Emblem).WithMany(p => p.GcdBrandUses)
                .HasForeignKey(d => d.EmblemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emblem_id_refs_id_66e921df4498a093");

            entity.HasOne(d => d.Publisher).WithMany(p => p.GcdBrandUses)
                .HasForeignKey(d => d.PublisherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("publisher_id_refs_id_4bf8142e98fbb94c");
        });

        modelBuilder.Entity<GcdCharacter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_character")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "gcd_character_deleted_cf8504b7");

            entity.HasIndex(e => e.Disambiguation, "gcd_character_disambiguation_6a99e15f");

            entity.HasIndex(e => e.LanguageId, "gcd_character_language_id_a766f96d_fk_stddata_language_id");

            entity.HasIndex(e => e.Modified, "gcd_character_modified_0364bb9a");

            entity.HasIndex(e => e.Name, "gcd_character_name_018c558c");

            entity.HasIndex(e => e.SortName, "gcd_character_sort_name_b009e2bf");

            entity.HasIndex(e => e.UniverseId, "gcd_character_universe_id_1058453c_fk_gcd_universe_id");

            entity.HasIndex(e => e.YearFirstPublished, "gcd_character_year_first_published_381260d2");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Disambiguation).HasColumnName("disambiguation");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.SortName).HasColumnName("sort_name");
            entity.Property(e => e.UniverseId).HasColumnName("universe_id");
            entity.Property(e => e.YearFirstPublished).HasColumnName("year_first_published");
            entity.Property(e => e.YearFirstPublishedUncertain).HasColumnName("year_first_published_uncertain");

            entity.HasOne(d => d.Language).WithMany(p => p.GcdCharacters)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_character_language_id_a766f96d_fk_stddata_language_id");

            entity.HasOne(d => d.Universe).WithMany(p => p.GcdCharacters)
                .HasForeignKey(d => d.UniverseId)
                .HasConstraintName("gcd_character_universe_id_1058453c_fk_gcd_universe_id");
        });

        modelBuilder.Entity<GcdCharacterNameDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_character_name_detail")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CharacterId, "gcd_character_name_d_character_id_a0aa1b65_fk_gcd_chara");

            entity.HasIndex(e => e.Deleted, "gcd_character_name_detail_deleted_cc14821d");

            entity.HasIndex(e => e.Modified, "gcd_character_name_detail_modified_d02579b5");

            entity.HasIndex(e => e.Name, "gcd_character_name_detail_name_fb316b3f");

            entity.HasIndex(e => e.SortName, "gcd_character_name_detail_sort_name_c86acd29");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IsOfficialName).HasColumnName("is_official_name");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.SortName).HasColumnName("sort_name");

            entity.HasOne(d => d.Character).WithMany(p => p.GcdCharacterNameDetails)
                .HasForeignKey(d => d.CharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_character_name_d_character_id_a0aa1b65_fk_gcd_chara");
        });

        modelBuilder.Entity<GcdCharacterRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_character_relation")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FromCharacterId, "gcd_character_relati_from_character_id_f632780f_fk_gcd_chara");

            entity.HasIndex(e => e.RelationTypeId, "gcd_character_relati_relation_type_id_4cfe6f07_fk_gcd_chara");

            entity.HasIndex(e => e.ToCharacterId, "gcd_character_relati_to_character_id_e08d735a_fk_gcd_chara");

            entity.HasIndex(e => e.Modified, "gcd_character_relation_modified_ac98c3e4");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.FromCharacterId).HasColumnName("from_character_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RelationTypeId).HasColumnName("relation_type_id");
            entity.Property(e => e.ToCharacterId).HasColumnName("to_character_id");

            entity.HasOne(d => d.FromCharacter).WithMany(p => p.GcdCharacterRelationFromCharacters)
                .HasForeignKey(d => d.FromCharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_character_relati_from_character_id_f632780f_fk_gcd_chara");

            entity.HasOne(d => d.RelationType).WithMany(p => p.GcdCharacterRelations)
                .HasForeignKey(d => d.RelationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_character_relati_relation_type_id_4cfe6f07_fk_gcd_chara");

            entity.HasOne(d => d.ToCharacter).WithMany(p => p.GcdCharacterRelationToCharacters)
                .HasForeignKey(d => d.ToCharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_character_relati_to_character_id_e08d735a_fk_gcd_chara");
        });

        modelBuilder.Entity<GcdCharacterRelationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_character_relation_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReverseType)
                .HasMaxLength(50)
                .HasColumnName("reverse_type");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<GcdCharacterRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_character_role")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "name").IsUnique();

            entity.HasIndex(e => e.SortCode, "sort_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.SortCode).HasColumnName("sort_code");
        });

        modelBuilder.Entity<GcdCreator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.GcdOfficialName, "gcd_creator_1ea4c9b1");

            entity.HasIndex(e => e.DeathCountryId, "gcd_creator_388fb40a");

            entity.HasIndex(e => e.BirthDateId, "gcd_creator_658bab16");

            entity.HasIndex(e => e.BirthCountryId, "gcd_creator_84c1a583");

            entity.HasIndex(e => e.DeathDateId, "gcd_creator_d8bf1a9c");

            entity.HasIndex(e => e.Deleted, "gcd_creator_da602f0b");

            entity.HasIndex(e => e.Disambiguation, "gcd_creator_disambiguation_21a5e71c");

            entity.HasIndex(e => e.Modified, "gcd_creator_modified_5920a4f3544476a0_uniq");

            entity.HasIndex(e => e.SortName, "gcd_creator_sort_name_80a1e4ff");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bio).HasColumnName("bio");
            entity.Property(e => e.BirthCity)
                .HasMaxLength(200)
                .HasColumnName("birth_city");
            entity.Property(e => e.BirthCityUncertain).HasColumnName("birth_city_uncertain");
            entity.Property(e => e.BirthCountryId).HasColumnName("birth_country_id");
            entity.Property(e => e.BirthCountryUncertain).HasColumnName("birth_country_uncertain");
            entity.Property(e => e.BirthDateId).HasColumnName("birth_date_id");
            entity.Property(e => e.BirthProvince)
                .HasMaxLength(50)
                .HasColumnName("birth_province");
            entity.Property(e => e.BirthProvinceUncertain).HasColumnName("birth_province_uncertain");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.DeathCity)
                .HasMaxLength(200)
                .HasColumnName("death_city");
            entity.Property(e => e.DeathCityUncertain).HasColumnName("death_city_uncertain");
            entity.Property(e => e.DeathCountryId).HasColumnName("death_country_id");
            entity.Property(e => e.DeathCountryUncertain).HasColumnName("death_country_uncertain");
            entity.Property(e => e.DeathDateId).HasColumnName("death_date_id");
            entity.Property(e => e.DeathProvince)
                .HasMaxLength(50)
                .HasColumnName("death_province");
            entity.Property(e => e.DeathProvinceUncertain).HasColumnName("death_province_uncertain");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Disambiguation).HasColumnName("disambiguation");
            entity.Property(e => e.GcdOfficialName).HasColumnName("gcd_official_name");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.SortName).HasColumnName("sort_name");
            entity.Property(e => e.WhosWho)
                .HasMaxLength(200)
                .HasColumnName("whos_who");

            entity.HasOne(d => d.BirthCountry).WithMany(p => p.GcdCreatorBirthCountries)
                .HasForeignKey(d => d.BirthCountryId)
                .HasConstraintName("gcd_crea_birth_country_id_763042865119b661_fk_stddata_country_id");

            entity.HasOne(d => d.BirthDate).WithMany(p => p.GcdCreatorBirthDates)
                .HasForeignKey(d => d.BirthDateId)
                .HasConstraintName("gcd_creator_birth_date_id_78325325e7e05e56_fk_stddata_date_id");

            entity.HasOne(d => d.DeathCountry).WithMany(p => p.GcdCreatorDeathCountries)
                .HasForeignKey(d => d.DeathCountryId)
                .HasConstraintName("gcd_crea_death_country_id_564f5820f21e9ede_fk_stddata_country_id");

            entity.HasOne(d => d.DeathDate).WithMany(p => p.GcdCreatorDeathDates)
                .HasForeignKey(d => d.DeathDateId)
                .HasConstraintName("gcd_creator_death_date_id_192a573e76c2f1cd_fk_stddata_date_id");
        });

        modelBuilder.Entity<GcdCreatorArtInfluence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_art_influence")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CreatorId, "gcd_creator_art_influence_3700153c");

            entity.HasIndex(e => e.Deleted, "gcd_creator_art_influence_da602f0b");

            entity.HasIndex(e => e.InfluenceLinkId, "gcd_creator_art_influence_ea572c03");

            entity.HasIndex(e => e.Modified, "gcd_creator_art_influence_modified_1c0f19408432804c_uniq");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.InfluenceLinkId).HasColumnName("influence_link_id");
            entity.Property(e => e.InfluenceName)
                .HasMaxLength(200)
                .HasColumnName("influence_name");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdCreatorArtInfluenceCreators)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_art_influence_creator_id_af97901f_fk_gcd_creator_id");

            entity.HasOne(d => d.InfluenceLink).WithMany(p => p.GcdCreatorArtInfluenceInfluenceLinks)
                .HasForeignKey(d => d.InfluenceLinkId)
                .HasConstraintName("gcd_creator_art_infl_influence_link_id_7ffc0a72_fk_gcd_creat");
        });

        modelBuilder.Entity<GcdCreatorDegree>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_degree")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.DegreeId, "gcd_creator_degree_0e798d2a");

            entity.HasIndex(e => e.CreatorId, "gcd_creator_degree_3700153c");

            entity.HasIndex(e => e.SchoolId, "gcd_creator_degree_5fc7164b");

            entity.HasIndex(e => e.Deleted, "gcd_creator_degree_da602f0b");

            entity.HasIndex(e => e.Modified, "gcd_creator_degree_modified_36c3bd276c240964_uniq");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.DegreeId).HasColumnName("degree_id");
            entity.Property(e => e.DegreeYear).HasColumnName("degree_year");
            entity.Property(e => e.DegreeYearUncertain).HasColumnName("degree_year_uncertain");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.SchoolId).HasColumnName("school_id");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdCreatorDegrees)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_degree_creator_id_2d1a7e1b51ae365d_fk_gcd_creator_id");

            entity.HasOne(d => d.Degree).WithMany(p => p.GcdCreatorDegrees)
                .HasForeignKey(d => d.DegreeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_degree_degree_id_25975d216f588700_fk_gcd_degree_id");

            entity.HasOne(d => d.School).WithMany(p => p.GcdCreatorDegrees)
                .HasForeignKey(d => d.SchoolId)
                .HasConstraintName("gcd_creator_degree_school_id_34e8b4f567e05b8c_fk_gcd_school_id");
        });

        modelBuilder.Entity<GcdCreatorMembership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_membership")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CreatorId, "gcd_creator_membership_3700153c");

            entity.HasIndex(e => e.Deleted, "gcd_creator_membership_da602f0b");

            entity.HasIndex(e => e.MembershipTypeId, "gcd_creator_membership_f0ca3e55");

            entity.HasIndex(e => e.Modified, "gcd_creator_membership_modified_37ffa94043c9f144_uniq");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.MembershipTypeId).HasColumnName("membership_type_id");
            entity.Property(e => e.MembershipYearBegan).HasColumnName("membership_year_began");
            entity.Property(e => e.MembershipYearBeganUncertain).HasColumnName("membership_year_began_uncertain");
            entity.Property(e => e.MembershipYearEnded).HasColumnName("membership_year_ended");
            entity.Property(e => e.MembershipYearEndedUncertain).HasColumnName("membership_year_ended_uncertain");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OrganizationName)
                .HasMaxLength(200)
                .HasColumnName("organization_name");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdCreatorMemberships)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_member_creator_id_4ed99850c0c56535_fk_gcd_creator_id");

            entity.HasOne(d => d.MembershipType).WithMany(p => p.GcdCreatorMemberships)
                .HasForeignKey(d => d.MembershipTypeId)
                .HasConstraintName("gc_membership_type_id_214046281e0da56a_fk_gcd_membership_type_id");
        });

        modelBuilder.Entity<GcdCreatorNameDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_name_detail")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.InScriptId, "gcd_creator_name_det_in_script_id_b7560492_fk_stddata_s");

            entity.HasIndex(e => e.CreatorId, "gcd_creator_name_detail_3700153c");

            entity.HasIndex(e => e.TypeId, "gcd_creator_name_detail_94757cae");

            entity.HasIndex(e => e.Name, "gcd_creator_name_detail_b068931c");

            entity.HasIndex(e => e.Deleted, "gcd_creator_name_detail_da602f0b");

            entity.HasIndex(e => e.FamilyName, "gcd_creator_name_detail_family_name_e81f34f4");

            entity.HasIndex(e => e.GivenName, "gcd_creator_name_detail_given_name_6706c242");

            entity.HasIndex(e => e.Modified, "gcd_creator_name_detail_modified_1bc0d6e170b913fe_uniq");

            entity.HasIndex(e => e.SortName, "gcd_creator_name_detail_sort_name_f7d3caa6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.FamilyName).HasColumnName("family_name");
            entity.Property(e => e.GivenName).HasColumnName("given_name");
            entity.Property(e => e.InScriptId).HasColumnName("in_script_id");
            entity.Property(e => e.IsOfficialName).HasColumnName("is_official_name");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.SortName).HasColumnName("sort_name");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdCreatorNameDetails)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_name_d_creator_id_6fb7edba0f224837_fk_gcd_creator_id");

            entity.HasOne(d => d.InScript).WithMany(p => p.GcdCreatorNameDetails)
                .HasForeignKey(d => d.InScriptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_name_det_in_script_id_b7560492_fk_stddata_s");

            entity.HasOne(d => d.Type).WithMany(p => p.GcdCreatorNameDetails)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("gcd_creator_name_detail_type_id_cce05647_fk_gcd_name_type_id");
        });

        modelBuilder.Entity<GcdCreatorNonComicWork>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_non_comic_work")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.WorkRoleId, "gcd_creator_non_comic_work_1fd7e1a2");

            entity.HasIndex(e => e.WorkTypeId, "gcd_creator_non_comic_work_333f9095");

            entity.HasIndex(e => e.CreatorId, "gcd_creator_non_comic_work_3700153c");

            entity.HasIndex(e => e.Deleted, "gcd_creator_non_comic_work_da602f0b");

            entity.HasIndex(e => e.Modified, "gcd_creator_non_comic_work_modified_1ea7d996ae050445_uniq");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(200)
                .HasColumnName("employer_name");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PublicationTitle)
                .HasMaxLength(200)
                .HasColumnName("publication_title");
            entity.Property(e => e.WorkRoleId).HasColumnName("work_role_id");
            entity.Property(e => e.WorkTitle)
                .HasMaxLength(255)
                .HasColumnName("work_title");
            entity.Property(e => e.WorkTypeId).HasColumnName("work_type_id");
            entity.Property(e => e.WorkUrls).HasColumnName("work_urls");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdCreatorNonComicWorks)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_non_co_creator_id_2bf5eba03c4340b4_fk_gcd_creator_id");

            entity.HasOne(d => d.WorkRole).WithMany(p => p.GcdCreatorNonComicWorks)
                .HasForeignKey(d => d.WorkRoleId)
                .HasConstraintName("gcd_c_work_role_id_98df94d341f6000_fk_gcd_non_comic_work_role_id");

            entity.HasOne(d => d.WorkType).WithMany(p => p.GcdCreatorNonComicWorks)
                .HasForeignKey(d => d.WorkTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd__work_type_id_3bc189b3f6be8a38_fk_gcd_non_comic_work_type_id");
        });

        modelBuilder.Entity<GcdCreatorRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_relation")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FromCreatorId, "gcd_creator_relation_1d58baf1");

            entity.HasIndex(e => e.RelationTypeId, "gcd_creator_relation_5f290fb5");

            entity.HasIndex(e => e.ToCreatorId, "gcd_creator_relation_6821265c");

            entity.HasIndex(e => e.Deleted, "gcd_creator_relation_da602f0b");

            entity.HasIndex(e => e.Modified, "gcd_creator_relation_modified_4c3574d61a89568e_uniq");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.FromCreatorId).HasColumnName("from_creator_id");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RelationTypeId).HasColumnName("relation_type_id");
            entity.Property(e => e.ToCreatorId).HasColumnName("to_creator_id");

            entity.HasOne(d => d.FromCreator).WithMany(p => p.GcdCreatorRelationFromCreators)
                .HasForeignKey(d => d.FromCreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_re_from_creator_id_12353b87e0ffa85_fk_gcd_creator_id");

            entity.HasOne(d => d.RelationType).WithMany(p => p.GcdCreatorRelations)
                .HasForeignKey(d => d.RelationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_cr_relation_type_id_6b325352f7711cf6_fk_gcd_relation_type_id");

            entity.HasOne(d => d.ToCreator).WithMany(p => p.GcdCreatorRelationToCreators)
                .HasForeignKey(d => d.ToCreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_rel_to_creator_id_5893caf404626fdc_fk_gcd_creator_id");
        });

        modelBuilder.Entity<GcdCreatorRelationCreatorName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_relation_creator_name")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.CreatorrelationId, e.CreatornamedetailId }, "gcd_creator_relation_cre_creatorrelation_id_creat_953af27b_uniq").IsUnique();

            entity.HasIndex(e => e.CreatornamedetailId, "gcd_creator_relation_creatornamedetail_id_4675e7fc_fk_gcd_creat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatornamedetailId).HasColumnName("creatornamedetail_id");
            entity.Property(e => e.CreatorrelationId).HasColumnName("creatorrelation_id");

            entity.HasOne(d => d.Creatornamedetail).WithMany(p => p.GcdCreatorRelationCreatorNames)
                .HasForeignKey(d => d.CreatornamedetailId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_relation_creatornamedetail_id_4675e7fc_fk_gcd_creat");

            entity.HasOne(d => d.Creatorrelation).WithMany(p => p.GcdCreatorRelationCreatorNames)
                .HasForeignKey(d => d.CreatorrelationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_relation_creatorrelation_id_d48c32dc_fk_gcd_creat");
        });

        modelBuilder.Entity<GcdCreatorSchool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_school")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CreatorId, "gcd_creator_school_3700153c");

            entity.HasIndex(e => e.SchoolId, "gcd_creator_school_5fc7164b");

            entity.HasIndex(e => e.Deleted, "gcd_creator_school_da602f0b");

            entity.HasIndex(e => e.Modified, "gcd_creator_school_modified_452d6d27a108110_uniq");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.SchoolId).HasColumnName("school_id");
            entity.Property(e => e.SchoolYearBegan).HasColumnName("school_year_began");
            entity.Property(e => e.SchoolYearBeganUncertain).HasColumnName("school_year_began_uncertain");
            entity.Property(e => e.SchoolYearEnded).HasColumnName("school_year_ended");
            entity.Property(e => e.SchoolYearEndedUncertain).HasColumnName("school_year_ended_uncertain");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdCreatorSchools)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_school_creator_id_2525d2f8e697f937_fk_gcd_creator_id");

            entity.HasOne(d => d.School).WithMany(p => p.GcdCreatorSchools)
                .HasForeignKey(d => d.SchoolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_school_school_id_532eb68322363260_fk_gcd_school_id");
        });

        modelBuilder.Entity<GcdCreatorSignature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_creator_signature")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CreatorId, "gcd_creator_signature_creator_id_063b6789_fk_gcd_creator_id");

            entity.HasIndex(e => e.Deleted, "gcd_creator_signature_deleted_2e7249b9");

            entity.HasIndex(e => e.Modified, "gcd_creator_signature_modified_064658ce");

            entity.HasIndex(e => e.Name, "gcd_creator_signature_name_91dfd0cc");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Generic).HasColumnName("generic");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdCreatorSignatures)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_creator_signature_creator_id_063b6789_fk_gcd_creator_id");
        });

        modelBuilder.Entity<GcdCreditType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_credit_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "name").IsUnique();

            entity.HasIndex(e => e.SortCode, "sort_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.SortCode).HasColumnName("sort_code");
        });

        modelBuilder.Entity<GcdDegree>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_degree")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DegreeName)
                .HasMaxLength(200)
                .HasColumnName("degree_name");
        });

        modelBuilder.Entity<GcdFeature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_feature")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "gcd_feature_deleted_d2842928");

            entity.HasIndex(e => e.Disambiguation, "gcd_feature_disambiguation_fe7ce1a9");

            entity.HasIndex(e => e.FeatureTypeId, "gcd_feature_feature_type_id_0bd38e4d_fk_gcd_feature_type_id");

            entity.HasIndex(e => e.LanguageId, "gcd_feature_language_id_f6ca9801_fk_stddata_language_id");

            entity.HasIndex(e => e.Modified, "gcd_feature_modified_dc767107");

            entity.HasIndex(e => e.Name, "gcd_feature_name_1b482a02");

            entity.HasIndex(e => e.SortName, "gcd_feature_sort_name_aa22b333");

            entity.HasIndex(e => e.YearFirstPublished, "gcd_feature_year_created_d3f06615");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Disambiguation).HasColumnName("disambiguation");
            entity.Property(e => e.FeatureTypeId).HasColumnName("feature_type_id");
            entity.Property(e => e.Genre)
                .HasMaxLength(255)
                .HasColumnName("genre");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.SortName).HasColumnName("sort_name");
            entity.Property(e => e.YearFirstPublished).HasColumnName("year_first_published");
            entity.Property(e => e.YearFirstPublishedUncertain).HasColumnName("year_first_published_uncertain");

            entity.HasOne(d => d.FeatureType).WithMany(p => p.GcdFeatures)
                .HasForeignKey(d => d.FeatureTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_feature_feature_type_id_0bd38e4d_fk_gcd_feature_type_id");

            entity.HasOne(d => d.Language).WithMany(p => p.GcdFeatures)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_feature_language_id_f6ca9801_fk_stddata_language_id");
        });

        modelBuilder.Entity<GcdFeatureLogo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_feature_logo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "gcd_feature_logo_deleted_7fc639e5");

            entity.HasIndex(e => e.Modified, "gcd_feature_logo_modified_a01588f8");

            entity.HasIndex(e => e.Name, "gcd_feature_logo_name_fca0238c");

            entity.HasIndex(e => e.SortName, "gcd_feature_logo_sort_name_fc35812c");

            entity.HasIndex(e => e.YearBegan, "gcd_feature_logo_year_began_e62b6676");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Generic).HasColumnName("generic");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.SortName).HasColumnName("sort_name");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");
        });

        modelBuilder.Entity<GcdFeatureLogo2Feature>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_feature_logo_2_feature")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.FeaturelogoId, e.FeatureId }, "gcd_feature_logo_2_featu_featurelogo_id_feature_i_26489bce_uniq").IsUnique();

            entity.HasIndex(e => e.FeatureId, "gcd_feature_logo_2_feature_feature_id_8ec96fc1_fk_gcd_feature_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FeatureId).HasColumnName("feature_id");
            entity.Property(e => e.FeaturelogoId).HasColumnName("featurelogo_id");

            entity.HasOne(d => d.Feature).WithMany(p => p.GcdFeatureLogo2Features)
                .HasForeignKey(d => d.FeatureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_feature_logo_2_feature_feature_id_8ec96fc1_fk_gcd_feature_id");

            entity.HasOne(d => d.Featurelogo).WithMany(p => p.GcdFeatureLogo2Features)
                .HasForeignKey(d => d.FeaturelogoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_feature_logo_2_f_featurelogo_id_3e696cd6_fk_gcd_featu");
        });

        modelBuilder.Entity<GcdFeatureRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_feature_relation")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FromFeatureId, "gcd_feature_relation_from_feature_id_25e36fdf_fk_gcd_feature_id");

            entity.HasIndex(e => e.Modified, "gcd_feature_relation_modified_896fb6c6");

            entity.HasIndex(e => e.RelationTypeId, "gcd_feature_relation_relation_type_id_09ba4ac7_fk_gcd_featu");

            entity.HasIndex(e => e.ToFeatureId, "gcd_feature_relation_to_feature_id_e5a20bdf_fk_gcd_feature_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.FromFeatureId).HasColumnName("from_feature_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RelationTypeId).HasColumnName("relation_type_id");
            entity.Property(e => e.ToFeatureId).HasColumnName("to_feature_id");

            entity.HasOne(d => d.FromFeature).WithMany(p => p.GcdFeatureRelationFromFeatures)
                .HasForeignKey(d => d.FromFeatureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_feature_relation_from_feature_id_25e36fdf_fk_gcd_feature_id");

            entity.HasOne(d => d.RelationType).WithMany(p => p.GcdFeatureRelations)
                .HasForeignKey(d => d.RelationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_feature_relation_relation_type_id_09ba4ac7_fk_gcd_featu");

            entity.HasOne(d => d.ToFeature).WithMany(p => p.GcdFeatureRelationToFeatures)
                .HasForeignKey(d => d.ToFeatureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_feature_relation_to_feature_id_e5a20bdf_fk_gcd_feature_id");
        });

        modelBuilder.Entity<GcdFeatureRelationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_feature_relation_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "gcd_feature_relation_type_name_5eb55141");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.ReverseDescription)
                .HasMaxLength(255)
                .HasColumnName("reverse_description");
        });

        modelBuilder.Entity<GcdFeatureType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_feature_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "gcd_feature_type_name_af6c2592");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<GcdGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_group")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "gcd_group_deleted_eb8063e4");

            entity.HasIndex(e => e.Disambiguation, "gcd_group_disambiguation_4e03cb92");

            entity.HasIndex(e => e.LanguageId, "gcd_group_language_id_e0935a36_fk_stddata_language_id");

            entity.HasIndex(e => e.Modified, "gcd_group_modified_316b6f0c");

            entity.HasIndex(e => e.Name, "gcd_group_name_0358904e");

            entity.HasIndex(e => e.SortName, "gcd_group_sort_name_1922a716");

            entity.HasIndex(e => e.UniverseId, "gcd_group_universe_id_e32b55ff_fk_gcd_universe_id");

            entity.HasIndex(e => e.YearFirstPublished, "gcd_group_year_first_published_65064aae");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Disambiguation).HasColumnName("disambiguation");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.SortName).HasColumnName("sort_name");
            entity.Property(e => e.UniverseId).HasColumnName("universe_id");
            entity.Property(e => e.YearFirstPublished).HasColumnName("year_first_published");
            entity.Property(e => e.YearFirstPublishedUncertain).HasColumnName("year_first_published_uncertain");

            entity.HasOne(d => d.Language).WithMany(p => p.GcdGroups)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_language_id_e0935a36_fk_stddata_language_id");

            entity.HasOne(d => d.Universe).WithMany(p => p.GcdGroups)
                .HasForeignKey(d => d.UniverseId)
                .HasConstraintName("gcd_group_universe_id_e32b55ff_fk_gcd_universe_id");
        });

        modelBuilder.Entity<GcdGroupCharacter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_group_character")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "gcd_group_character_deleted_da9fb253");

            entity.HasIndex(e => e.GroupNameId, "gcd_group_character_group_name_id_a01b83b2_fk_gcd_group");

            entity.HasIndex(e => e.Modified, "gcd_group_character_modified_2e1743fd");

            entity.HasIndex(e => e.StoryId, "gcd_group_character_story_id_4aedac36_fk_gcd_story_id");

            entity.HasIndex(e => e.UniverseId, "gcd_group_character_universe_id_34fdd9e7_fk_gcd_universe_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.GroupNameId).HasColumnName("group_name_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.StoryId).HasColumnName("story_id");
            entity.Property(e => e.UniverseId).HasColumnName("universe_id");

            entity.HasOne(d => d.GroupName).WithMany(p => p.GcdGroupCharacters)
                .HasForeignKey(d => d.GroupNameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_character_group_name_id_a01b83b2_fk_gcd_group");

            entity.HasOne(d => d.Story).WithMany(p => p.GcdGroupCharacters)
                .HasForeignKey(d => d.StoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_character_story_id_4aedac36_fk_gcd_story_id");

            entity.HasOne(d => d.Universe).WithMany(p => p.GcdGroupCharacters)
                .HasForeignKey(d => d.UniverseId)
                .HasConstraintName("gcd_group_character_universe_id_34fdd9e7_fk_gcd_universe_id");
        });

        modelBuilder.Entity<GcdGroupMembership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_group_membership")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CharacterId, "gcd_group_membership_character_id_ce34b6e6_fk_gcd_character_id");

            entity.HasIndex(e => e.GroupId, "gcd_group_membership_group_id_ee6c8c22_fk_gcd_group_id");

            entity.HasIndex(e => e.MembershipTypeId, "gcd_group_membership_membership_type_id_32854b66_fk_gcd_group");

            entity.HasIndex(e => e.Modified, "gcd_group_membership_modified_1b391fa5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.MembershipTypeId).HasColumnName("membership_type_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.YearJoined).HasColumnName("year_joined");
            entity.Property(e => e.YearJoinedUncertain).HasColumnName("year_joined_uncertain");
            entity.Property(e => e.YearLeft).HasColumnName("year_left");
            entity.Property(e => e.YearLeftUncertain).HasColumnName("year_left_uncertain");

            entity.HasOne(d => d.Character).WithMany(p => p.GcdGroupMemberships)
                .HasForeignKey(d => d.CharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_membership_character_id_ce34b6e6_fk_gcd_character_id");

            entity.HasOne(d => d.Group).WithMany(p => p.GcdGroupMemberships)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_membership_group_id_ee6c8c22_fk_gcd_group_id");

            entity.HasOne(d => d.MembershipType).WithMany(p => p.GcdGroupMemberships)
                .HasForeignKey(d => d.MembershipTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_membership_membership_type_id_32854b66_fk_gcd_group");
        });

        modelBuilder.Entity<GcdGroupMembershipType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_group_membership_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReverseType)
                .HasMaxLength(50)
                .HasColumnName("reverse_type");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<GcdGroupNameDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_group_name_detail")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "gcd_group_name_detail_deleted_ca292280");

            entity.HasIndex(e => e.GroupId, "gcd_group_name_detail_group_id_f6a401d7_fk_gcd_group_id");

            entity.HasIndex(e => e.Modified, "gcd_group_name_detail_modified_de08b22d");

            entity.HasIndex(e => e.Name, "gcd_group_name_detail_name_d1ffc28a");

            entity.HasIndex(e => e.SortName, "gcd_group_name_detail_sort_name_2a643b29");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.IsOfficialName).HasColumnName("is_official_name");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.SortName).HasColumnName("sort_name");

            entity.HasOne(d => d.Group).WithMany(p => p.GcdGroupNameDetails)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_name_detail_group_id_f6a401d7_fk_gcd_group_id");
        });

        modelBuilder.Entity<GcdGroupRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_group_relation")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FromGroupId, "gcd_group_relation_from_group_id_e865b8f6_fk_gcd_group_id");

            entity.HasIndex(e => e.Modified, "gcd_group_relation_modified_19f4c52a");

            entity.HasIndex(e => e.RelationTypeId, "gcd_group_relation_relation_type_id_ab30bd40_fk_gcd_group");

            entity.HasIndex(e => e.ToGroupId, "gcd_group_relation_to_group_id_454ce47f_fk_gcd_group_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.FromGroupId).HasColumnName("from_group_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RelationTypeId).HasColumnName("relation_type_id");
            entity.Property(e => e.ToGroupId).HasColumnName("to_group_id");

            entity.HasOne(d => d.FromGroup).WithMany(p => p.GcdGroupRelationFromGroups)
                .HasForeignKey(d => d.FromGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_relation_from_group_id_e865b8f6_fk_gcd_group_id");

            entity.HasOne(d => d.RelationType).WithMany(p => p.GcdGroupRelations)
                .HasForeignKey(d => d.RelationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_relation_relation_type_id_ab30bd40_fk_gcd_group");

            entity.HasOne(d => d.ToGroup).WithMany(p => p.GcdGroupRelationToGroups)
                .HasForeignKey(d => d.ToGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_group_relation_to_group_id_454ce47f_fk_gcd_group_id");
        });

        modelBuilder.Entity<GcdGroupRelationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_group_relation_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReverseType)
                .HasMaxLength(50)
                .HasColumnName("reverse_type");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<GcdIndiciaPrinter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_indicia_printer")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CountryId, "gcd_indicia_printer_country_id_7721a445_fk_stddata_country_id");

            entity.HasIndex(e => e.Deleted, "gcd_indicia_printer_deleted_7a641d17");

            entity.HasIndex(e => e.Modified, "gcd_indicia_printer_modified_778425fb");

            entity.HasIndex(e => e.Name, "gcd_indicia_printer_name_2aca0f76");

            entity.HasIndex(e => e.ParentId, "gcd_indicia_printer_parent_id_530af9b7_fk_gcd_printer_id");

            entity.HasIndex(e => e.YearBegan, "gcd_indicia_printer_year_began_c96ca6c5");

            entity.HasIndex(e => e.YearBeganUncertain, "gcd_indicia_printer_year_began_uncertain_0bd7f023");

            entity.HasIndex(e => e.YearEndedUncertain, "gcd_indicia_printer_year_ended_uncertain_efe8024d");

            entity.HasIndex(e => e.YearOverallBegan, "gcd_indicia_printer_year_overall_began_0ef47eac");

            entity.HasIndex(e => e.YearOverallBeganUncertain, "gcd_indicia_printer_year_overall_began_uncertain_c73e8a3a");

            entity.HasIndex(e => e.YearOverallEndedUncertain, "gcd_indicia_printer_year_overall_ended_uncertain_1f5b498c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IssueCount).HasColumnName("issue_count");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");
            entity.Property(e => e.YearOverallBegan).HasColumnName("year_overall_began");
            entity.Property(e => e.YearOverallBeganUncertain).HasColumnName("year_overall_began_uncertain");
            entity.Property(e => e.YearOverallEnded).HasColumnName("year_overall_ended");
            entity.Property(e => e.YearOverallEndedUncertain).HasColumnName("year_overall_ended_uncertain");

            entity.HasOne(d => d.Country).WithMany(p => p.GcdIndiciaPrinters)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_indicia_printer_country_id_7721a445_fk_stddata_country_id");

            entity.HasOne(d => d.Parent).WithMany(p => p.GcdIndiciaPrinters)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_indicia_printer_parent_id_530af9b7_fk_gcd_printer_id");
        });

        modelBuilder.Entity<GcdIndiciaPublisher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_indicia_publisher")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CountryId, "country_id");

            entity.HasIndex(e => e.Deleted, "deleted");

            entity.HasIndex(e => e.Modified, "gcd_indicia_publisher_modified_43690202d96566e2_uniq");

            entity.HasIndex(e => e.YearOverallBegan, "gcd_indicia_publisher_year_overall_began_854f12bb");

            entity.HasIndex(e => e.YearOverallBeganUncertain, "gcd_indicia_publisher_year_overall_began_uncertain_d51c93af");

            entity.HasIndex(e => e.YearOverallEndedUncertain, "gcd_indicia_publisher_year_overall_ended_uncertain_784b92eb");

            entity.HasIndex(e => e.IsSurrogate, "is_surrogate");

            entity.HasIndex(e => e.Name, "name");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.HasIndex(e => e.YearBegan, "year_began");

            entity.HasIndex(e => e.YearBeganUncertain, "year_began_uncertain");

            entity.HasIndex(e => e.YearEndedUncertain, "year_ended_uncertain");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IsSurrogate).HasColumnName("is_surrogate");
            entity.Property(e => e.IssueCount).HasColumnName("issue_count");
            entity.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");
            entity.Property(e => e.YearOverallBegan).HasColumnName("year_overall_began");
            entity.Property(e => e.YearOverallBeganUncertain).HasColumnName("year_overall_began_uncertain");
            entity.Property(e => e.YearOverallEnded).HasColumnName("year_overall_ended");
            entity.Property(e => e.YearOverallEndedUncertain).HasColumnName("year_overall_ended_uncertain");

            entity.HasOne(d => d.Country).WithMany(p => p.GcdIndiciaPublishers)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_indicia_publisher_ibfk_2");

            entity.HasOne(d => d.Parent).WithMany(p => p.GcdIndiciaPublishers)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_indicia_publisher_ibfk_1");
        });

        modelBuilder.Entity<GcdIssue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_issue")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Number, "Issue");

            entity.HasIndex(e => e.KeyDate, "Key_Date");

            entity.HasIndex(e => e.Modified, "Modified");

            entity.HasIndex(e => e.SeriesId, "SeriesID");

            entity.HasIndex(e => e.Volume, "VolumeNum");

            entity.HasIndex(e => e.Barcode, "barcode");

            entity.HasIndex(e => e.BrandId, "brand_id");

            entity.HasIndex(e => e.Deleted, "deleted");

            entity.HasIndex(e => e.DisplayVolumeWithNumber, "display_volume_with_number");

            entity.HasIndex(e => e.Rating, "gcd_issue_1a619ca6");

            entity.HasIndex(e => e.NoRating, "gcd_issue_ed4c6b73");

            entity.HasIndex(e => e.VariantCoverStatus, "gcd_issue_variant_cover_status_52969645");

            entity.HasIndex(e => e.IndiciaPublisherId, "indicia_publisher_id");

            entity.HasIndex(e => e.IsIndexed, "is_indexed");

            entity.HasIndex(e => e.Isbn, "isbn");

            entity.HasIndex(e => e.NoBrand, "no_brand");

            entity.HasIndex(e => e.NoEditing, "no_editing");

            entity.HasIndex(e => e.NoIndiciaFrequency, "no_indicia_frequency");

            entity.HasIndex(e => e.NoIsbn, "no_isbn");

            entity.HasIndex(e => e.NoTitle, "no_title");

            entity.HasIndex(e => e.NoVolume, "no_volume");

            entity.HasIndex(e => e.OnSaleDate, "on_sale_date");

            entity.HasIndex(e => new { e.SeriesId, e.SortCode }, "series_id_sort_code").IsUnique();

            entity.HasIndex(e => e.SortCode, "sort_code");

            entity.HasIndex(e => e.Title, "title");

            entity.HasIndex(e => e.ValidIsbn, "valid_isbn");

            entity.HasIndex(e => e.VariantOfId, "variant_of_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Barcode)
                .HasMaxLength(38)
                .HasDefaultValueSql("''")
                .HasColumnName("barcode");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1901-01-01 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.DisplayVolumeWithNumber).HasColumnName("display_volume_with_number");
            entity.Property(e => e.Editing).HasColumnName("editing");
            entity.Property(e => e.IndiciaFrequency)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("indicia_frequency");
            entity.Property(e => e.IndiciaPubNotPrinted).HasColumnName("indicia_pub_not_printed");
            entity.Property(e => e.IndiciaPublisherId).HasColumnName("indicia_publisher_id");
            entity.Property(e => e.IsIndexed).HasColumnName("is_indexed");
            entity.Property(e => e.Isbn)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("isbn");
            entity.Property(e => e.KeyDate)
                .HasMaxLength(10)
                .HasColumnName("key_date");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1901-01-01 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NoBarcode).HasColumnName("no_barcode");
            entity.Property(e => e.NoBrand).HasColumnName("no_brand");
            entity.Property(e => e.NoEditing).HasColumnName("no_editing");
            entity.Property(e => e.NoIndiciaFrequency).HasColumnName("no_indicia_frequency");
            entity.Property(e => e.NoIndiciaPrinter).HasColumnName("no_indicia_printer");
            entity.Property(e => e.NoIsbn).HasColumnName("no_isbn");
            entity.Property(e => e.NoRating).HasColumnName("no_rating");
            entity.Property(e => e.NoTitle).HasColumnName("no_title");
            entity.Property(e => e.NoVolume).HasColumnName("no_volume");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Number)
                .HasMaxLength(50)
                .HasColumnName("number");
            entity.Property(e => e.OnSaleDate)
                .HasMaxLength(10)
                .HasColumnName("on_sale_date");
            entity.Property(e => e.OnSaleDateUncertain).HasColumnName("on_sale_date_uncertain");
            entity.Property(e => e.PageCount)
                .HasPrecision(10, 3)
                .HasColumnName("page_count");
            entity.Property(e => e.PageCountUncertain).HasColumnName("page_count_uncertain");
            entity.Property(e => e.Price)
                .HasMaxLength(255)
                .HasColumnName("price");
            entity.Property(e => e.PublicationDate)
                .HasMaxLength(255)
                .HasColumnName("publication_date");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.SeriesId).HasColumnName("series_id");
            entity.Property(e => e.SortCode).HasColumnName("sort_code");
            entity.Property(e => e.Title)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.ValidIsbn)
                .HasMaxLength(13)
                .HasDefaultValueSql("''")
                .HasColumnName("valid_isbn");
            entity.Property(e => e.VariantCoverStatus).HasColumnName("variant_cover_status");
            entity.Property(e => e.VariantName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("variant_name");
            entity.Property(e => e.VariantOfId).HasColumnName("variant_of_id");
            entity.Property(e => e.Volume)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("volume");
            entity.Property(e => e.VolumeNotPrinted).HasColumnName("volume_not_printed");

            entity.HasOne(d => d.Brand).WithMany(p => p.GcdIssues)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("gcd_issue_ibfk_3");

            entity.HasOne(d => d.IndiciaPublisher).WithMany(p => p.GcdIssues)
                .HasForeignKey(d => d.IndiciaPublisherId)
                .HasConstraintName("gcd_issue_ibfk_2");

            entity.HasOne(d => d.Series).WithMany(p => p.GcdIssues)
                .HasForeignKey(d => d.SeriesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_issue_ibfk_1");

            entity.HasOne(d => d.VariantOf).WithMany(p => p.InverseVariantOf)
                .HasForeignKey(d => d.VariantOfId)
                .HasConstraintName("gcd_issue_ibfk_4");
        });

        modelBuilder.Entity<GcdIssueCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_issue_credit")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CreatorId, "gcd_issue_credit_creator_id_d23239af_fk_gcd_creat");

            entity.HasIndex(e => e.CreditTypeId, "gcd_issue_credit_credit_type_id_85428160_fk_gcd_credit_type_id");

            entity.HasIndex(e => e.Deleted, "gcd_issue_credit_deleted_28f591fc");

            entity.HasIndex(e => e.IsCredited, "gcd_issue_credit_is_credited_448cd70d");

            entity.HasIndex(e => e.IsSourced, "gcd_issue_credit_is_sourced_f6bb6c2c");

            entity.HasIndex(e => e.IssueId, "gcd_issue_credit_issue_id_928f51d6_fk_gcd_issue_id");

            entity.HasIndex(e => e.Modified, "gcd_issue_credit_modified_92c90a4b");

            entity.HasIndex(e => e.Uncertain, "gcd_issue_credit_uncertain_a122bed6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.CreditName)
                .HasMaxLength(255)
                .HasColumnName("credit_name");
            entity.Property(e => e.CreditTypeId).HasColumnName("credit_type_id");
            entity.Property(e => e.CreditedAs)
                .HasMaxLength(255)
                .HasColumnName("credited_as");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IsCredited).HasColumnName("is_credited");
            entity.Property(e => e.IsSourced).HasColumnName("is_sourced");
            entity.Property(e => e.IssueId).HasColumnName("issue_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.SourcedBy)
                .HasMaxLength(255)
                .HasColumnName("sourced_by");
            entity.Property(e => e.Uncertain).HasColumnName("uncertain");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdIssueCredits)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_issue_credit_creator_id_d23239af_fk_gcd_creat");

            entity.HasOne(d => d.CreditType).WithMany(p => p.GcdIssueCredits)
                .HasForeignKey(d => d.CreditTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_issue_credit_credit_type_id_85428160_fk_gcd_credit_type_id");

            entity.HasOne(d => d.Issue).WithMany(p => p.GcdIssueCredits)
                .HasForeignKey(d => d.IssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_issue_credit_issue_id_928f51d6_fk_gcd_issue_id");
        });

        modelBuilder.Entity<GcdIssueIndiciaPrinter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_issue_indicia_printer")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IndiciaprinterId, "gcd_issue_indicia_pr_indiciaprinter_id_c0f3b842_fk_gcd_indic");

            entity.HasIndex(e => new { e.IssueId, e.IndiciaprinterId }, "gcd_issue_indicia_printe_issue_id_indiciaprinter__f9448194_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IndiciaprinterId).HasColumnName("indiciaprinter_id");
            entity.Property(e => e.IssueId).HasColumnName("issue_id");

            entity.HasOne(d => d.Indiciaprinter).WithMany(p => p.GcdIssueIndiciaPrinters)
                .HasForeignKey(d => d.IndiciaprinterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_issue_indicia_pr_indiciaprinter_id_c0f3b842_fk_gcd_indic");

            entity.HasOne(d => d.Issue).WithMany(p => p.GcdIssueIndiciaPrinters)
                .HasForeignKey(d => d.IssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_issue_indicia_printer_issue_id_2965892e_fk_gcd_issue_id");
        });

        modelBuilder.Entity<GcdMembershipType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_membership_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
        });

        modelBuilder.Entity<GcdMultiverse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_multiverse")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "gcd_multiverse_deleted_9d0a1781");

            entity.HasIndex(e => e.MainstreamId, "gcd_multiverse_mainstream_id_9a3651b8_fk_gcd_universe_id");

            entity.HasIndex(e => e.Modified, "gcd_multiverse_modified_835703a1");

            entity.HasIndex(e => e.Name, "gcd_multiverse_name_d34fddb7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.MainstreamId).HasColumnName("mainstream_id");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.Mainstream).WithMany(p => p.GcdMultiverses)
                .HasForeignKey(d => d.MainstreamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_multiverse_mainstream_id_9a3651b8_fk_gcd_universe_id");
        });

        modelBuilder.Entity<GcdNameType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_name_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<GcdNonComicWorkRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_non_comic_work_role")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(200)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<GcdNonComicWorkType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_non_comic_work_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
        });

        modelBuilder.Entity<GcdNonComicWorkYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_non_comic_work_year")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.NonComicWorkId, "gcd_non_comic_work_year_3bb39492");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NonComicWorkId).HasColumnName("non_comic_work_id");
            entity.Property(e => e.WorkYear).HasColumnName("work_year");
            entity.Property(e => e.WorkYearUncertain).HasColumnName("work_year_uncertain");

            entity.HasOne(d => d.NonComicWork).WithMany(p => p.GcdNonComicWorkYears)
                .HasForeignKey(d => d.NonComicWorkId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("D0189e80e31281a6ea56ca3b1b0c7cde");
        });

        modelBuilder.Entity<GcdPrinter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_printer")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CountryId, "gcd_printer_country_id_889421fa_fk_stddata_country_id");

            entity.HasIndex(e => e.Deleted, "gcd_printer_deleted_3b0b11ef");

            entity.HasIndex(e => e.IndiciaPrinterCount, "gcd_printer_indicia_printer_count_c38d8965");

            entity.HasIndex(e => e.Modified, "gcd_printer_modified_f0a0e321");

            entity.HasIndex(e => e.Name, "gcd_printer_name_97854c5f");

            entity.HasIndex(e => e.YearBegan, "gcd_printer_year_began_9471a3eb");

            entity.HasIndex(e => e.YearBeganUncertain, "gcd_printer_year_began_uncertain_0b919273");

            entity.HasIndex(e => e.YearEndedUncertain, "gcd_printer_year_ended_uncertain_ff75a9b0");

            entity.HasIndex(e => e.YearOverallBegan, "gcd_printer_year_overall_began_3ba498cd");

            entity.HasIndex(e => e.YearOverallBeganUncertain, "gcd_printer_year_overall_began_uncertain_4225255a");

            entity.HasIndex(e => e.YearOverallEndedUncertain, "gcd_printer_year_overall_ended_uncertain_5e639616");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IndiciaPrinterCount).HasColumnName("indicia_printer_count");
            entity.Property(e => e.IssueCount).HasColumnName("issue_count");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");
            entity.Property(e => e.YearOverallBegan).HasColumnName("year_overall_began");
            entity.Property(e => e.YearOverallBeganUncertain).HasColumnName("year_overall_began_uncertain");
            entity.Property(e => e.YearOverallEnded).HasColumnName("year_overall_ended");
            entity.Property(e => e.YearOverallEndedUncertain).HasColumnName("year_overall_ended_uncertain");

            entity.HasOne(d => d.Country).WithMany(p => p.GcdPrinters)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_printer_country_id_889421fa_fk_stddata_country_id");
        });

        modelBuilder.Entity<GcdPublisher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_publisher")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "PubName");

            entity.HasIndex(e => e.YearBegan, "YearBegan");

            entity.HasIndex(e => e.BrandCount, "brand_count");

            entity.HasIndex(e => e.CountryId, "country_id");

            entity.HasIndex(e => e.Deleted, "deleted");

            entity.HasIndex(e => e.Modified, "gcd_publisher_modified_4da24f236c8f04fe_uniq");

            entity.HasIndex(e => e.YearOverallBegan, "gcd_publisher_year_overall_began_281cdf77");

            entity.HasIndex(e => e.YearOverallBeganUncertain, "gcd_publisher_year_overall_began_uncertain_7213c847");

            entity.HasIndex(e => e.YearOverallEndedUncertain, "gcd_publisher_year_overall_ended_uncertain_e155ab76");

            entity.HasIndex(e => e.IndiciaPublisherCount, "indicia_publisher_count");

            entity.HasIndex(e => e.YearBeganUncertain, "year_began_uncertain");

            entity.HasIndex(e => e.YearEndedUncertain, "year_ended_uncertain");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrandCount).HasColumnName("brand_count");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1901-01-01 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IndiciaPublisherCount).HasColumnName("indicia_publisher_count");
            entity.Property(e => e.IssueCount).HasColumnName("issue_count");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1901-01-01 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.SeriesCount).HasColumnName("series_count");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");
            entity.Property(e => e.YearOverallBegan).HasColumnName("year_overall_began");
            entity.Property(e => e.YearOverallBeganUncertain).HasColumnName("year_overall_began_uncertain");
            entity.Property(e => e.YearOverallEnded).HasColumnName("year_overall_ended");
            entity.Property(e => e.YearOverallEndedUncertain).HasColumnName("year_overall_ended_uncertain");

            entity.HasOne(d => d.Country).WithMany(p => p.GcdPublishers)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_publisher_ibfk_1");
        });

        modelBuilder.Entity<GcdReceivedAward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_received_award")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.AwardId, "gcd_received_award_award_id_a1daee53_fk_gcd_award_id");

            entity.HasIndex(e => e.ContentTypeId, "gcd_received_award_content_type_id_76c10020_fk_django_co");

            entity.HasIndex(e => e.Deleted, "gcd_received_award_deleted_db659429");

            entity.HasIndex(e => e.Modified, "gcd_received_award_modified_dfc45335");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AwardId).HasColumnName("award_id");
            entity.Property(e => e.AwardName)
                .HasMaxLength(255)
                .HasColumnName("award_name");
            entity.Property(e => e.AwardYear).HasColumnName("award_year");
            entity.Property(e => e.AwardYearUncertain).HasColumnName("award_year_uncertain");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.NoAwardName).HasColumnName("no_award_name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");

            entity.HasOne(d => d.Award).WithMany(p => p.GcdReceivedAwards)
                .HasForeignKey(d => d.AwardId)
                .HasConstraintName("gcd_received_award_award_id_a1daee53_fk_gcd_award_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.GcdReceivedAwards)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("gcd_received_award_content_type_id_76c10020_fk_django_co");
        });

        modelBuilder.Entity<GcdRelationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_relation_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReverseType)
                .HasMaxLength(50)
                .HasColumnName("reverse_type");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<GcdReprint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_reprint")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Modified, "gcd_reprint_modified_b8966555");

            entity.HasIndex(e => e.OriginIssueId, "gcd_reprint_origin_issue_id_35ba9bf2_fk_gcd_issue_id");

            entity.HasIndex(e => e.TargetIssueId, "gcd_reprint_target_issue_id_c4c7d013_fk_gcd_issue_id");

            entity.HasIndex(e => e.OriginId, "reprint_from");

            entity.HasIndex(e => e.TargetId, "reprint_to");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OriginId).HasColumnName("origin_id");
            entity.Property(e => e.OriginIssueId).HasColumnName("origin_issue_id");
            entity.Property(e => e.TargetId).HasColumnName("target_id");
            entity.Property(e => e.TargetIssueId).HasColumnName("target_issue_id");

            entity.HasOne(d => d.Origin).WithMany(p => p.GcdReprintOrigins)
                .HasForeignKey(d => d.OriginId)
                .HasConstraintName("gcd_reprint_origin_id_48220c89_fk_gcd_story_id");

            entity.HasOne(d => d.OriginIssue).WithMany(p => p.GcdReprintOriginIssues)
                .HasForeignKey(d => d.OriginIssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_reprint_origin_issue_id_35ba9bf2_fk_gcd_issue_id");

            entity.HasOne(d => d.Target).WithMany(p => p.GcdReprintTargets)
                .HasForeignKey(d => d.TargetId)
                .HasConstraintName("gcd_reprint_target_id_44bd71ce_fk_gcd_story_id");

            entity.HasOne(d => d.TargetIssue).WithMany(p => p.GcdReprintTargetIssues)
                .HasForeignKey(d => d.TargetIssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_reprint_target_issue_id_c4c7d013_fk_gcd_issue_id");
        });

        modelBuilder.Entity<GcdSchool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_school")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SchoolName)
                .HasMaxLength(200)
                .HasColumnName("school_name");
        });

        modelBuilder.Entity<GcdSeries>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_series")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "Bk_Name").HasAnnotation("MySql:IndexPrefixLength", new[] { 150 });

            entity.HasIndex(e => e.HasGallery, "HasGallery");

            entity.HasIndex(e => e.PublisherId, "PubID");

            entity.HasIndex(e => e.YearBegan, "Yr_Began");

            entity.HasIndex(e => e.CountryId, "country_id");

            entity.HasIndex(e => e.Deleted, "deleted");

            entity.HasIndex(e => e.FirstIssueId, "first_issue_id");

            entity.HasIndex(e => e.PublicationTypeId, "gcd_series_49a7a4e1");

            entity.HasIndex(e => e.Modified, "gcd_series_modified_6085f750f3ffa284_uniq");

            entity.HasIndex(e => e.IsCurrent, "is_current");

            entity.HasIndex(e => e.LanguageId, "language_id");

            entity.HasIndex(e => e.LastIssueId, "last_issue_id");

            entity.HasIndex(e => e.SortName, "sort_name");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Binding)
                .HasMaxLength(255)
                .HasColumnName("binding");
            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasColumnName("color");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1901-01-01 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Dimensions)
                .HasMaxLength(255)
                .HasColumnName("dimensions");
            entity.Property(e => e.FirstIssueId).HasColumnName("first_issue_id");
            entity.Property(e => e.Format)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("format");
            entity.Property(e => e.HasAboutComics).HasColumnName("has_about_comics");
            entity.Property(e => e.HasBarcode)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("has_barcode");
            entity.Property(e => e.HasGallery).HasColumnName("has_gallery");
            entity.Property(e => e.HasIndiciaFrequency)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("has_indicia_frequency");
            entity.Property(e => e.HasIndiciaPrinter).HasColumnName("has_indicia_printer");
            entity.Property(e => e.HasIsbn)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("has_isbn");
            entity.Property(e => e.HasIssueTitle).HasColumnName("has_issue_title");
            entity.Property(e => e.HasPublisherCodeNumber).HasColumnName("has_publisher_code_number");
            entity.Property(e => e.HasRating).HasColumnName("has_rating");
            entity.Property(e => e.HasVolume)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("has_volume");
            entity.Property(e => e.IsComicsPublication)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("is_comics_publication");
            entity.Property(e => e.IsCurrent).HasColumnName("is_current");
            entity.Property(e => e.IsSingleton).HasColumnName("is_singleton");
            entity.Property(e => e.IssueCount).HasColumnName("issue_count");
            entity.Property(e => e.LanguageId).HasColumnName("language_id");
            entity.Property(e => e.LastIssueId).HasColumnName("last_issue_id");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1901-01-01 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PaperStock)
                .HasMaxLength(255)
                .HasColumnName("paper_stock");
            entity.Property(e => e.PublicationDates)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("publication_dates");
            entity.Property(e => e.PublicationTypeId).HasColumnName("publication_type_id");
            entity.Property(e => e.PublisherId).HasColumnName("publisher_id");
            entity.Property(e => e.PublishingFormat)
                .HasMaxLength(255)
                .HasColumnName("publishing_format");
            entity.Property(e => e.SortName).HasColumnName("sort_name");
            entity.Property(e => e.TrackingNotes).HasColumnName("tracking_notes");
            entity.Property(e => e.YearBegan).HasColumnName("year_began");
            entity.Property(e => e.YearBeganUncertain).HasColumnName("year_began_uncertain");
            entity.Property(e => e.YearEnded).HasColumnName("year_ended");
            entity.Property(e => e.YearEndedUncertain).HasColumnName("year_ended_uncertain");

            entity.HasOne(d => d.Country).WithMany(p => p.GcdSeries)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_series_ibfk_3");

            entity.HasOne(d => d.FirstIssue).WithMany(p => p.GcdSeriesFirstIssues)
                .HasForeignKey(d => d.FirstIssueId)
                .HasConstraintName("gcd_series_ibfk_5");

            entity.HasOne(d => d.Language).WithMany(p => p.GcdSeries)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_series_ibfk_4");

            entity.HasOne(d => d.LastIssue).WithMany(p => p.GcdSeriesLastIssues)
                .HasForeignKey(d => d.LastIssueId)
                .HasConstraintName("gcd_series_ibfk_6");

            entity.HasOne(d => d.PublicationType).WithMany(p => p.GcdSeries)
                .HasForeignKey(d => d.PublicationTypeId)
                .HasConstraintName("publication_type_id_refs_id_2c468df7974b9efa");

            entity.HasOne(d => d.Publisher).WithMany(p => p.GcdSeries)
                .HasForeignKey(d => d.PublisherId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_series_ibfk_2");
        });

        modelBuilder.Entity<GcdSeriesBond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_series_bond")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.BondTypeId, "gcd_series_bond_1c107711");

            entity.HasIndex(e => e.OriginIssueId, "gcd_series_bond_22a369b6");

            entity.HasIndex(e => e.Reserved, "gcd_series_bond_3b2a5c11");

            entity.HasIndex(e => e.TargetId, "gcd_series_bond_9358c897");

            entity.HasIndex(e => e.TargetIssueId, "gcd_series_bond_b219039");

            entity.HasIndex(e => e.OriginId, "gcd_series_bond_bd654448");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BondTypeId).HasColumnName("bond_type_id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.OriginId).HasColumnName("origin_id");
            entity.Property(e => e.OriginIssueId).HasColumnName("origin_issue_id");
            entity.Property(e => e.Reserved).HasColumnName("reserved");
            entity.Property(e => e.TargetId).HasColumnName("target_id");
            entity.Property(e => e.TargetIssueId).HasColumnName("target_issue_id");

            entity.HasOne(d => d.BondType).WithMany(p => p.GcdSeriesBonds)
                .HasForeignKey(d => d.BondTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("bond_type_id_refs_id_74608925967dca7d");

            entity.HasOne(d => d.Origin).WithMany(p => p.GcdSeriesBondOrigins)
                .HasForeignKey(d => d.OriginId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("origin_id_refs_id_2e5ee5bcc36327a6");

            entity.HasOne(d => d.OriginIssue).WithMany(p => p.GcdSeriesBondOriginIssues)
                .HasForeignKey(d => d.OriginIssueId)
                .HasConstraintName("origin_issue_id_refs_id_14846e21180392d7");

            entity.HasOne(d => d.Target).WithMany(p => p.GcdSeriesBondTargets)
                .HasForeignKey(d => d.TargetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("target_id_refs_id_2e5ee5bcc36327a6");

            entity.HasOne(d => d.TargetIssue).WithMany(p => p.GcdSeriesBondTargetIssues)
                .HasForeignKey(d => d.TargetIssueId)
                .HasConstraintName("target_issue_id_refs_id_14846e21180392d7");
        });

        modelBuilder.Entity<GcdSeriesBondType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_series_bond_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "gcd_series_bond_type_52094d6e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
        });

        modelBuilder.Entity<GcdSeriesPublicationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_series_publication_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "gcd_series_publication_type_52094d6e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
        });

        modelBuilder.Entity<GcdStory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_story")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.IssueId, "IssueID");

            entity.HasIndex(e => e.Modified, "Modified");

            entity.HasIndex(e => e.PageCount, "Pg_Cnt");

            entity.HasIndex(e => e.Deleted, "deleted");

            entity.HasIndex(e => e.NoColors, "no_colors");

            entity.HasIndex(e => e.NoEditing, "no_editing");

            entity.HasIndex(e => e.NoInks, "no_inks");

            entity.HasIndex(e => e.NoLetters, "no_letters");

            entity.HasIndex(e => e.NoPencils, "no_pencils");

            entity.HasIndex(e => e.NoScript, "no_script");

            entity.HasIndex(e => e.PageCountUncertain, "page_count_uncertain");

            entity.HasIndex(e => e.TitleInferred, "title_inferred");

            entity.HasIndex(e => e.TypeId, "type_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Characters).HasColumnName("characters");
            entity.Property(e => e.Colors).HasColumnName("colors");
            entity.Property(e => e.Created)
                .HasDefaultValueSql("'1901-01-01 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Editing).HasColumnName("editing");
            entity.Property(e => e.Feature)
                .HasMaxLength(255)
                .HasColumnName("feature");
            entity.Property(e => e.FirstLine)
                .HasMaxLength(255)
                .HasColumnName("first_line");
            entity.Property(e => e.Genre)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("genre");
            entity.Property(e => e.Inks).HasColumnName("inks");
            entity.Property(e => e.IssueId).HasColumnName("issue_id");
            entity.Property(e => e.JobNumber)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("job_number");
            entity.Property(e => e.Letters).HasColumnName("letters");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'1901-01-01 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("modified");
            entity.Property(e => e.NoColors).HasColumnName("no_colors");
            entity.Property(e => e.NoEditing).HasColumnName("no_editing");
            entity.Property(e => e.NoInks).HasColumnName("no_inks");
            entity.Property(e => e.NoLetters).HasColumnName("no_letters");
            entity.Property(e => e.NoPencils).HasColumnName("no_pencils");
            entity.Property(e => e.NoScript).HasColumnName("no_script");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.PageCount)
                .HasPrecision(10, 3)
                .HasColumnName("page_count");
            entity.Property(e => e.PageCountUncertain).HasColumnName("page_count_uncertain");
            entity.Property(e => e.Pencils).HasColumnName("pencils");
            entity.Property(e => e.ReprintNotes).HasColumnName("reprint_notes");
            entity.Property(e => e.Script).HasColumnName("script");
            entity.Property(e => e.SequenceNumber).HasColumnName("sequence_number");
            entity.Property(e => e.Synopsis).HasColumnName("synopsis");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.TitleInferred).HasColumnName("title_inferred");
            entity.Property(e => e.TypeId).HasColumnName("type_id");

            entity.HasOne(d => d.Issue).WithMany(p => p.GcdStories)
                .HasForeignKey(d => d.IssueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_ibfk_1");

            entity.HasOne(d => d.Type).WithMany(p => p.GcdStories)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_ibfk_2");
        });

        modelBuilder.Entity<GcdStoryCharacter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_story_character")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CharacterId, "gcd_story_character_character_id_eac50f28_fk_gcd_chara");

            entity.HasIndex(e => e.Deleted, "gcd_story_character_deleted_5b1dd00b");

            entity.HasIndex(e => e.GroupUniverseId, "gcd_story_character_group_universe_id_1660ef69_fk_gcd_unive");

            entity.HasIndex(e => e.IsDeath, "gcd_story_character_is_death_a3861547");

            entity.HasIndex(e => e.IsFlashback, "gcd_story_character_is_flashback_3898577a");

            entity.HasIndex(e => e.IsOrigin, "gcd_story_character_is_origin_17b5e411");

            entity.HasIndex(e => e.Modified, "gcd_story_character_modified_6f623117");

            entity.HasIndex(e => e.RoleId, "gcd_story_character_role_id_f7883e66_fk_gcd_character_role_id");

            entity.HasIndex(e => e.StoryId, "gcd_story_character_story_id_13ce6388_fk_gcd_story_id");

            entity.HasIndex(e => e.UniverseId, "gcd_story_character_universe_id_a98c97a2_fk_gcd_universe_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CharacterId).HasColumnName("character_id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.GroupUniverseId).HasColumnName("group_universe_id");
            entity.Property(e => e.IsDeath).HasColumnName("is_death");
            entity.Property(e => e.IsFlashback).HasColumnName("is_flashback");
            entity.Property(e => e.IsOrigin).HasColumnName("is_origin");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.StoryId).HasColumnName("story_id");
            entity.Property(e => e.UniverseId).HasColumnName("universe_id");

            entity.HasOne(d => d.Character).WithMany(p => p.GcdStoryCharacters)
                .HasForeignKey(d => d.CharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_character_character_id_eac50f28_fk_gcd_chara");

            entity.HasOne(d => d.GroupUniverse).WithMany(p => p.GcdStoryCharacterGroupUniverses)
                .HasForeignKey(d => d.GroupUniverseId)
                .HasConstraintName("gcd_story_character_group_universe_id_1660ef69_fk_gcd_unive");

            entity.HasOne(d => d.Role).WithMany(p => p.GcdStoryCharacters)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("gcd_story_character_role_id_f7883e66_fk_gcd_character_role_id");

            entity.HasOne(d => d.Story).WithMany(p => p.GcdStoryCharacters)
                .HasForeignKey(d => d.StoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_character_story_id_13ce6388_fk_gcd_story_id");

            entity.HasOne(d => d.Universe).WithMany(p => p.GcdStoryCharacterUniverses)
                .HasForeignKey(d => d.UniverseId)
                .HasConstraintName("gcd_story_character_universe_id_a98c97a2_fk_gcd_universe_id");
        });

        modelBuilder.Entity<GcdStoryCharacterGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_story_character_group")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => new { e.StorycharacterId, e.GroupId }, "gcd_story_character_grou_storycharacter_id_group__630fc99e_uniq").IsUnique();

            entity.HasIndex(e => e.GroupId, "gcd_story_character_group_group_id_191387e6_fk_gcd_group_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.StorycharacterId).HasColumnName("storycharacter_id");

            entity.HasOne(d => d.Group).WithMany(p => p.GcdStoryCharacterGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_character_group_group_id_191387e6_fk_gcd_group_id");

            entity.HasOne(d => d.Storycharacter).WithMany(p => p.GcdStoryCharacterGroups)
                .HasForeignKey(d => d.StorycharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_character__storycharacter_id_1cab539d_fk_gcd_story");
        });

        modelBuilder.Entity<GcdStoryCredit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_story_credit")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.CreatorId, "gcd_story_credit_creator_id_7c632a78_fk_gcd_creat");

            entity.HasIndex(e => e.CreditTypeId, "gcd_story_credit_credit_type_id_2b1eda8a_fk_gcd_credit_type_id");

            entity.HasIndex(e => e.Deleted, "gcd_story_credit_deleted_5f31a0d2");

            entity.HasIndex(e => e.IsCredited, "gcd_story_credit_is_credited_a0f3090d");

            entity.HasIndex(e => e.IsSigned, "gcd_story_credit_is_signed_da26e307");

            entity.HasIndex(e => e.IsSourced, "gcd_story_credit_is_sourced_b8200d3b");

            entity.HasIndex(e => e.Modified, "gcd_story_credit_modified_1b831920");

            entity.HasIndex(e => e.SignatureId, "gcd_story_credit_signature_id_0c4a25cd_fk_gcd_creat");

            entity.HasIndex(e => e.StoryId, "gcd_story_credit_story_id_7b35c2b5_fk_gcd_story_id");

            entity.HasIndex(e => e.Uncertain, "gcd_story_credit_uncertain_1a69a71c");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.CreatorId).HasColumnName("creator_id");
            entity.Property(e => e.CreditName)
                .HasMaxLength(255)
                .HasColumnName("credit_name");
            entity.Property(e => e.CreditTypeId).HasColumnName("credit_type_id");
            entity.Property(e => e.CreditedAs)
                .HasMaxLength(255)
                .HasColumnName("credited_as");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IsCredited).HasColumnName("is_credited");
            entity.Property(e => e.IsSigned).HasColumnName("is_signed");
            entity.Property(e => e.IsSourced).HasColumnName("is_sourced");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.SignatureId).HasColumnName("signature_id");
            entity.Property(e => e.SignedAs)
                .HasMaxLength(255)
                .HasColumnName("signed_as");
            entity.Property(e => e.SourcedBy)
                .HasMaxLength(255)
                .HasColumnName("sourced_by");
            entity.Property(e => e.StoryId).HasColumnName("story_id");
            entity.Property(e => e.Uncertain).HasColumnName("uncertain");

            entity.HasOne(d => d.Creator).WithMany(p => p.GcdStoryCredits)
                .HasForeignKey(d => d.CreatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_credit_creator_id_7c632a78_fk_gcd_creat");

            entity.HasOne(d => d.CreditType).WithMany(p => p.GcdStoryCredits)
                .HasForeignKey(d => d.CreditTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_credit_credit_type_id_2b1eda8a_fk_gcd_credit_type_id");

            entity.HasOne(d => d.Signature).WithMany(p => p.GcdStoryCredits)
                .HasForeignKey(d => d.SignatureId)
                .HasConstraintName("gcd_story_credit_signature_id_0c4a25cd_fk_gcd_creat");

            entity.HasOne(d => d.Story).WithMany(p => p.GcdStoryCredits)
                .HasForeignKey(d => d.StoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_credit_story_id_7b35c2b5_fk_gcd_story_id");
        });

        modelBuilder.Entity<GcdStoryFeatureLogo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_story_feature_logo")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FeaturelogoId, "gcd_story_feature_lo_featurelogo_id_169a1ec3_fk_gcd_featu");

            entity.HasIndex(e => new { e.StoryId, e.FeaturelogoId }, "gcd_story_feature_logo_story_id_featurelogo_id_5a345f8c_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FeaturelogoId).HasColumnName("featurelogo_id");
            entity.Property(e => e.StoryId).HasColumnName("story_id");

            entity.HasOne(d => d.Featurelogo).WithMany(p => p.GcdStoryFeatureLogos)
                .HasForeignKey(d => d.FeaturelogoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_feature_lo_featurelogo_id_169a1ec3_fk_gcd_featu");

            entity.HasOne(d => d.Story).WithMany(p => p.GcdStoryFeatureLogos)
                .HasForeignKey(d => d.StoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_feature_logo_story_id_41377b84_fk_gcd_story_id");
        });

        modelBuilder.Entity<GcdStoryFeatureObject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_story_feature_object")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.FeatureId, "gcd_story_feature_object_feature_id_fea4dbf9_fk_gcd_feature_id");

            entity.HasIndex(e => new { e.StoryId, e.FeatureId }, "gcd_story_feature_object_story_id_feature_id_e2de9a4d_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FeatureId).HasColumnName("feature_id");
            entity.Property(e => e.StoryId).HasColumnName("story_id");

            entity.HasOne(d => d.Feature).WithMany(p => p.GcdStoryFeatureObjects)
                .HasForeignKey(d => d.FeatureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_feature_object_feature_id_fea4dbf9_fk_gcd_feature_id");

            entity.HasOne(d => d.Story).WithMany(p => p.GcdStoryFeatureObjects)
                .HasForeignKey(d => d.StoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gcd_story_feature_object_story_id_0393a434_fk_gcd_story_id");
        });

        modelBuilder.Entity<GcdStoryType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_story_type")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Name, "name").IsUnique();

            entity.HasIndex(e => e.SortCode, "sort_code").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.SortCode).HasColumnName("sort_code");
        });

        modelBuilder.Entity<GcdUniverse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("gcd_universe")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Deleted, "gcd_universe_deleted_ff60af35");

            entity.HasIndex(e => e.Designation, "gcd_universe_designation_c44a1a75");

            entity.HasIndex(e => e.Modified, "gcd_universe_modified_c5d3bbeb");

            entity.HasIndex(e => e.Multiverse, "gcd_universe_multiverse_33bbb4b5");

            entity.HasIndex(e => e.Name, "gcd_universe_name_6d727a81");

            entity.HasIndex(e => e.VerseId, "gcd_universe_verse_id_b2ae21fa_fk_gcd_multiverse_id");

            entity.HasIndex(e => e.YearFirstPublished, "gcd_universe_year_first_published_deedfad5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Created)
                .HasMaxLength(6)
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Designation).HasColumnName("designation");
            entity.Property(e => e.Modified)
                .HasMaxLength(6)
                .HasColumnName("modified");
            entity.Property(e => e.Multiverse).HasColumnName("multiverse");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.VerseId).HasColumnName("verse_id");
            entity.Property(e => e.YearFirstPublished).HasColumnName("year_first_published");
            entity.Property(e => e.YearFirstPublishedUncertain).HasColumnName("year_first_published_uncertain");

            entity.HasOne(d => d.Verse).WithMany(p => p.GcdUniverses)
                .HasForeignKey(d => d.VerseId)
                .HasConstraintName("gcd_universe_verse_id_b2ae21fa_fk_gcd_multiverse_id");
        });

        modelBuilder.Entity<StddataCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stddata_country")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Code, "code_2").IsUnique();

            entity.HasIndex(e => e.Name, "country").HasAnnotation("MySql:IndexPrefixLength", new[] { 50 });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<StddataDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stddata_date")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Month, "stddata_date_7abe03e0");

            entity.HasIndex(e => e.Year, "stddata_date_b2d73278");

            entity.HasIndex(e => e.Day, "stddata_date_ec444b56");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Day)
                .HasMaxLength(2)
                .HasColumnName("day");
            entity.Property(e => e.DayUncertain).HasColumnName("day_uncertain");
            entity.Property(e => e.Month)
                .HasMaxLength(2)
                .HasColumnName("month");
            entity.Property(e => e.MonthUncertain).HasColumnName("month_uncertain");
            entity.Property(e => e.Year)
                .HasMaxLength(4)
                .HasColumnName("year");
            entity.Property(e => e.YearUncertain).HasColumnName("year_uncertain");
        });

        modelBuilder.Entity<StddataLanguage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stddata_language")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Code, "code_2").IsUnique();

            entity.HasIndex(e => e.Name, "language").HasAnnotation("MySql:IndexPrefixLength", new[] { 10 });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NativeName)
                .HasMaxLength(255)
                .HasColumnName("native_name");
        });

        modelBuilder.Entity<StddataScript>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("stddata_script")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Code, "code").IsUnique();

            entity.HasIndex(e => e.Number, "number").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(4)
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasColumnName("name");
            entity.Property(e => e.Number).HasColumnName("number");
        });

        modelBuilder.Entity<TaggitTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("taggit_tag")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Slug, "slug").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Slug)
                .HasMaxLength(100)
                .HasColumnName("slug");
        });

        modelBuilder.Entity<TaggitTaggeditem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("taggit_taggeditem")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.TagId, "taggit_taggeditem_3747b463");

            entity.HasIndex(e => e.ObjectId, "taggit_taggeditem_829e37fd");

            entity.HasIndex(e => new { e.ContentTypeId, e.ObjectId }, "taggit_taggeditem_content_type_id_3c99b32018cc9d40_idx");

            entity.HasIndex(e => new { e.ContentTypeId, e.ObjectId, e.TagId }, "taggit_taggeditem_content_type_id_object_id_tag_id_4bb97a8e_uniq").IsUnique();

            entity.HasIndex(e => e.ContentTypeId, "taggit_taggeditem_e4470c6e");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentTypeId).HasColumnName("content_type_id");
            entity.Property(e => e.ObjectId).HasColumnName("object_id");
            entity.Property(e => e.TagId).HasColumnName("tag_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.TaggitTaggeditems)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("taggit_taggeditem_ibfk_1");

            entity.HasOne(d => d.Tag).WithMany(p => p.TaggitTaggeditems)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("taggit_taggeditem_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
