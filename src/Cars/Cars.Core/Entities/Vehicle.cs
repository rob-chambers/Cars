namespace Cars.Core.Entities
{
    public class Vehicle
    {
        public Model Model{ get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public int Doors { get; set; }

        public decimal Price { get; set; }

        public float EngineSize { get; set; }

        public int HorsePower { get; set; }

        public int FuelTankCapacity { get; set; }

        public float MPG { get; set; }
    }
}
