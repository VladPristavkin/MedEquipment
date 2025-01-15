using MedEquipment.Models;
using MedEquipment.Utils;
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
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            optionsBuilder.UseSqlite(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Equipment>().ToTable("Equipment");
            modelBuilder.Entity<RepairRequest>().ToTable("RepairRequests");

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FullName = "Иван Иванов", Login = HashHelper.HashString("doctor1"), Password = HashHelper.HashString("password1"), Department = "Кардиология", Role = Role.Doctor },
                new User { Id = 2, FullName = "Петр Петров", Login = HashHelper.HashString("sysadmin1"), Password = HashHelper.HashString("password2"), Department = "IT", Role = Role.SysAdmin },
                new User { Id = 3, FullName = "Анна Смирнова", Login = HashHelper.HashString("chief1"), Password = HashHelper.HashString("password3"), Department = "Хирургия", Role = Role.Chief }
            );

            modelBuilder.Entity<Equipment>().HasData(
                new Equipment { Id = 1, Name = "УЗИ аппарат", Model = "GE Voluson", SerialNumber = "12345", LastServiceDate = new DateOnly(2023, 10, 1), EquipmentStatus = EquipmentStatus.Repaired, UserId = 1 },
                new Equipment { Id = 2, Name = "Рентген аппарат", Model = "Philips", SerialNumber = "67890", LastServiceDate = new DateOnly(2023, 8, 15), EquipmentStatus = EquipmentStatus.Repaired, UserId = 3 }
            );

            modelBuilder.Entity<RepairRequest>().HasData(
                new RepairRequest { Id = 1, EquipmentId = 1, UserId = 1, Description = "Проблема с экраном", CreatedDate = new DateOnly(2024, 1, 10), Status = RequestStatus.Open },
                new RepairRequest { Id = 2, EquipmentId = 2, UserId = 3, Description = "Не работает переключатель режимов", CreatedDate = new DateOnly(2024, 1, 5), Status = RequestStatus.InProgress }
            );
        }
    }
}
