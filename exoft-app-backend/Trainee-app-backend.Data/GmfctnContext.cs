using System;
using Microsoft.EntityFrameworkCore;
using Trainee_app_backend.Data.Configurations;
using Trainee_app_backend.Data.Entities;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data
{
    public class GmfctnContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }


        public GmfctnContext(DbContextOptions<GmfctnContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AchievementCfg());
            modelBuilder.ApplyConfiguration(new UserCfg());
            modelBuilder.ApplyConfiguration(new RoleCfg());
            modelBuilder.ApplyConfiguration(new UserRoleCfg());
            modelBuilder.ApplyConfiguration(new UserAchievementCfg());
        }
    }
}
