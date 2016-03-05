﻿using System;
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
            List<string> paths = new List<string>();

            paths.Add(@"D:\Data\Downloads\Sample1.xml");
            paths.Add(@"D:\Data\Downloads\Sample2.xml");

            new XmlFileProvider(paths).GetHotels(new HotelSearchCriteria());
        }
    }
}
