using MedEquipment.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MedEquipment.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }

        public DatabaseContext() : base()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            optionsBuilder.UseNpgsql(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Equipment>().ToTable("Equipment");
            modelBuilder.Entity<RepairRequest>().ToTable("RepairRequests");
        }
    }
}
