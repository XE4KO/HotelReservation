using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Components.Models
{
    public class Room
    {
        [Key]
        public required uint Id;

        public required RoomTemplate Type;

        public required uint Floor;

        public required uint Number;
    }

    /*
     record Single() : RoomTemplate(1, 0,"free Wifi,coffee machine" );
     record Double() : RoomTemplate(1, 1, "free Wifi,coffee machine" );
     record Triple() : RoomTemplate(1, 2, "free Wifi,coffee machine");
     record Quad() : RoomTemplate(2, 2, "free Wifi,coffee machine");*/
}
