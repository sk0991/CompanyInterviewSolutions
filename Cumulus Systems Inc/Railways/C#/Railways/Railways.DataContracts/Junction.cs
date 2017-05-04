using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class Junction : Location
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public City City { get; set; }

        public HashSet<Junction> ConnectedTo { get; set; }

        public override LocationType Type
        {
            get
            {
                return LocationType.Junction;
            }
        }

        public override void Resolve()
        {

        }
    }
}
