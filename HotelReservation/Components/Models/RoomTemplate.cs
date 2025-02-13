using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Components.Models
{
    public class RoomTemplate
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required byte DoubleBeds { get; set; }

        public required byte SingleBeds { get; set; }

        //public IEnumerable<RoomTemplateToTag> Tags;

        public required int NightlyPrice { get; set; }

        public IEnumerable<Room> Rooms;
        public string? Description { get; set; }

    }
}
