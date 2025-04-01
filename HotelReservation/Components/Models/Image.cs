using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HotelReservation.Components.Models
{
    public class Image
    {
            [Key]
            public int Id { get; set; }
            public required string Path { get; set; }
            [JsonIgnore]
            public IEnumerable<RoomTemplate>? Templates { get; set; }
    }
}

