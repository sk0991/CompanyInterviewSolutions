using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Search.DataContracts.Hotel;

namespace Search.Providers.Hotel
{
    public class SampleXml2Provider : ISampleXmlProvider
    {
        public List<HotelItinerary> GetHotelItineraries(XmlDocument xmlDocument)
        {
            throw new NotImplementedException();
        }
    }
}
