using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search.DataContracts;
using Search.DataContracts.Hotel;
using Search.Providers.Hotel;

namespace Search.BusinessLogic.Hotel
{
    public class HotelBusinessLogic : IBusinessLogic
    {
        public HotelSearchResponse GetHotels(HotelSearchRequest hotelSearchRequest)
        {
            IHotelSearchProvider provider = GetEligibleProvider(hotelSearchRequest);

            List<HotelItinerary> itineraries = provider.GetHotels(hotelSearchRequest.HotelSearchCriteria);

            return ApplyPagination(itineraries, hotelSearchRequest.PagingInfo);
        }

        private HotelSearchResponse ApplyPagination(List<HotelItinerary> itineraries, PagingInfo pagingInfo)
        {
            if (pagingInfo == null)
            {
                pagingInfo = new PagingInfo();
            }

            HotelSearchResponse hotelSearchResponse = new HotelSearchResponse();

            hotelSearchResponse.HotelItineraries =
                itineraries.Skip(pagingInfo.PageNumber*pagingInfo.PageSize).Take(pagingInfo.PageSize).ToList();

            return hotelSearchResponse;
        }

        private IHotelSearchProvider GetEligibleProvider(HotelSearchRequest hotelSearchRequest)
        {
            List<string> paths = new List<string>();

            paths.Add(@"D:\Data\Downloads\Sample1.xml");
            paths.Add(@"D:\Data\Downloads\Sample2.xml");

            return new XmlFileProvider(paths);
        }
    }
}
