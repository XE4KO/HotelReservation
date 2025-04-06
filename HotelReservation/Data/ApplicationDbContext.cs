using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using HotelReservation.Components.Models;

namespace HotelReservation.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RoomTemplate> RoomTemplates { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Set collation for NormalizedUserName column
            builder.Entity<ApplicationUser>()
                .Property(u => u.NormalizedUserName)
                .HasMaxLength(256)
                .HasColumnType("varchar(256) COLLATE utf8mb4_bin");

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.Property(e => e.FullName)
                      .HasMaxLength(100)
                      .IsRequired();
            });
        }
    }
}