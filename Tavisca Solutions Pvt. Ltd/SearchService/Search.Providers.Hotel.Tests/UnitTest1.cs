using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Search.DataContracts.Hotel;

namespace Search.Providers.Hotel.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void XmlFileProviderGetHotelsTest()
        {
            const string sampleXml1Path = @"D:\Data\Downloads\Sample1.xml";
            const string sampleXml2Path = @"D:\Data\Downloads\Sample2.xml";

            List<string> paths = new List<string> {sampleXml1Path, sampleXml2Path};

            new XmlFileProvider(paths).GetHotels(new HotelSearchCriteria());
        }
    }
}
