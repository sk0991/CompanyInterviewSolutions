using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Railways.DataContracts
{
    [DataContract]
    public class TrainSchedule
    {
        [DataMember]
        public List<TrainStopInfo> StopInfos { get; set; }
    }

    [DataContract]
    public class TrainStopInfo
    {
        [DataMember]
        public int SNo { get; set; }

        [DataMember]
        public Junction Junction { get; set; }

        [DataMember]
        public DateTime? ArrivalTime { get; set; }

        [DataMember]
        public DateTime? DepartureTime { get; set; }
    }
}
