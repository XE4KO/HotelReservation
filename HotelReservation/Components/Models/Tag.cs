using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Components.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        [NotMapped] public string SelectedTagName { get; set; } = string.Empty;
        public IEnumerable<RoomTemplate>? Types { get; set; }
    }
}
