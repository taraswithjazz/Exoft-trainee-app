using System;
using Microsoft.EntityFrameworkCore;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data
{
    public class gmfctnContext : DbContext
    {
        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<Achievement> Achievements { get; set; }


        public gmfctnContext(DbContextOptions<gmfctnContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseEntity>().ToTable("BaseEntities");
            modelBuilder.Entity<Achievement>().ToTable("Achievements");
        }
    }
}
