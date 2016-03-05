using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts.Hotel
{
    [DataContract]
    public class HotelFilterDetail : FilterDetail
    {
        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public List<string> HotelRatings { get; set; }

        [DataMember]
        public PriceFilterDetail Price { get; set; }

        [DataMember]
        public string Area { get; set; }
    }
}
