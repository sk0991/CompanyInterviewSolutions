using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class TrainSearchRS
    {
        [DataMember]
        public List<Train> Trains { get; set; }
    }
}