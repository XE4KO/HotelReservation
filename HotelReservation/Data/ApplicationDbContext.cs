using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Base configuration is usually done in Program.cs
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "YourConnectionStringHere",
                    ServerVersion.AutoDetect("YourConnectionStringHere")
                );
            }
        }
    }
}
