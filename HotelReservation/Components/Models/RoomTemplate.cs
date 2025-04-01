using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HotelReservation.Components.Models
{
    public class RoomTemplate
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }

        public required byte Adults { get; set; }

        public required byte Kids { get; set; }

        public required ICollection<Tag> Tags { get; set; }
        [JsonIgnore]
        public required ICollection<Image> Images { get; set; }

        public required int NightlyPrice { get; set; }

        public IEnumerable<Room>? Rooms { get; set; }

        public string? Description { get; set; }

    }
}
