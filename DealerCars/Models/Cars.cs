namespace DealerCars.Models
{
    public class Cars
    {
        public Guid Id { get; set; }
        public string Model { get ; set; }
        public string Brand { get; set; }
        public int ProductionYear { get; set; }
        public double Price { get; set; }
        public bool IsSold { get; set; }

        public Category Category { get; set; }
    }
}
