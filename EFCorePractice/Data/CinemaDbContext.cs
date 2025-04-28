using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCorePractice.Entities;
using EFCorePractice.Enums;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice.Data
{
    public class CinemaDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public CinemaDbContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connStr = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Cinema; Integrated Security=True; Connect Timeout=30; Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connStr);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Enums as strings
            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasConversion<string>();

            modelBuilder.Entity<Hall>()
                .Property(h => h.Type)
                .HasConversion<string>();

            modelBuilder.Entity<Session>()
                .Property(s => s.Status)
                .HasConversion<string>();

            modelBuilder.Entity<Ticket>()
                .Property(t => t.Status)
                .HasConversion<string>();

            //Seed Movies
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", Director = "Christopher Nolan", Duration = new TimeSpan(2, 28, 0), ReleaseYear = 2010, AgeRestriction = 13, Description = "A thief who steals corporate secrets through dream-sharing technology." },
                new Movie { Id = 2, Title = "The Matrix", Genre = "Action", Director = "The Wachowskis", Duration = new TimeSpan(2, 16, 0), ReleaseYear = 1999, AgeRestriction = 16, Description = "A hacker discovers reality is a simulation." }
            );

            // Seed Halls
            modelBuilder.Entity<Hall>().HasData(
                new Hall { Id = 1, Number = 1, Capacity = 100, Type = HallType.Standart },
                new Hall { Id = 2, Number = 2, Capacity = 50, Type = HallType.VIP }
            );

            // Seed Sessions
            modelBuilder.Entity<Session>().HasData(
                new Session { Id = 1, MovieId = 1, HallId = 1, StartTime = new DateTime(2025, 4, 15, 18, 0, 0), TicketPrice = 150, Status = SessionStatus.Active },
                new Session { Id = 2, MovieId = 2, HallId = 2, StartTime = new DateTime(2025, 4, 15, 21, 0, 0), TicketPrice = 200, Status = SessionStatus.Active }
            );

            // Seed Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Admin", Email = "admin@cinema.com", Role = UserRole.Admin, BonusPoints = 0 },
                new User { Id = 2, Name = "Olga", Email = "olga@gmail.com", Role = UserRole.Client, BonusPoints = 120 }
            );

            // Seed Discounts
            modelBuilder.Entity<Discount>().HasData(
                new Discount { Id = 1, Description = "Spring Sale", Percentage = 0.1m, IsForLoyalClients = false },
                new Discount { Id = 2, Description = "Loyalty Discount", Percentage = 0.15m, IsForLoyalClients = true }
            );

            // Seed Sales
            modelBuilder.Entity<Sale>().HasData(
                new Sale { Id = 1, UserId = 2, PurchaseDate = DateTime.Now.Date, TotalPrice = 300, DiscountId = 2 }
            );

            // Seed Tickets
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { Id = 1, SessionId = 1, SeatNumber = "A1", Price = 150, Status = TicketStatus.Purchased, SaleId = 1 },
                new Ticket { Id = 2, SessionId = 1, SeatNumber = "A2", Price = 150, Status = TicketStatus.Purchased, SaleId = 1 }
            );
        }
    }
}