namespace Cars.Core.Entities
{
    public class Warranty
    {
        public int Id { get; set; }

        public int Years { get; set; }

        public int? Mileage { get; set; }
    }
}