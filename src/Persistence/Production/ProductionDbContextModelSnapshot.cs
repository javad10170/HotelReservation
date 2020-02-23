﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.Production;

namespace Persistence.Production
{
    [DbContext(typeof(ProductionDbContext))]
    partial class ProductionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.Entities.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Domain.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("IsAdult")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("EGN")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Domain.Entities.HotelRoom", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsEmpty")
                        .HasColumnType("boolean");

                    b.Property<decimal>("PriceForAdults")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PriceForChildren")
                        .HasColumnType("numeric");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("integer");

                    b.Property<int>("RoomType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("Domain.Entities.HotelRoomImage", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<string>("HotelRoomId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("HotelRoomImages");
                });

            modelBuilder.Entity("Domain.Entities.Reservation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<bool>("AllInclusive")
                        .HasColumnType("boolean");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IncludeFood")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ReservedForDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ReservedRoomId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<DateTime>("ReservedUntilDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("ReservedRoomId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Domain.Entities.UserReservation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ReservationId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character(36)")
                        .IsFixedLength(true)
                        .HasMaxLength(36)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersReservations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("character varying(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character varying(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("character varying(36)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("character varying(36)");

                    b.Property<string>("RoleId")
                        .HasColumnType("character varying(36)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("character varying(36)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Entities.Employee", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", "User")
                        .WithOne("Employee")
                        .HasForeignKey("Domain.Entities.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.HotelRoom", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.HotelRoomImage", b =>
                {
                    b.HasOne("Domain.Entities.HotelRoom", "HotelRoom")
                        .WithMany("RoomImages")
                        .HasForeignKey("HotelRoomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Reservation", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.HotelRoom", "ReservedRoom")
                        .WithMany("Reservations")
                        .HasForeignKey("ReservedRoomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.UserReservation", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Reservation", "Reservation")
                        .WithMany("UsersReservations")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", "User")
                        .WithMany("UsersReservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}