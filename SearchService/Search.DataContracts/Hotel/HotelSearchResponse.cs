using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts.Hotel
{
    [DataContract]
    public class HotelSearchResponse : SearchResponse
    {
        [DataMember]
        public List<HotelItinerary> HotelItineraries { get; set; }
    }
}
