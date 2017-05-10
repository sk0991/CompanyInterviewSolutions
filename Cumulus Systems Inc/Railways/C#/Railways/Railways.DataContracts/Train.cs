using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class Train
    {
        [DataMember]
        public int Number { get; set; }

        [DataMember]
        public string Name { get; set; }

        public TrainSchedule Schedule { get; set; }
    }
}
