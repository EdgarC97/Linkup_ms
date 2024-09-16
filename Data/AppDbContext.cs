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
        public DbSet<Clan> Clans { get; set; }
        public DbSet<SoftSkill> SoftSkills { get; set; }

        public DbSet<Language> Languages { get; set; }
        public DbSet<LanguageLevel> LanguageLevels { get; set; }
        public DbSet<TechnicalSkill> TechnicalSkills { get; set; }
        public DbSet<TechnicalSkillLevel> TechnicalSkillLevels { get; set; }
        public DbSet<CoderSoftSkill> CoderSoftSkills { get; set; }
        public DbSet<CoderLanguage> CoderLanguages { get; set; }
        public DbSet<CoderTechnicalSkill> CoderTechnicalSkills { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data   
            RoleSeeder.Seed(modelBuilder);
            SectorSeeder.Seed(modelBuilder);
            GenderSeeder.Seed(modelBuilder);
            ClanSeeder.Seed(modelBuilder);
            SoftSkillSeeder.Seed(modelBuilder);
            LanguageSeeder.Seed(modelBuilder);
            TechnicalSkillSeeder.Seed(modelBuilder);
            LanguageLevelSeeder.Seed(modelBuilder);
            UserSeeder.Seed(modelBuilder);
            CoderSeeder.Seed(modelBuilder);
            TechnicalSkillLevelSeeder.Seed(modelBuilder);
            CoderSoftSkillSeeder.Seed(modelBuilder);
            CoderLanguageSeeder.Seed(modelBuilder);
            CoderTechnicalSkillSeeder.Seed(modelBuilder);

            // Configure many-to-many relationship for CoderSoftSkill
            modelBuilder.Entity<CoderLanguage>(entity =>
    {
        entity.HasKey(e => e.Id);

        entity.Property(e => e.Id)
            .UseIdentityColumn();

        entity.HasOne(d => d.Coder)
            .WithMany(c => c.CoderLanguages)
            .HasForeignKey(d => d.CoderId)
            .OnDelete(DeleteBehavior.Cascade);

        entity.HasOne(d => d.Language)
            .WithMany(l => l.CoderLanguages)
            .HasForeignKey(d => d.LanguageId)
            .OnDelete(DeleteBehavior.Restrict);

        entity.HasOne(d => d.LanguageLevel)
            .WithMany(ll => ll.CoderLanguages)
            .HasForeignKey(d => d.LanguageLevelId)
            .OnDelete(DeleteBehavior.Restrict);
    });

            // Configuración para CoderTechnicalSkill (actualizada)
            modelBuilder.Entity<CoderTechnicalSkill>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .UseIdentityColumn();

                entity.HasOne(d => d.Coder)
                    .WithMany(c => c.CoderTechnicalSkills)
                    .HasForeignKey(d => d.CoderId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(d => d.TechnicalSkill)
                    .WithMany(ts => ts.CoderTechnicalSkills)
                    .HasForeignKey(d => d.TechnicalSkillId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.TechnicalSkillLevel)
                    .WithMany(tsl => tsl.CoderTechnicalSkills)
                    .HasForeignKey(d => d.TechnicalSkillLevelId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Mantén la configuración de CoderSoftSkill como estaba
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
        }
    }
}