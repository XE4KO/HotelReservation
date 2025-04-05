using HotelReservation.Components.Pages;
using Microsoft.AspNetCore.Identity;

namespace HotelReservation.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}