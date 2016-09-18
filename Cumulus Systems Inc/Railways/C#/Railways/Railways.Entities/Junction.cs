using System.Collections.Generic;

namespace Railways.Entities
{
    public class Junction : Location
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public City City { get; set; }

        public List<Junction> ConnceJunctions { get; set; }
    }
}
