using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Riwi_LinkUp.Models;
using Backend_Riwi_LinkUp.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Backend_Riwi_LinkUp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Coder> Coders { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }

        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageLevel> LanguageLevels { get; set; }
        public DbSet<TechnicalSkill> TechnicalSkills { get; set; }
        public DbSet<TechnicalSkillLevel> TechnicalSkillLevels { get; set; }
        public DbSet<CoderSoftSkill> CoderSoftSkills { get; set; }
        public DbSet<CoderLanguage> CoderLanguages { get; set; }
        public DbSet<CoderTechnicalSkill> CoderTechnicalSkills { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data   
            // RoleSeeder.Seed(modelBuilder);
            // SectorSeeder.Seed(modelBuilder);
            // UserSeeder.Seed(modelBuilder);
            // GenderSeeder.Seed(modelBuilder);
            // ClanSeeder.Seed(modelBuilder);
            // SoftSkillSeeder.Seed(modelBuilder);
            // LanguageSeeder.Seed(modelBuilder);
            // TechnicalSkillSeeder.Seed(modelBuilder);
            // CoderSeeder.Seed(modelBuilder);
            // LanguageLevelSeeder.Seed(modelBuilder);
            // CoderSoftSkillSeeder.Seed(modelBuilder);
            // TechnicalSkillLevelSeeder.Seed(modelBuilder);
            // CoderLanguageSeeder.Seed(modelBuilder);
            // CoderTechnicalSkillSeeder.Seed(modelBuilder);

            // Configure many-to-many relationship for CoderSoftSkill
            modelBuilder.Entity<CoderSoftSkill>()
                .HasKey(css => new { css.CoderId, css.SoftSkillId });

            modelBuilder.Entity<CoderSoftSkill>()
                .HasOne(css => css.Coder)
                .WithMany(c => c.CoderSoftSkills)
                .HasForeignKey(css => css.CoderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CoderSoftSkill>()
                .HasOne(css => css.SoftSkill)
                .WithMany(ss => ss.CoderSoftSkills)
                .HasForeignKey(css => css.SoftSkillId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CoderTechnicalSkill>()
                .HasKey(cts => new { cts.CoderId, cts.TechnicalSkillId });

            modelBuilder.Entity<CoderTechnicalSkill>()
                .HasOne(cts => cts.Coder)
                .WithMany(c => c.CoderTechnicalSkills)
                .HasForeignKey(cts => cts.CoderId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<CoderTechnicalSkill>()
                .HasOne(cts => cts.TechnicalSkill)
                .WithMany(ts => ts.CoderTechnicalSkills)
                .HasForeignKey(cts => cts.TechnicalSkillId)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CoderTechnicalSkill>()
                .HasOne(cts => cts.TechnicalSkillLevel)
                .WithMany(tsl => tsl.CoderTechnicalSkills)
                .HasForeignKey(cts => cts.TechnicalSkillLevelId);

            modelBuilder.Entity<CoderLanguage>()
                .HasKey(cl => new { cl.CoderId, cl.LanguageId });

            modelBuilder.Entity<CoderLanguage>()
                .HasOne(cl => cl.Coder)
                .WithMany(c => c.CoderLanguages)
                .HasForeignKey(cl => cl.CoderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CoderLanguage>()
                .HasOne(cl => cl.Language)
                .WithMany(l => l.CoderLanguages)
                .HasForeignKey(cl => cl.LanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CoderLanguage>()
                .HasOne(cl => cl.LanguageLevel)
                .WithMany(ll => ll.CoderLanguages)
                .HasForeignKey(cl => cl.LanguageLevelId);

        }
    }
}