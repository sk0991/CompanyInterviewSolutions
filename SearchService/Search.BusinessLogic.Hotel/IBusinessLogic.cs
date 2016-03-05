using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search.DataContracts.Hotel;

namespace Search.BusinessLogic
{
    public interface IBusinessLogic
    {
        HotelSearchResponse GetHotels(HotelSearchRequest hotelSearchRequest);
    }
}
