using System.ComponentModel.DataAnnotations;
--------------------------------------------------------------------------------------------------------------------using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Components.Models
{
    public class Reservation
    {
        [Key]
        public uint Id { get; set; }

        public required uint RoomId { get; set; }

        public required uint UserId { get; set; }

        public required DateTime ReservationBegin { get; set; }

        public required DateTime ReservationEnd { get; set; }

        public required byte GuestNumber { get; set; }

        public string? Request { get; set; }

    }
}
