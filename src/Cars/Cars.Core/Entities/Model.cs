namespace Cars.Core.Entities
{
    public class Model
    {
        public int Id { get; set; }

        public Make Make { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

        public Warranty Warranty { get; set; }
    }
}
