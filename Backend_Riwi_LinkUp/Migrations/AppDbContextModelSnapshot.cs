﻿// <auto-generated />
using System;
using Backend_Riwi_LinkUp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backend_Riwi_LinkUp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Clan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

<<<<<<< HEAD
                    b.ToTable("Clan");
=======
                    b.ToTable("Clans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "berners lee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ritchie"
                        },
                        new
                        {
                            Id = 3,
                            Name = "gates"
                        },
                        new
                        {
                            Id = 4,
                            Name = "jeff bezzos"
                        });
>>>>>>> e222f350f71a57a43498fd03c950fa0937da118c
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Coder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ClanId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<int>("GenderId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("UrlImage")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("ClanId");

                    b.HasIndex("GenderId");

                    b.ToTable("Coders");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.CoderLanguage", b =>
                {
                    b.Property<int>("CoderId")
                        .HasColumnType("integer");

                    b.Property<int>("LanguageId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("LanguageLevelId")
                        .HasColumnType("integer");

                    b.HasKey("CoderId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("LanguageLevelId");

                    b.ToTable("CoderLanguages");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.CoderSoftSkill", b =>
                {
                    b.Property<int>("CoderId")
                        .HasColumnType("integer");

                    b.Property<int>("SoftSkillId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.HasKey("CoderId", "SoftSkillId");

                    b.HasIndex("SoftSkillId");

                    b.ToTable("CoderSoftSkills");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.CoderTechnicalSkill", b =>
                {
                    b.Property<int>("CoderId")
                        .HasColumnType("integer");

                    b.Property<int>("TechnicalSkillId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("TechnicalSkillLevelId")
                        .HasColumnType("integer");

                    b.HasKey("CoderId", "TechnicalSkillId");

                    b.HasIndex("TechnicalSkillId");

                    b.HasIndex("TechnicalSkillLevelId");

                    b.ToTable("CoderTechnicalSkills");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.LanguageLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("LanguageLevels");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.SoftSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("SoftSkills");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.TechnicalSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("TechnicalSkills");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.TechnicalSkillLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("TechnicalSkillLevels");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("SectorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("SectorId");

                    b.ToTable("Users");
<<<<<<< HEAD
=======

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 15, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "jackeline.cardona@example.com",
                            IsConfirmed = true,
                            Name = "jackeline cardona",
                            PasswordHash = new byte[] { 72, 162, 167, 105, 85, 33, 40, 32, 59, 18, 61, 236, 27, 241, 239, 227, 252, 44, 200, 134, 32, 247, 130, 118, 121, 113, 186, 51, 172, 76, 86, 231, 132, 133, 117, 225, 239, 33, 60, 151, 163, 13, 67, 76, 68, 225, 30, 117, 123, 107, 186, 100, 115, 244, 122, 171, 211, 245, 227, 60, 113, 106, 243, 87 },
                            PasswordSalt = new byte[] { 78, 221, 79, 204, 153, 117, 120, 164, 153, 19, 185, 60, 106, 180, 81, 46, 18, 106, 179, 89, 42, 40, 76, 89, 240, 148, 95, 198, 39, 231, 5, 240, 159, 29, 252, 24, 189, 155, 120, 136, 100, 129, 222, 179, 110, 69, 59, 90, 137, 94, 201, 44, 71, 198, 92, 132, 103, 244, 209, 224, 72, 145, 128, 116, 220, 148, 166, 138, 190, 139, 107, 24, 172, 175, 158, 207, 208, 34, 250, 96, 23, 58, 6, 242, 85, 47, 55, 88, 118, 171, 113, 236, 254, 153, 112, 228, 89, 200, 76, 204, 153, 91, 38, 179, 179, 106, 47, 43, 157, 237, 49, 221, 138, 174, 49, 38, 203, 47, 99, 235, 216, 104, 7, 193, 55, 191, 161, 215 },
                            PhoneNumber = "1234567890",
                            RoleId = 1,
                            SectorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 3, 10, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "jane.smith@example.com",
                            IsConfirmed = true,
                            Name = "jane smith",
                            PasswordHash = new byte[] { 4, 231, 202, 210, 160, 250, 16, 117, 243, 189, 23, 242, 20, 90, 226, 64, 173, 65, 3, 179, 161, 16, 18, 18, 51, 238, 123, 78, 225, 188, 236, 136, 99, 187, 199, 191, 201, 170, 102, 9, 200, 177, 84, 52, 127, 86, 226, 3, 207, 232, 3, 119, 89, 120, 57, 113, 110, 32, 98, 168, 214, 217, 239, 192 },
                            PasswordSalt = new byte[] { 29, 44, 13, 103, 146, 232, 166, 102, 134, 176, 133, 74, 92, 18, 165, 163, 73, 122, 39, 160, 94, 135, 172, 76, 30, 22, 73, 60, 162, 168, 209, 28, 105, 169, 124, 222, 190, 73, 237, 76, 70, 111, 213, 244, 211, 0, 190, 183, 90, 10, 77, 184, 111, 146, 56, 221, 245, 65, 200, 71, 179, 53, 25, 132, 180, 9, 118, 211, 164, 142, 0, 209, 80, 41, 92, 55, 101, 43, 180, 49, 253, 210, 86, 166, 86, 112, 251, 24, 17, 95, 236, 205, 39, 158, 82, 177, 69, 147, 39, 147, 212, 23, 93, 76, 84, 160, 86, 125, 17, 2, 56, 93, 82, 108, 125, 98, 121, 87, 190, 110, 201, 24, 153, 94, 17, 209, 123, 213 },
                            PhoneNumber = "2345678901",
                            RoleId = 2,
                            SectorId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 5, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "alice.johnson@example.com",
                            IsConfirmed = true,
                            Name = "alice johnson",
                            PasswordHash = new byte[] { 104, 125, 129, 150, 21, 142, 198, 54, 134, 180, 87, 49, 73, 203, 105, 91, 219, 198, 116, 180, 91, 46, 193, 142, 43, 235, 90, 182, 112, 217, 153, 194, 15, 50, 253, 121, 186, 159, 203, 237, 59, 43, 118, 83, 96, 113, 243, 16, 178, 114, 240, 162, 7, 105, 45, 200, 57, 245, 236, 148, 39, 109, 9, 143 },
                            PasswordSalt = new byte[] { 223, 107, 231, 22, 89, 114, 132, 198, 86, 227, 75, 6, 219, 41, 238, 96, 162, 239, 14, 2, 239, 222, 0, 80, 200, 240, 228, 139, 105, 73, 169, 154, 98, 136, 171, 126, 175, 44, 18, 67, 82, 168, 191, 181, 126, 134, 100, 210, 104, 118, 102, 72, 4, 225, 130, 245, 121, 192, 229, 151, 109, 128, 91, 145, 247, 163, 249, 151, 236, 45, 168, 125, 96, 234, 194, 152, 153, 171, 92, 218, 89, 118, 115, 119, 171, 176, 46, 125, 5, 200, 61, 254, 81, 186, 69, 31, 205, 111, 230, 45, 45, 50, 30, 0, 130, 98, 118, 232, 165, 136, 247, 147, 12, 65, 192, 2, 238, 197, 75, 141, 24, 50, 9, 84, 1, 52, 229, 161 },
                            PhoneNumber = "3456789012",
                            RoleId = 2,
                            SectorId = 4
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 5, 20, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "bob.williams@example.com",
                            IsConfirmed = true,
                            Name = "bob williams",
                            PasswordHash = new byte[] { 101, 171, 179, 173, 33, 129, 195, 147, 5, 131, 214, 115, 254, 41, 119, 254, 26, 27, 134, 209, 188, 31, 185, 171, 138, 191, 188, 91, 132, 154, 234, 16, 13, 47, 122, 14, 241, 155, 82, 39, 83, 100, 187, 47, 23, 24, 2, 115, 216, 222, 241, 88, 37, 94, 208, 47, 30, 64, 133, 113, 166, 28, 65, 84 },
                            PasswordSalt = new byte[] { 38, 179, 183, 130, 146, 101, 192, 39, 186, 118, 141, 105, 7, 134, 171, 203, 166, 136, 39, 54, 145, 49, 67, 200, 19, 216, 14, 103, 104, 199, 227, 85, 29, 181, 74, 199, 213, 0, 140, 22, 193, 136, 170, 157, 110, 91, 167, 189, 105, 182, 71, 187, 121, 44, 134, 162, 199, 197, 176, 224, 49, 20, 255, 62, 174, 247, 251, 123, 58, 51, 42, 66, 36, 30, 22, 93, 106, 239, 210, 158, 54, 135, 49, 216, 250, 72, 121, 222, 221, 97, 215, 13, 246, 200, 202, 88, 41, 163, 242, 50, 78, 40, 220, 77, 82, 170, 184, 37, 88, 219, 199, 118, 131, 80, 41, 140, 163, 38, 1, 71, 218, 83, 25, 98, 38, 65, 74, 228 },
                            PhoneNumber = "4567890123",
                            RoleId = 2,
                            SectorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 6, 25, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "charlie.brown@example.com",
                            IsConfirmed = true,
                            Name = "charlie brown",
                            PasswordHash = new byte[] { 155, 211, 180, 133, 26, 237, 134, 55, 71, 251, 167, 27, 214, 137, 180, 185, 8, 73, 215, 21, 202, 188, 217, 190, 67, 129, 224, 139, 175, 136, 111, 83, 54, 47, 125, 71, 235, 93, 6, 8, 128, 85, 208, 128, 180, 88, 190, 141, 11, 235, 190, 79, 58, 118, 69, 32, 158, 10, 29, 251, 71, 92, 13, 132 },
                            PasswordSalt = new byte[] { 190, 213, 12, 94, 120, 102, 244, 48, 113, 151, 224, 255, 163, 65, 206, 118, 193, 188, 226, 52, 28, 218, 155, 53, 105, 202, 183, 191, 188, 88, 147, 187, 136, 43, 59, 202, 248, 21, 210, 190, 196, 194, 52, 198, 184, 70, 21, 242, 249, 200, 24, 115, 69, 81, 78, 228, 168, 148, 131, 187, 41, 41, 200, 49, 146, 137, 167, 170, 62, 73, 90, 39, 206, 81, 131, 70, 178, 152, 236, 5, 217, 234, 29, 49, 248, 23, 71, 80, 4, 243, 114, 207, 181, 143, 174, 132, 25, 218, 144, 77, 16, 251, 107, 230, 149, 143, 169, 31, 192, 181, 139, 116, 168, 141, 92, 127, 237, 178, 26, 237, 104, 41, 40, 180, 139, 253, 2, 149 },
                            PhoneNumber = "5678901234",
                            RoleId = 2,
                            SectorId = 2
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 7, 10, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "diana.clark@example.com",
                            IsConfirmed = true,
                            Name = "diana clark",
                            PasswordHash = new byte[] { 43, 28, 146, 13, 236, 187, 193, 104, 69, 86, 41, 203, 196, 254, 143, 3, 126, 249, 16, 119, 150, 119, 176, 201, 174, 6, 251, 14, 155, 14, 40, 251, 125, 246, 26, 82, 50, 52, 70, 156, 146, 234, 105, 18, 220, 116, 144, 167, 113, 202, 131, 199, 38, 110, 102, 238, 50, 8, 189, 77, 209, 37, 87, 73 },
                            PasswordSalt = new byte[] { 72, 132, 251, 238, 5, 149, 169, 24, 126, 90, 0, 11, 110, 132, 139, 216, 5, 46, 219, 34, 130, 138, 17, 174, 176, 3, 180, 33, 182, 88, 241, 18, 231, 229, 122, 225, 36, 159, 146, 2, 117, 213, 91, 6, 16, 163, 60, 115, 170, 35, 157, 209, 6, 220, 193, 84, 62, 251, 236, 183, 100, 3, 198, 187, 138, 217, 125, 127, 245, 3, 200, 17, 56, 202, 240, 107, 144, 194, 219, 75, 112, 111, 87, 117, 211, 203, 13, 144, 214, 243, 61, 247, 211, 199, 190, 126, 78, 207, 245, 28, 159, 7, 251, 247, 244, 218, 176, 169, 124, 43, 203, 63, 119, 201, 64, 103, 191, 76, 110, 33, 98, 141, 0, 244, 103, 52, 143, 251 },
                            PhoneNumber = "6789012345",
                            RoleId = 2,
                            SectorId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 8, 15, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "edward.davis@example.com",
                            IsConfirmed = true,
                            Name = "edward davis",
                            PasswordHash = new byte[] { 206, 37, 35, 107, 82, 108, 206, 192, 90, 18, 12, 130, 213, 14, 153, 17, 118, 8, 242, 50, 67, 7, 197, 139, 247, 161, 139, 144, 35, 43, 112, 169, 186, 70, 27, 206, 136, 69, 142, 161, 59, 83, 3, 19, 116, 77, 50, 105, 43, 125, 21, 32, 103, 148, 131, 247, 83, 214, 255, 32, 131, 96, 234, 220 },
                            PasswordSalt = new byte[] { 112, 26, 180, 196, 182, 216, 129, 46, 68, 186, 38, 230, 27, 214, 140, 148, 202, 39, 150, 21, 225, 148, 23, 186, 1, 210, 145, 78, 65, 93, 219, 153, 246, 9, 255, 182, 45, 107, 251, 64, 174, 7, 63, 59, 55, 181, 236, 181, 125, 119, 186, 211, 172, 233, 15, 247, 25, 109, 181, 184, 114, 169, 160, 98, 201, 248, 220, 102, 125, 180, 121, 124, 234, 148, 144, 147, 109, 3, 86, 104, 212, 190, 225, 7, 196, 92, 38, 94, 148, 161, 190, 231, 97, 149, 54, 108, 117, 95, 186, 4, 133, 210, 17, 144, 196, 240, 65, 71, 144, 237, 218, 173, 46, 128, 183, 107, 209, 217, 48, 58, 209, 143, 165, 212, 97, 94, 184, 64 },
                            PhoneNumber = "7890123456",
                            RoleId = 2,
                            SectorId = 5
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 9, 10, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "fiona.evans@example.com",
                            IsConfirmed = true,
                            Name = "fiona evans",
                            PasswordHash = new byte[] { 33, 137, 181, 122, 219, 110, 92, 35, 247, 219, 63, 152, 186, 38, 230, 68, 195, 76, 183, 98, 148, 12, 166, 32, 151, 0, 14, 28, 210, 85, 229, 219, 210, 136, 36, 158, 244, 188, 184, 186, 35, 13, 44, 243, 3, 57, 184, 16, 71, 68, 194, 38, 110, 167, 222, 140, 210, 232, 126, 68, 5, 132, 204, 232 },
                            PasswordSalt = new byte[] { 178, 114, 19, 157, 94, 123, 232, 230, 235, 238, 143, 113, 74, 70, 240, 195, 244, 252, 4, 84, 198, 8, 37, 30, 205, 70, 134, 2, 171, 252, 172, 181, 77, 39, 161, 143, 11, 45, 211, 3, 138, 42, 169, 107, 177, 129, 116, 148, 144, 103, 230, 246, 148, 165, 2, 27, 17, 93, 16, 10, 71, 151, 166, 39, 187, 80, 217, 130, 91, 190, 39, 205, 255, 143, 15, 56, 58, 89, 50, 195, 232, 45, 171, 230, 37, 3, 48, 93, 36, 213, 36, 198, 48, 217, 22, 27, 60, 31, 83, 221, 124, 36, 73, 42, 188, 43, 133, 5, 41, 98, 4, 89, 247, 242, 124, 154, 240, 197, 47, 108, 117, 181, 117, 199, 72, 210, 217, 231 },
                            PhoneNumber = "8901234567",
                            RoleId = 2,
                            SectorId = 2
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 10, 5, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "george.fisher@example.com",
                            IsConfirmed = true,
                            Name = "george fisher",
                            PasswordHash = new byte[] { 111, 199, 17, 124, 2, 105, 65, 182, 174, 183, 241, 163, 0, 252, 141, 176, 178, 189, 172, 188, 66, 88, 113, 195, 72, 65, 70, 242, 78, 204, 218, 135, 130, 203, 222, 235, 132, 120, 231, 249, 5, 28, 192, 217, 76, 201, 64, 226, 131, 33, 171, 34, 141, 253, 170, 130, 68, 74, 75, 149, 58, 82, 11, 219 },
                            PasswordSalt = new byte[] { 134, 24, 42, 163, 103, 241, 158, 145, 181, 173, 247, 200, 140, 163, 225, 21, 14, 53, 161, 80, 231, 182, 108, 206, 137, 39, 224, 72, 36, 22, 160, 12, 17, 124, 120, 124, 185, 122, 108, 13, 203, 34, 140, 2, 181, 126, 175, 78, 49, 22, 31, 63, 161, 246, 215, 200, 193, 118, 83, 243, 110, 200, 93, 53, 62, 249, 28, 181, 97, 22, 47, 61, 152, 181, 169, 182, 10, 0, 1, 226, 238, 143, 28, 189, 155, 81, 64, 200, 136, 140, 212, 53, 180, 255, 128, 246, 239, 144, 181, 68, 1, 64, 139, 126, 106, 111, 238, 34, 24, 160, 14, 123, 103, 162, 121, 194, 124, 252, 21, 202, 217, 82, 33, 88, 204, 209, 166, 104 },
                            PhoneNumber = "9012345678",
                            RoleId = 2,
                            SectorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 11, 1, 1, 17, 51, 0, DateTimeKind.Utc),
                            Email = "hannah.green@example.com",
                            IsConfirmed = true,
                            Name = "hannah green",
                            PasswordHash = new byte[] { 240, 57, 161, 52, 28, 24, 88, 179, 36, 155, 177, 81, 7, 152, 247, 109, 156, 144, 253, 228, 190, 184, 98, 21, 127, 9, 6, 246, 254, 165, 25, 32, 104, 155, 62, 129, 146, 50, 64, 99, 6, 233, 136, 48, 117, 79, 249, 55, 141, 14, 53, 171, 131, 96, 88, 187, 50, 125, 41, 6, 191, 188, 116, 57 },
                            PasswordSalt = new byte[] { 246, 63, 137, 206, 178, 24, 141, 199, 252, 218, 110, 214, 183, 223, 108, 128, 177, 164, 53, 147, 97, 70, 134, 171, 53, 108, 60, 84, 254, 124, 164, 252, 161, 148, 7, 6, 111, 243, 35, 239, 243, 54, 154, 113, 245, 142, 179, 52, 38, 18, 165, 231, 17, 44, 253, 101, 2, 143, 130, 30, 62, 112, 48, 202, 210, 189, 195, 213, 79, 59, 41, 252, 53, 49, 139, 243, 39, 49, 144, 110, 38, 154, 75, 185, 17, 207, 62, 148, 211, 140, 254, 168, 58, 25, 30, 227, 112, 13, 153, 233, 33, 155, 153, 64, 131, 30, 238, 39, 41, 197, 102, 172, 37, 187, 143, 227, 233, 117, 216, 62, 62, 73, 190, 8, 172, 247, 93, 226 },
                            PhoneNumber = "0123456789",
                            RoleId = 2,
                            SectorId = 3
                        });
>>>>>>> e222f350f71a57a43498fd03c950fa0937da118c
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Coder", b =>
                {
                    b.HasOne("Backend_Riwi_LinkUp.Models.Clan", "Clan")
                        .WithMany("Coders")
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_Riwi_LinkUp.Models.Gender", "Gender")
                        .WithMany("Coders")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clan");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.CoderLanguage", b =>
                {
                    b.HasOne("Backend_Riwi_LinkUp.Models.Coder", "Coder")
                        .WithMany("CoderLanguages")
                        .HasForeignKey("CoderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_Riwi_LinkUp.Models.Language", "Language")
                        .WithMany("CoderLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Backend_Riwi_LinkUp.Models.LanguageLevel", "LanguageLevel")
                        .WithMany("CoderLanguages")
                        .HasForeignKey("LanguageLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coder");

                    b.Navigation("Language");

                    b.Navigation("LanguageLevel");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.CoderSoftSkill", b =>
                {
                    b.HasOne("Backend_Riwi_LinkUp.Models.Coder", "Coder")
                        .WithMany("CoderSoftSkills")
                        .HasForeignKey("CoderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_Riwi_LinkUp.Models.SoftSkill", "SoftSkill")
                        .WithMany("CoderSoftSkills")
                        .HasForeignKey("SoftSkillId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Coder");

                    b.Navigation("SoftSkill");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.CoderTechnicalSkill", b =>
                {
                    b.HasOne("Backend_Riwi_LinkUp.Models.Coder", "Coder")
                        .WithMany("CoderTechnicalSkills")
                        .HasForeignKey("CoderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_Riwi_LinkUp.Models.TechnicalSkill", "TechnicalSkill")
                        .WithMany("CoderTechnicalSkills")
                        .HasForeignKey("TechnicalSkillId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Backend_Riwi_LinkUp.Models.TechnicalSkillLevel", "TechnicalSkillLevel")
                        .WithMany("CoderTechnicalSkills")
                        .HasForeignKey("TechnicalSkillLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coder");

                    b.Navigation("TechnicalSkill");

                    b.Navigation("TechnicalSkillLevel");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.User", b =>
                {
                    b.HasOne("Backend_Riwi_LinkUp.Models.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend_Riwi_LinkUp.Models.Sector", "Sector")
                        .WithMany("Users")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Clan", b =>
                {
                    b.Navigation("Coders");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Coder", b =>
                {
                    b.Navigation("CoderLanguages");

                    b.Navigation("CoderSoftSkills");

                    b.Navigation("CoderTechnicalSkills");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Gender", b =>
                {
                    b.Navigation("Coders");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Language", b =>
                {
                    b.Navigation("CoderLanguages");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.LanguageLevel", b =>
                {
                    b.Navigation("CoderLanguages");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.Sector", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.SoftSkill", b =>
                {
                    b.Navigation("CoderSoftSkills");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.TechnicalSkill", b =>
                {
                    b.Navigation("CoderTechnicalSkills");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.TechnicalSkillLevel", b =>
                {
                    b.Navigation("CoderTechnicalSkills");
                });

            modelBuilder.Entity("Backend_Riwi_LinkUp.Models.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
