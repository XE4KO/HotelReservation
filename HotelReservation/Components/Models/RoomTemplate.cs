using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Components.Models
{
    public class RoomTemplate
    {
        [Key]
        public required uint Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }

        public required byte DoubleBeds { get; set; }

        public required byte SingleBeds { get; set; }
        //public IEnumerable<RoomTemplateToTag> Tags;

        public required uint NightlyPrice;
        //public IEnumerable<Room> Rooms;
    }
}
