using System.Collections.Generic;

namespace Railways.Entities
{
    public class City : Location
    {
        public string Name { get; set; }

        public string State { get; set; }

        public List<Junction> Junctions { get; set; }
    }
}
