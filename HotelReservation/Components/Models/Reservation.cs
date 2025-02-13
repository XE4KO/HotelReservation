using HotelReservation.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Components.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public required Room Room { get; set; }

        public required ApplicationUser UserId { get; set; }

        public required DateTime Begin { get; set; }

        public required DateTime End { get; set; }

        public required byte AdultsNumber { get; set; }

        public required byte ChildrenNumber { get; set; }

        public string? Request { get; set; }

    }
}
