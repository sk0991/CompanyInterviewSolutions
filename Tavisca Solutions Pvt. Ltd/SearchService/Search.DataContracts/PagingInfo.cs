using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Search.DataContracts
{
    [DataContract]
    public class PagingInfo
    {
        private int _pageSize;

        [DataMember]
        public int PageNumber { get; set; }

        [DataMember]
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value > 0 ? value : 1;
            }
        }
    }
}
