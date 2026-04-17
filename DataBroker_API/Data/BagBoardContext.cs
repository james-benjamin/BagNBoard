using System;
using System.Collections.Generic;
using DataBroker_API.Model.BagBoardSQL;
using Microsoft.EntityFrameworkCore;

namespace DataBroker_API.Data;

public partial class BagBoardContext : DbContext
{
    public BagBoardContext()
    {
    }

    public BagBoardContext(DbContextOptions<BagBoardContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Artist> Artists { get; set; }

    public virtual DbSet<ArtistRefComic> ArtistRefComics { get; set; }

    public virtual DbSet<Comic> Comics { get; set; }

    public virtual DbSet<ComicRefIssue> ComicRefIssues { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<Variant> Variants { get; set; }

    public virtual DbSet<VirtualBox> VirtualBoxes { get; set; }

    public virtual DbSet<VirtualBoxRefComic> VirtualBoxRefComics { get; set; }

    public virtual DbSet<VirtualBoxRefVariant> VirtualBoxRefVariants { get; set; }

    public virtual DbSet<Writer> Writers { get; set; }

    public virtual DbSet<WriterRefComic> WriterRefComics { get; set; }

    //Database services need to be started when application hasn't been used in a while
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=> optionsBuilder.UseSqlServer("Server=MalignSoul;Database=Bag_Board;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Artist__3213E83FCFBCFD4A");

            entity.ToTable("Artist");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(60)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(60)
                .HasColumnName("last_name");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<ArtistRefComic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Artist_Ref_Comic");

            entity.Property(e => e.ArtistId).HasColumnName("artist_id");
            entity.Property(e => e.ComicId).HasColumnName("comic_id");
        });

        modelBuilder.Entity<Comic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comic__3213E83FF5D20045");

            entity.ToTable("Comic");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BarCode).HasColumnName("bar_code");
            entity.Property(e => e.ComicImage)
                .HasMaxLength(255)
                .HasColumnName("comic_image");
            entity.Property(e => e.CoverArtist).HasColumnName("cover_artist");
            entity.Property(e => e.CoverImage)
                .HasMaxLength(60)
                .HasColumnName("cover_image");
            entity.Property(e => e.DateAdded).HasColumnName("date_added");
            entity.Property(e => e.Notes)
                .HasMaxLength(300)
                .HasColumnName("notes");
            entity.Property(e => e.PrintRun)
                .HasMaxLength(55)
                .HasColumnName("print_run");
            entity.Property(e => e.PublisherId).HasColumnName("publisher_id");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Writer).HasColumnName("writer");
        });

        modelBuilder.Entity<ComicRefIssue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Comic_Ref_Issue");

            entity.Property(e => e.ComicId).HasColumnName("comic_id");
            entity.Property(e => e.IssueId).HasColumnName("issue_id");
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Publishe__3213E83F7C2F45C4");

            entity.ToTable("Publisher");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Company)
                .HasMaxLength(60)
                .HasColumnName("company");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<Variant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Variant__3213E83F6E311AFA");

            entity.ToTable("Variant");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BarCodes).HasColumnName("bar_codes");
            entity.Property(e => e.ComicId).HasColumnName("comic_id");
            entity.Property(e => e.CoverArtist).HasColumnName("cover_artist");
            entity.Property(e => e.CoverImage)
                .HasMaxLength(60)
                .HasColumnName("cover_image");
            entity.Property(e => e.DateAdded).HasColumnName("date_added");
            entity.Property(e => e.Notes)
                .HasMaxLength(300)
                .HasColumnName("notes");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.Type).HasColumnName("type");

            entity.HasOne(d => d.Comic).WithMany(p => p.Variants)
                .HasForeignKey(d => d.ComicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Variant__comic_i__03F0984C");
        });

        modelBuilder.Entity<VirtualBox>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VirtualB__3213E83F0348CE39");

            entity.ToTable("VirtualBox");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ComicCount).HasColumnName("comic_count");
            entity.Property(e => e.DateCreated).HasColumnName("date_created");
            entity.Property(e => e.HeroImage)
                .HasMaxLength(60)
                .HasColumnName("hero_image");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");
        });

        modelBuilder.Entity<VirtualBoxRefComic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VirtualBox_Ref_Comic");

            entity.Property(e => e.ComicId).HasColumnName("comic_id");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.VirtualBoxId).HasColumnName("virtual_box_id");
        });

        modelBuilder.Entity<VirtualBoxRefVariant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VirtualBox_Ref_Variant");

            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.VariantId).HasColumnName("variant_id");
            entity.Property(e => e.VirtualBoxId).HasColumnName("virtual_box_id");
        });

        modelBuilder.Entity<Writer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Writer__3213E83F98F8306E");

            entity.ToTable("Writer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(60)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(60)
                .HasColumnName("last_name");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<WriterRefComic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Writer_Ref_Comic");

            entity.Property(e => e.ComicId).HasColumnName("comic_id");
            entity.Property(e => e.WriterId).HasColumnName("writer_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
