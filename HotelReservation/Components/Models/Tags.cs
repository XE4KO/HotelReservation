using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Components.Models
{
    public class Tag
    {
        [Key]
        public required uint Id { get; set; }
        public required string Name { get; set; }
        //public IEnumerable<RoomTemplateToTag> Types { get; set; }
    }
}
