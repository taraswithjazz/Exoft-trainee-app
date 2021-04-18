using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.Configurations
{
    public class UserRoleCfg : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> modelBuilder)
        {
            modelBuilder.ToTable("UserRoles");

            modelBuilder.HasKey(bc => new { bc.UserId, bc.RoleId });
            modelBuilder
                .HasOne(bc => bc.User)
                .WithMany(b => b.Roles)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder
                .HasOne(bc => bc.Role)
                .WithMany(b => b.UserRoles)
                .HasForeignKey(bc => bc.RoleId);
        }
    }
}
