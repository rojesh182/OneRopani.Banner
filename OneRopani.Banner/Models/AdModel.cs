namespace OneRopani.Banner.Models
{
    public class AdModel
    {
        public int Id { get; set; }

        public string PropertyType { get; set; }
        public string TransactionType { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public long? TotalPrice { get; set; }
        public long? UnitPrice { get; set; }
        public int Ropani { get; set; }
        public int? Aana { get; set; }
        public int? Daam { get; set; }
        public int? Paisa { get; set; }

        public int? HouseArea { get; set; }
        public int? NoOfFloors { get; set; }
        public int? BedRoom { get; set; }
        public int? LivingRoom { get; set; }
        public int? Kitchen { get; set; }
        public int? DiningRoom { get; set; }

        public string District { get; set; }
        public string Municipality { get; set; }
        public string Location { get; set; }
        public int? WardNo { get; set; }
        public string Tole { get; set; }
        public float RoadWith { get; set; }
        public float DistanceFromMainRoad { get; set; }

        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PhoneNo { get; set; }
        public long MobileNo { get; set; }
    }
}