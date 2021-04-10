using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Configurations
{
    public class RoleCfg : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> modelBuilder)
        {
            modelBuilder.ToTable("Roles");
        }
    }
}
