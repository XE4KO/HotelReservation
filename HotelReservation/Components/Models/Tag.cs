﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservation.Components.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public IEnumerable<RoomTemplate>? Types { get; set; }
    }
}
