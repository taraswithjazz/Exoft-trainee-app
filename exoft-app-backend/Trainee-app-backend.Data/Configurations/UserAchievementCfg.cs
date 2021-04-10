using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Configurations
{
    public class UserAchievementCfg : IEntityTypeConfiguration<UserAchievement>
    {
        public void Configure(EntityTypeBuilder<UserAchievement> modelBuilder)
        {
            modelBuilder.ToTable("UserAchievements");

            modelBuilder.HasKey(t => new { t.UserId, t.AchievementId });
            modelBuilder
                .HasOne(t => t.User)
                .WithMany(b => b.Achievements)
                .HasForeignKey(t => t.UserId);
            modelBuilder
                .HasOne(t => t.Achievement)
                .WithMany(b => b.UserAchievements)
                .HasForeignKey(t => t.AchievementId);
        }
    }
}
