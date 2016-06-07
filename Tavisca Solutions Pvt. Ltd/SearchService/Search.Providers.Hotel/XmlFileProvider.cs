using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Search.DataContracts;
using Search.DataContracts.Hotel;

namespace Search.Providers.Hotel
{
    public class XmlFileProvider : IHotelSearchProvider
    {
        private List<string> _paths;
        private XmlDocument _xmlDocument;

        private static Dictionary<string, List<HotelItinerary>> _cachedHotelItineraries = new Dictionary<string, List<HotelItinerary>>();

        public XmlFileProvider(List<string> paths)
        {
            this._paths = paths;
        }

        public List<HotelItinerary> GetHotels(HotelSearchCriteria hotelSearchCriteria)
        {
            List<HotelItinerary> itineraries = new List<HotelItinerary>();

            foreach (var path in _paths)
            {
                List<HotelItinerary> allHotelItineraries = this.GetHotelItineraries(path);

                itineraries.AddRange(this.GetHotelItineraries(allHotelItineraries, hotelSearchCriteria));
            }

            return itineraries;
        }

        private List<HotelItinerary> GetHotelItineraries(List<HotelItinerary> allHotelItineraries, HotelSearchCriteria hotelSearchCriteria)
        {
            if (allHotelItineraries == null || allHotelItineraries.Count <= 0 || hotelSearchCriteria == null)
            {
                return null;
            }

            return allHotelItineraries.Where(hotelItinerary => hotelItinerary.SatisfySearchCriteria(hotelSearchCriteria)).ToList();
        }

        private List<HotelItinerary> GetHotelItineraries(string path)
        {
            if (!_cachedHotelItineraries.ContainsKey(path))
                _cachedHotelItineraries.Add(path, this.GetItinerariesFromXml(path));
            return _cachedHotelItineraries[path];
        }

        private List<HotelItinerary> GetItinerariesFromXml(string path)
        {
            this.LoadXmlDocument(path);

            ISampleXmlProvider provider = this.ResolveXmlProvider();

            return provider.GetHotelItineraries(_xmlDocument);
        }

        private ISampleXmlProvider ResolveXmlProvider()
        {
            throw new NotImplementedException();
        }

        private XmlDocument LoadXmlDocument(string path)
        {
            this._xmlDocument = new XmlDocument();
            this._xmlDocument.LoadXml(path);
            return _xmlDocument;
        }
    }
}
