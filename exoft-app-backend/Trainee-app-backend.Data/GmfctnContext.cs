using System;
using Microsoft.EntityFrameworkCore;
using Trainee_app_backend.Data.Entities;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data
{
    public class GmfctnContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<User> Users { get; set; }


        public GmfctnContext(DbContextOptions<GmfctnContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievement>().ToTable("Achievements");
            modelBuilder.Entity<Achievement>().HasIndex(e => e.Name).IsUnique();
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasIndex(e => e.Email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(e => e.UserName).IsUnique();
        }
    }
}
