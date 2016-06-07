using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts.Hotel
{
    [DataContract]
    public class RoomDetail
    {
        [DataMember]
        public string RoomName { get; set; }
        
        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public string RoomDescription { get; set; }
        
        [DataMember]
        public string RoomTypeCode { get; set; }

        [DataMember]
        public string RateCode { get; set; }

        [DataMember]
        public decimal RoomRate { get; set; }
    }
}
