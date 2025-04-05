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

        public required string UserName { get; set; }
        public required string UserPhone { get; set; }
        public required string UserEmail { get; set; }

        public required DateTime Begin { get; set; }

        public required DateTime End { get; set; }

        public required int AdultsNumber { get; set; }

        public required int ChildrenNumber { get; set; }

        public string? Request { get; set; }

    }
}
