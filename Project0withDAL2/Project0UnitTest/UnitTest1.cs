using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using Project0withDAL;
using System.Collections.Generic;

namespace Project0UnitTest
{
    [TestClass]
    public class Project0UnitTest1
    {
        [TestMethod]
        public void TestGetAllResturants()
        {
            DataManager dm = new DataManager();
            var list = (List<Resturant>)dm.getResturants();
            string expected = "Chili's";

            Assert.AreEqual(expected, list[0].Name);
        }

        [TestMethod]
        public void TestBGetTop3Resturants()
        {
            BusinessLayer bl = new BusinessLayer();
            List<Resturant> result = bl.getTopResturants();

            Assert.AreEqual(3, result.Count);
        }

    }
}
