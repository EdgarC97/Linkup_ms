using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Backend_Riwi_LinkUp.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Data
{
    // Context class for interacting with the database
    public class AppDbContext : DbContext
    {
        // Constructor accepting DbContextOptions
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets representing tables in the database
        public DbSet<Coder> Coders { get; set; } // Coders table
        public DbSet<Gender> Genders { get; set; } // Genders table
        public DbSet<Clan> Clans { get; set; } // Clans table
        public DbSet<SoftSkill> SoftSkills { get; set; } // SoftSkills table
        public DbSet<Language> Languages { get; set; } // Languages table
        public DbSet<LanguageLevel> LanguageLevels { get; set; } // LanguageLevels table
        public DbSet<TechnicalSkill> TechnicalSkills { get; set; } // TechnicalSkills table
        public DbSet<TechnicalSkillLevel> TechnicalSkillLevels { get; set; } // TechnicalSkillLevels table
        public DbSet<CoderSoftSkill> CoderSoftSkills { get; set; } // CoderSoftSkills table
        public DbSet<CoderLanguage> CoderLanguages { get; set; } // CoderLanguages table
        public DbSet<CoderTechnicalSkill> CoderTechnicalSkills { get; set; } // CoderTechnicalSkills table
        public DbSet<User> Users { get; set; } // Users table
        public DbSet<Sector> Sectors { get; set; } // Sectors table
        public DbSet<UserRole> UserRoles { get; set; } // UserRoles table


        // Configures the model and seeds initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seed initial data for various entities
            RoleSeeder.Seed(modelBuilder); // Seed roles
            SectorSeeder.Seed(modelBuilder); // Seed sectors
            GenderSeeder.Seed(modelBuilder); // Seed genders
            ClanSeeder.Seed(modelBuilder); // Seed clans
            SoftSkillSeeder.Seed(modelBuilder); // Seed soft skills
            LanguageSeeder.Seed(modelBuilder); // Seed languages
            TechnicalSkillSeeder.Seed(modelBuilder); // Seed technical skills
            LanguageLevelSeeder.Seed(modelBuilder); // Seed language levels
            TechnicalSkillLevelSeeder.Seed(modelBuilder); // Seed technical skill levels
            UserSeeder.Seed(modelBuilder); // Seed users
            CoderSeeder.Seed(modelBuilder); // Seed coders
            CoderSoftSkillSeeder.Seed(modelBuilder); // Seed coder soft skills
            CoderLanguageSeeder.Seed(modelBuilder); // Seed coder languages
            CoderTechnicalSkillSeeder.Seed(modelBuilder); // Seed coder technical skills


            // Configure the many-to-many relationship for CoderLanguage
            modelBuilder.Entity<CoderLanguage>(entity =>
    {
        entity.HasKey(e => e.Id); // Primary key configuration
        entity.Property(e => e.Id).UseIdentityColumn(); // Auto-increment for Id

        entity.HasOne(d => d.Coder) // Relationship to Coder
            .WithMany(c => c.CoderLanguages)
            .HasForeignKey(d => d.CoderId)
            .OnDelete(DeleteBehavior.Cascade); // Cascade delete

        entity.HasOne(d => d.Language) // Relationship to Language
            .WithMany(l => l.CoderLanguages)
            .HasForeignKey(d => d.LanguageId)
            .OnDelete(DeleteBehavior.Restrict); // Restrict delete

        entity.HasOne(d => d.LanguageLevel) // Relationship to LanguageLevel
            .WithMany(ll => ll.CoderLanguages)
            .HasForeignKey(d => d.LanguageLevelId)
            .OnDelete(DeleteBehavior.Restrict); // Restrict delete
    });

            // Configure the many-to-many relationship for CoderTechnicalSkill
            modelBuilder.Entity<CoderTechnicalSkill>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary key configuration
                entity.Property(e => e.Id).UseIdentityColumn(); // Auto-increment for Id

                entity.HasOne(d => d.Coder) // Relationship to Coder
                    .WithMany(c => c.CoderTechnicalSkills)
                    .HasForeignKey(d => d.CoderId)
                    .OnDelete(DeleteBehavior.Cascade); // Cascade delete

                entity.HasOne(d => d.TechnicalSkill) // Relationship to TechnicalSkill
                    .WithMany(ts => ts.CoderTechnicalSkills)
                    .HasForeignKey(d => d.TechnicalSkillId)
                    .OnDelete(DeleteBehavior.Restrict); // Restrict delete

                entity.HasOne(d => d.TechnicalSkillLevel) // Relationship to TechnicalSkillLevel
                    .WithMany(tsl => tsl.CoderTechnicalSkills)
                    .HasForeignKey(d => d.TechnicalSkillLevelId)
                    .OnDelete(DeleteBehavior.Restrict); // Restrict delete
            });

            // Configure the many-to-many relationship for CoderSoftSkill
            modelBuilder.Entity<CoderSoftSkill>()
                .HasKey(css => new { css.CoderId, css.SoftSkillId }); // Composite primary key

            modelBuilder.Entity<CoderSoftSkill>()
                .HasOne(css => css.Coder) // Relationship to Coder
                .WithMany(c => c.CoderSoftSkills)
                .HasForeignKey(css => css.CoderId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete

            modelBuilder.Entity<CoderSoftSkill>()
                .HasOne(css => css.SoftSkill) // Relationship to SoftSkill
                .WithMany(ss => ss.CoderSoftSkills)
                .HasForeignKey(css => css.SoftSkillId)
                .OnDelete(DeleteBehavior.Restrict); // Restrict delete
        }
    }
}