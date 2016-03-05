using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts
{
    [DataContract]
    public class SearchCriteria
    {
        public bool IsFilterationRequired
        {
            get { return FilterDetail != null; }
        }

        [DataMember]
        public Location Location { get; set; }

        [DataMember]
        public FilterDetail FilterDetail { get; set; }
    }
}
