using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelReservation.Components.Models;
using System.Reflection.Emit;

namespace HotelReservation.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<RoomTemplate> RoomTemplates { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.Property(e => e.FullName)
                      .HasMaxLength(100)
                      .IsRequired();
            });
        }
    }
}