using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts
{
    [DataContract]
    public class PriceFilterDetail
    {
        [DataMember]
        public decimal HighestPrice { get; set; }

        [DataMember]
        public decimal LowestPrice { get; set; }

        public bool SatifyPriceBounds(decimal price)
        {
            return price >= LowestPrice && price <= HighestPrice;
        }
    }
}
