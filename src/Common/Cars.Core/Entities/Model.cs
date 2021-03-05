namespace Cars.Core.Entities
{
    public class Model
    {
        public int Id { get; set; }

        public int MakeId { get; set; }

        public Make Make { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int WarrantyId { get; set; }

        public Warranty Warranty { get; set; }

        public decimal MinPrice { get; set; }
    }
}
