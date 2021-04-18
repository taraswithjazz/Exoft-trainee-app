using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Configurations
{
    public class AchievementCfg : IEntityTypeConfiguration<Achievement>
    {
        public void Configure(EntityTypeBuilder<Achievement> modelBuilder)
        {
            modelBuilder.ToTable("Achievements");
            modelBuilder.HasIndex(e => e.Name).IsUnique();
        }
    }
}
