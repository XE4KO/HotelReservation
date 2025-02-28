using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Components.Models
{
	[Keyless]
	public class RoomTemplateToTag
    {
        //useless?
        public required RoomTemplate Type { get; set; }
        public required Tag Tag { get; set; }

    }
}
