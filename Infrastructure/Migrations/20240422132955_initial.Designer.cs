﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240422132955_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasData(
                        new
                        {
                            Id = "AAEF2C4F-DED7-4B1A-ADD3-9A3448B9E9E0",
                            AccessFailedCount = 0,
                            Address = "Calle 9 N° 2946",
                            City = "Berazategui",
                            ConcurrencyStamp = "e5051399-3985-4c2f-8913-2f70183cf6d3",
                            Email = "bravo.jose.luis18@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Jose",
                            LastName = "Bravo",
                            LockoutEnabled = false,
                            NormalizedEmail = "BRAVO.JOSE.LUIS18@GMAIL.COM",
                            NormalizedUserName = "BRAVO.JOSE.LUIS18@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFYPU6bw9KuMcdGPfXvQV2ccsH/5rNT9tNtywDpkgcoPiNf7kuQ99KXIDv+WfKWNfg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c0755a50-3f5e-440f-80b7-36e16e1eba00",
                            TwoFactorEnabled = false,
                            UserName = "bravo.jose.luis18@gmail.com"
                        },
                        new
                        {
                            Id = "FD9CB11E-76D6-4DEE-AAA3-921E983F36CA",
                            AccessFailedCount = 0,
                            Address = "Calle Los Andes N° 3850",
                            City = "Bernal",
                            ConcurrencyStamp = "ad34d53a-f992-47b5-b7ed-46596c3efae8",
                            Email = "alanleandrovargas03@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Alan",
                            LastName = "Vargas",
                            LockoutEnabled = false,
                            NormalizedEmail = "ALANLEANDROVARGAS03@gmail.com",
                            NormalizedUserName = "ALANLEANDROVARGAS03@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEL7zu2Cx1qhhCtrQxzWs1fILHORSpJgLp33nFiUiI4RjHdK6Ai4A1v44+4jFan5cgQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c61e7a9e-ff7d-47ba-a49c-4ff6dfb3413f",
                            TwoFactorEnabled = false,
                            UserName = "alanleandrovargas03@gmail.com"
                        },
                        new
                        {
                            Id = "1D98B435-C2C4-44D7-B1B2-AB229DE2ACED",
                            AccessFailedCount = 0,
                            Address = "Calle Grecia N°1234",
                            City = "Florencio Varela",
                            ConcurrencyStamp = "cd40ea2f-902c-4acc-a696-132a4e6d4594",
                            Email = "luciaoses1997@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Lucia",
                            LastName = "Oses",
                            LockoutEnabled = false,
                            NormalizedEmail = "LUCIAOSES1997@GMAIL.COM",
                            NormalizedUserName = "LUCIAOSES1997@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHyORvBmlXCVctDhWUst7S5dsOvGtUFE/c6F51mffmVu/l1+5xRSu3/gESzYngBWTg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cca20d58-0a6a-45aa-be3c-dc3cb5b4cf13",
                            TwoFactorEnabled = false,
                            UserName = "luciaoses1997@gmail.com"
                        },
                        new
                        {
                            Id = "3D0F1848-5354-4CED-A125-525218044370",
                            AccessFailedCount = 0,
                            Address = "Viena n°1057",
                            City = "Florencio Varela",
                            ConcurrencyStamp = "8e69154b-4597-424e-9da4-bc76bca68856",
                            Email = "diegorolon01@outlook.com",
                            EmailConfirmed = true,
                            FirstName = "Diego",
                            LastName = "Rolon",
                            LockoutEnabled = false,
                            NormalizedEmail = "DIEGOROLON01@OUTLOOK.COM",
                            NormalizedUserName = "DIEGOROLON01@OUTLOOK.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECnNGC/TN8O/hdMkSMp+EKiQLm/P2z9mjy8wbnXSNaI8EvYZyxnDkAet1d8Md4C1jw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "98a6ec59-6078-4263-acea-cd2e7a2fb760",
                            TwoFactorEnabled = false,
                            UserName = "diegorolon01@outlook.com"
                        },
                        new
                        {
                            Id = "19BB7F59-3372-433F-B343-00E75953D3A3",
                            AccessFailedCount = 0,
                            Address = "Adolfo Alsina 1238",
                            City = "Florencio Varela",
                            ConcurrencyStamp = "cfcbd0c0-e274-45b5-b21c-febdb720d917",
                            Email = "francopalacio03@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Franco",
                            LastName = "Palacio",
                            LockoutEnabled = false,
                            NormalizedEmail = "FRANCOPALACIO03@GMAIL.COM",
                            NormalizedUserName = "FRANCOPALACIO03@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEFSs/qDT6Ip9fAFk+maKgN6XOZJJ1fBrmNu+V4XefWfsCkihqAfeIDOv2+um+BAXKQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "14c819b3-31b1-46f7-8e99-3c81c40348ed",
                            TwoFactorEnabled = false,
                            UserName = "francopalacio03@gmail.com"
                        });
                });

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

                    b.HasData(
                        new
                        {
                            Id = "DCD3F190-A5F0-4A75-8E2C-095CBED0B551",
                            ConcurrencyStamp = "1",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "3A6F1076-6B34-4251-83D9-E2C71519F402",
                            ConcurrencyStamp = "2",
                            Name = "Refugio",
                            NormalizedName = "REFUGIO"
                        },
                        new
                        {
                            Id = "05456319-A1AD-4AF9-B68B-7B6FD4161A7F",
                            ConcurrencyStamp = "3",
                            Name = "Miembro",
                            NormalizedName = "MIEMBRO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasData(
                        new
                        {
                            UserId = "AAEF2C4F-DED7-4B1A-ADD3-9A3448B9E9E0",
                            RoleId = "DCD3F190-A5F0-4A75-8E2C-095CBED0B551"
                        },
                        new
                        {
                            UserId = "FD9CB11E-76D6-4DEE-AAA3-921E983F36CA",
                            RoleId = "DCD3F190-A5F0-4A75-8E2C-095CBED0B551"
                        },
                        new
                        {
                            UserId = "1D98B435-C2C4-44D7-B1B2-AB229DE2ACED",
                            RoleId = "DCD3F190-A5F0-4A75-8E2C-095CBED0B551"
                        },
                        new
                        {
                            UserId = "3D0F1848-5354-4CED-A125-525218044370",
                            RoleId = "DCD3F190-A5F0-4A75-8E2C-095CBED0B551"
                        },
                        new
                        {
                            UserId = "19BB7F59-3372-433F-B343-00E75953D3A3",
                            RoleId = "DCD3F190-A5F0-4A75-8E2C-095CBED0B551"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Entities.ApplicationUser", null)
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

                    b.HasOne("Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}