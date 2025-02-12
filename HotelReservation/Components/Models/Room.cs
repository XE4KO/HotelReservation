using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Components.Models
{
    public class Room
    {
        [Key]
        public uint Id;

        public required RoomTemplate Type;

        public required uint Floor;

        public required uint Number;

        public required string Availability;
    }

}
