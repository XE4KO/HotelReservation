using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Components.Models
{
    public class Image
    {
            [Key]
            public int Id { get; set; }
            public required string Path { get; set; }
            public IEnumerable<RoomTemplate>? Templates { get; set; }
    }
}

