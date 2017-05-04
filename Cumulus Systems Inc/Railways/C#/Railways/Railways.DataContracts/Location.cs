using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public abstract class Location
    {
        [DataMember]
        public GeoCodes GeoCodes { get; set; }

        public abstract LocationType Type { get; }

        public abstract void Resolve();
    }

    public enum LocationType
    {
        City = 0,
        Junction = 1,
    }
}
