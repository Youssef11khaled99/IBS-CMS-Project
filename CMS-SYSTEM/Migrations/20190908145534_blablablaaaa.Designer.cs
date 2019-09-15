﻿// <auto-generated />
using System;
using CMS_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CMS_SYSTEM.Migrations
{
    [DbContext(typeof(CMSPROJECT3Context))]
    [Migration("20190908145534_blablablaaaa")]
    partial class blablablaaaa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetRoleClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetRoles", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("([NormalizedName] IS NOT NULL)");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUserLogins", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUserRoles", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUserTokens", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUsers", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("([NormalizedUserName] IS NOT NULL)");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BaseWidgetId")
                        .HasColumnName("BaseWidgetID");

                    b.Property<string>("Body")
                        .IsRequired();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsValid");

                    b.Property<int>("Lid")
                        .HasColumnName("LID");

                    b.Property<string>("MetaDescription")
                        .IsRequired();

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Pid")
                        .HasColumnName("PID");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("Lid");

                    b.ToTable("Content");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.Languages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDefault");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.UserWebsites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("DomainUrl");

                    b.Property<string>("WebsiteName")
                        .HasMaxLength(50);

                    b.Property<bool>("isDeleted");

                    b.HasKey("Id");

                    b.ToTable("User_Websites");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.Widget", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BaseId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("HtmlBody")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("(N'')");

                    b.Property<bool?>("IsActive");

                    b.Property<bool?>("IsPublished");

                    b.Property<bool?>("IsValid");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("WidgetOrdinal");

                    b.Property<int>("WidgetTypeId")
                        .HasColumnName("WidgetTypeID");

                    b.HasKey("Id");

                    b.HasIndex("WidgetTypeId");

                    b.ToTable("Widget");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.WidgetParent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Pid")
                        .HasColumnName("PID");

                    b.Property<int>("UserWebsitesId")
                        .HasColumnName("UserWebsitesID");

                    b.Property<int>("Wid")
                        .HasColumnName("WID");

                    b.HasKey("Id");

                    b.HasIndex("UserWebsitesId");

                    b.HasIndex("Wid");

                    b.ToTable("Widget_Parent");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.WidgetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Widget_Type");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetRoleClaims", b =>
                {
                    b.HasOne("CMS_SYSTEM.Models.AspNetRoles", "Role")
                        .WithMany("AspNetRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUserClaims", b =>
                {
                    b.HasOne("CMS_SYSTEM.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUserLogins", b =>
                {
                    b.HasOne("CMS_SYSTEM.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUserRoles", b =>
                {
                    b.HasOne("CMS_SYSTEM.Models.AspNetRoles", "Role")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CMS_SYSTEM.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.AspNetUserTokens", b =>
                {
                    b.HasOne("CMS_SYSTEM.Models.AspNetUsers", "User")
                        .WithMany("AspNetUserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.Content", b =>
                {
                    b.HasOne("CMS_SYSTEM.Models.Languages", "L")
                        .WithMany("Content")
                        .HasForeignKey("Lid")
                        .HasConstraintName("FK_Content_Languages");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.Widget", b =>
                {
                    b.HasOne("CMS_SYSTEM.Models.WidgetType", "WidgetType")
                        .WithMany("Widget")
                        .HasForeignKey("WidgetTypeId")
                        .HasConstraintName("FK_Widget_Widget_Type");
                });

            modelBuilder.Entity("CMS_SYSTEM.Models.WidgetParent", b =>
                {
                    b.HasOne("CMS_SYSTEM.Models.UserWebsites", "UserWebsites")
                        .WithMany("WidgetParent")
                        .HasForeignKey("UserWebsitesId")
                        .HasConstraintName("FK_Widget_Parent_User_Websites");

                    b.HasOne("CMS_SYSTEM.Models.Widget", "W")
                        .WithMany("WidgetParent")
                        .HasForeignKey("Wid")
                        .HasConstraintName("FK_Widget_Parent_Widget");
                });
#pragma warning restore 612, 618
        }
    }
}
