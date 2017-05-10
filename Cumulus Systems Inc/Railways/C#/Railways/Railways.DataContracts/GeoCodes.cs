using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class GeoCodes
    {
        [DataMember]
        public string Latitude { get; set; }

        [DataMember]
        public string Longitude { get; set; }
    }
}
