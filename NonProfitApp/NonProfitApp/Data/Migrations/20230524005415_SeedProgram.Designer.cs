﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NonProfitApp.Data;

#nullable disable

namespace NonProfitApp.Data.Migrations
{
    [DbContext(typeof(NonprofitDbContext))]
    [Migration("20230524005415_SeedProgram")]
    partial class SeedProgram
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NonProfitApp.Models.Channel", b =>
                {
                    b.Property<int>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChannelId"), 1L, 1);

                    b.Property<string>("ChannelType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ChannelId");

                    b.ToTable("Channels");

                    b.HasData(
                        new
                        {
                            ChannelId = 1,
                            ChannelType = "Facebook"
                        },
                        new
                        {
                            ChannelId = 2,
                            ChannelType = "Direct Mail"
                        },
                        new
                        {
                            ChannelId = 3,
                            ChannelType = "Email"
                        },
                        new
                        {
                            ChannelId = 4,
                            ChannelType = "Event"
                        },
                        new
                        {
                            ChannelId = 5,
                            ChannelType = "Search"
                        });
                });

            modelBuilder.Entity("NonProfitApp.Models.Donation", b =>
                {
                    b.Property<int>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonationId"), 1L, 1);

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<decimal>("DonationAmount")
                        .HasColumnType("decimal(9,2)");

                    b.Property<DateTime>("DonationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<int?>("FundraiserId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.HasKey("DonationId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("DonorId");

                    b.HasIndex("FundraiserId");

                    b.HasIndex("ProgramId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("NonProfitApp.Models.Donor", b =>
                {
                    b.Property<int>("DonorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DonorId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Company")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("DonorId");

                    b.ToTable("Donors");

                    b.HasData(
                        new
                        {
                            DonorId = 1,
                            City = "Seattle",
                            Email = "j.smith@gmail.com",
                            FirstName = "Jess",
                            LastName = "Smith",
                            Phone = "256-555-9874",
                            State = "WA",
                            StreetAddress = "4548 South St",
                            Zip = "98109"
                        },
                        new
                        {
                            DonorId = 2,
                            City = "Renton",
                            Email = "cristy@gmail.com",
                            FirstName = "Cristy",
                            LastName = "Johnson",
                            Phone = "255-879-5555",
                            State = "WA",
                            StreetAddress = "300 Long St",
                            Zip = "98056"
                        },
                        new
                        {
                            DonorId = 3,
                            City = "Bellingham",
                            Email = "cjames@yahoo.com",
                            FirstName = "Carl",
                            LastName = "James",
                            Phone = "256-548-9910",
                            State = "WA",
                            StreetAddress = "98451 J Place W",
                            Zip = "98897"
                        },
                        new
                        {
                            DonorId = 4,
                            City = "Buffalo",
                            Email = "jmsanders@hotmail.com",
                            FirstName = "John",
                            LastName = "Sanders",
                            Phone = "888-555-1010",
                            State = "NY",
                            StreetAddress = "46757 College Way",
                            Zip = "26544"
                        });
                });

            modelBuilder.Entity("NonProfitApp.Models.Fundraiser", b =>
                {
                    b.Property<int>("FundraiserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FundraiserId"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FundraiserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("FundraiserId");

                    b.ToTable("Fundraisers");
                });

            modelBuilder.Entity("NonProfitApp.Models.FundraiserChannel", b =>
                {
                    b.Property<int>("FundraiserChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FundraiserChannelId"), 1L, 1);

                    b.Property<int>("ChannelId")
                        .HasColumnType("int");

                    b.Property<int>("FundraiserId")
                        .HasColumnType("int");

                    b.HasKey("FundraiserChannelId");

                    b.HasIndex("ChannelId");

                    b.HasIndex("FundraiserId");

                    b.ToTable("FundraiserChannels");
                });

            modelBuilder.Entity("NonProfitApp.Models.FundraiserProgram", b =>
                {
                    b.Property<int>("FundraiserProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FundraiserProgramId"), 1L, 1);

                    b.Property<int>("FundraiserId")
                        .HasColumnType("int");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.HasKey("FundraiserProgramId");

                    b.HasIndex("FundraiserId");

                    b.HasIndex("ProgramId");

                    b.ToTable("FundraiserPrograms");
                });

            modelBuilder.Entity("NonProfitApp.Models.OrgProgram", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ProgramId");

                    b.ToTable("OrgPrograms");

                    b.HasData(
                        new
                        {
                            ProgramId = 100,
                            Name = "Sponsorship"
                        },
                        new
                        {
                            ProgramId = 101,
                            Name = "Scholarship"
                        },
                        new
                        {
                            ProgramId = 102,
                            Name = "General"
                        },
                        new
                        {
                            ProgramId = 103,
                            Name = "Community Outreach"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NonProfitApp.Models.Donation", b =>
                {
                    b.HasOne("NonProfitApp.Models.Channel", "Channel")
                        .WithMany("Donations")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NonProfitApp.Models.Donor", "Donor")
                        .WithMany("Donations")
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NonProfitApp.Models.Fundraiser", "Fundraiser")
                        .WithMany("Donations")
                        .HasForeignKey("FundraiserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NonProfitApp.Models.OrgProgram", "OrgProgram")
                        .WithMany("Donations")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("Donor");

                    b.Navigation("Fundraiser");

                    b.Navigation("OrgProgram");
                });

            modelBuilder.Entity("NonProfitApp.Models.FundraiserChannel", b =>
                {
                    b.HasOne("NonProfitApp.Models.Channel", "Channel")
                        .WithMany("FundraiserChannels")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NonProfitApp.Models.Fundraiser", "Fundraiser")
                        .WithMany("FundraiserChannels")
                        .HasForeignKey("FundraiserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Channel");

                    b.Navigation("Fundraiser");
                });

            modelBuilder.Entity("NonProfitApp.Models.FundraiserProgram", b =>
                {
                    b.HasOne("NonProfitApp.Models.Fundraiser", "Fundraiser")
                        .WithMany("FundraiserPrograms")
                        .HasForeignKey("FundraiserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NonProfitApp.Models.OrgProgram", "OrgProgram")
                        .WithMany("FundraiserPrograms")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fundraiser");

                    b.Navigation("OrgProgram");
                });

            modelBuilder.Entity("NonProfitApp.Models.Channel", b =>
                {
                    b.Navigation("Donations");

                    b.Navigation("FundraiserChannels");
                });

            modelBuilder.Entity("NonProfitApp.Models.Donor", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("NonProfitApp.Models.Fundraiser", b =>
                {
                    b.Navigation("Donations");

                    b.Navigation("FundraiserChannels");

                    b.Navigation("FundraiserPrograms");
                });

            modelBuilder.Entity("NonProfitApp.Models.OrgProgram", b =>
                {
                    b.Navigation("Donations");

                    b.Navigation("FundraiserPrograms");
                });
#pragma warning restore 612, 618
        }
    }
}
