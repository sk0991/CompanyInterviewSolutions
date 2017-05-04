using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class City : Location
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string State { get; set; }

        public List<Junction> Junctions { get; set; }

        public override LocationType Type
        {
            get
            {
                return LocationType.City;
            }
        }

        public override void Resolve()
        {

        }
    }
}
