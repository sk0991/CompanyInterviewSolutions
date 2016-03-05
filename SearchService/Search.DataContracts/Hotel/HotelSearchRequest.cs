using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts.Hotel
{
    [DataContract]
    public class HotelSearchRequest : SearchRequest
    {
        [DataMember]
        public HotelSearchCriteria HotelSearchCriteria { get; set; }
    }
}
