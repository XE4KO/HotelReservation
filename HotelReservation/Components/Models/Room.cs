using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HotelReservation.Components.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public required RoomTemplate Type { get; set; }
        public required int Floor { get; set; }
        public required int Number { get; set; }
        public IEnumerable<Reservation>? Reservations { get; set; }
    }

}
