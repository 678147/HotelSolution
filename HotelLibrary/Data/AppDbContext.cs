using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using HotelLibrary.Models;
using Microsoft.EntityFrameworkCore;


namespace HotelLibrary.DBContex
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }
        public AppDbContext() { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:hoteldb9.database.windows.net,1433;Initial Catalog=HotelDB99;Persist Security Info=False;User ID=admin1;Password=Hei123hei;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .ToTable("Rooms")
                .HasKey(g => g.RoomNumber);

            modelBuilder.Entity<User>()
                .HasKey(g => g.Email);

            modelBuilder.Entity<Booking>()
                .HasKey(g => new { g.Email, g.RoomNumber});

            modelBuilder.Entity<Maintenance>().HasKey(m => m.MaintenanceId);


        }
    }
}

