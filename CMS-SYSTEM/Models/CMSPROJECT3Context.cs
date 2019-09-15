using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CMS_SYSTEM.Models
{
    public partial class CMSPROJECT3Context : DbContext
    {
        public CMSPROJECT3Context()
        {
        }

        public CMSPROJECT3Context(DbContextOptions<CMSPROJECT3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<UserWebsites> UserWebsites { get; set; }
        public virtual DbSet<Widget> Widget { get; set; }
        public virtual DbSet<WidgetParent> WidgetParent { get; set; }
        public virtual DbSet<WidgetType> WidgetType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.0.66;Database=CMS-PROJECT3;user id =ibs_internship;password=P@$$w0rd;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseWidgetId).HasColumnName("BaseWidgetID");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.MetaDescription).IsRequired();

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.L)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.Lid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Content_Languages");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserWebsites>(entity =>
            {
                entity.ToTable("User_Websites");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WebsiteName).HasMaxLength(50);
            });

            modelBuilder.Entity<Widget>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HtmlBody)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.WidgetTypeId).HasColumnName("WidgetTypeID");

                entity.HasOne(d => d.WidgetType)
                    .WithMany(p => p.Widget)
                    .HasForeignKey(d => d.WidgetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Widget_Widget_Type");
            });

            modelBuilder.Entity<WidgetParent>(entity =>
            {
                entity.ToTable("Widget_Parent");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.UserWebsitesId).HasColumnName("UserWebsitesID");

                entity.Property(e => e.Wid).HasColumnName("WID");

                entity.HasOne(d => d.UserWebsites)
                    .WithMany(p => p.WidgetParent)
                    .HasForeignKey(d => d.UserWebsitesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Widget_Parent_User_Websites");

                entity.HasOne(d => d.W)
                    .WithMany(p => p.WidgetParent)
                    .HasForeignKey(d => d.Wid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Widget_Parent_Widget");
            });

            modelBuilder.Entity<WidgetType>(entity =>
            {
                entity.ToTable("Widget_Type");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });
        }
    }
}
