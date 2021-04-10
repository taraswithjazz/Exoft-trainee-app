using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Configurations
{
    public class UserCfg : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> modelBuilder)
        {
            modelBuilder.ToTable("Users");
            modelBuilder.HasIndex(e => e.Email).IsUnique();
            modelBuilder.HasIndex(e => e.UserName).IsUnique();
        }
    }
}
