using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HotelReservation.Components.Models;

namespace HotelReservation.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Base configuration is usually done in Program.cs
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "YourConnectionStringHere",
                    ServerVersion.AutoDetect("YourConnectionStringHere")
                );
            }
        }*/
        public DbSet<RoomTemplate> RoomTemplates { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<RoomTemplateToTag> RoomTemplatesTags{ get; set; }
        public DbSet<Reservation> Reservations { get; set; }

    }
 
}
