using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search.DataContracts.Hotel;
namespace Search.Providers.Hotel
{
    public interface IHotelSearchProvider
    {
        List<HotelItinerary> GetHotels(HotelSearchCriteria hotelSearchCriteria);
    }
}
