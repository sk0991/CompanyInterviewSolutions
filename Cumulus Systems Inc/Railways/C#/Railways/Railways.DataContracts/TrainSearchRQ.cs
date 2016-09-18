using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class TrainSearchRQ
    {
        [DataMember]
        public SearchCriteria SearchCriteria { get; set; }

        public bool Validate()
        {
            return SearchCriteria != null && SearchCriteria.Destination != null && SearchCriteria.Source != null && SearchCriteria.MaxStops > 0;
        }
    }
}