using Search.BusinessLogic;
using Search.BusinessLogic.Hotel;
using Search.DataContracts.Hotel;

namespace SearchService
{
    public class SearchService : ISearchService
    {
        private IBusinessLogic _businessLogic;

        public SearchService()
        {
            _businessLogic = new HotelBusinessLogic();
        }

        public HotelSearchResponse GetHotels(HotelSearchRequest hotelSearchRequest)
        {
            if (hotelSearchRequest == null)
                return null;

            return _businessLogic.GetHotels(hotelSearchRequest);
        }
    }
}
