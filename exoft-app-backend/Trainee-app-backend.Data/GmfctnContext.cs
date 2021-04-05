using System;
using Microsoft.EntityFrameworkCore;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data
{
    public class GmfctnContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }


        public GmfctnContext(DbContextOptions<GmfctnContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievement>().ToTable("Achievements");
        }
    }
}
