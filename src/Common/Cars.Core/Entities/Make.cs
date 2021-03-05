using System.Collections.Generic;

namespace Cars.Core.Entities
{
    public class Make
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}
