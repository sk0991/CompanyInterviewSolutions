using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts
{
    [DataContract]
    public class Location
    {
        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public Geocode Geocode { get; set; }
    }
}
