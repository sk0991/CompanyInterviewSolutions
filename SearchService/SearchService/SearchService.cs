﻿using Search.BusinessLogic;
using Search.BusinessLogic.Hotel;
using Search.DataContracts.Hotel;

namespace SearchService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
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
