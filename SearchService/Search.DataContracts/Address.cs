using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts
{
    [DataContract]
    public class Address 
    {
        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string PostalCode { get; set; }

        public bool IsBelongToArea(string area)
        {
            if (string.IsNullOrEmpty(area))
            {
                return true;
            }
            return AddressLine1.ToLower().Contains(area) || AddressLine2.ToLower().Contains(area);
        }
    }
}
