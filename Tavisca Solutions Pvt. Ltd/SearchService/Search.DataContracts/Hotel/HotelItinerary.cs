using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Search.DataContracts.Hotel
{
    [DataContract]
    public class HotelItinerary
    {
        [DataMember]
        public string HotelId { get; set; }

        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public string Rating { get; set; }

        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public Geocode Geocode { get; set; }

        [DataMember]
        public List<RoomDetail> RoomDetails { get; set; }

        public bool SatisfySearchCriteria(HotelSearchCriteria hotelSearchCriteria)
        {
            bool result = this.Address.City.ToLower().Equals(hotelSearchCriteria.Location.City.ToLower());

            if (hotelSearchCriteria.IsFilterationRequired)
            {
                result = result && this.SatisfyFilterDetail(hotelSearchCriteria.FilterDetail as HotelFilterDetail);
            }

            return result;
        }

        public bool SatisfyFilterDetail(HotelFilterDetail hotelFilterDetail)
        {
            if (hotelFilterDetail == null)
                return true;

            bool result = true;
            if (!string.IsNullOrEmpty(HotelName))
            {
                result = this.HotelName.ToLower().Contains(hotelFilterDetail.HotelName.ToLower());
            }
            
            if (!string.IsNullOrEmpty(hotelFilterDetail.Area))
            {
                result = result && this.Address.IsBelongToArea(hotelFilterDetail.Area);
            }

            if (hotelFilterDetail.HotelRatings != null)
            {
                result = result && hotelFilterDetail.HotelRatings.Any(rt => this.Rating.Trim().Equals(rt.Trim()));
            }

            if (hotelFilterDetail.Price != null)
            {
                result = result &&
                     this.RoomDetails.Any(roomDetail => hotelFilterDetail.Price.SatifyPriceBounds(roomDetail.Price));
            }

            return result;
        }
    }
}