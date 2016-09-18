using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public abstract class Location
    {
        [DataMember]
        public GeoCodes GeoCodes { get; set; }
    }
}
