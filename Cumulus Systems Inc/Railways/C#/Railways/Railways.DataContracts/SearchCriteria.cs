using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class SearchCriteria
    {
        [DataMember]
        public Location Source { get; set; }

        [DataMember]
        public Location Destination { get; set; }

        [DataMember]
        public int MaxStops { get; set; }
    }
}