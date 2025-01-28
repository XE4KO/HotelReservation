namespace HotelReservation.Components.Models
{
    public record Room(byte DoubleBeds, byte SingleBeds, List<string> Tags)
    {
        public required uint Id;
        public required int NightlyPrice;
        public required string TypeOfRoom;
    }

    record Single() : Room(1, 0, new List<string>() { "free Wifi", "coffee machine" });
    record Double() : Room(1, 1, new List<string>() { "free Wifi", "coffee machine" });
    record Triple() : Room(1, 2, new List<string>() { "free Wifi", "coffee machine" });
    record Quad() : Room(2, 2, new List<string>() { "free Wifi", "coffee machine" });
}
