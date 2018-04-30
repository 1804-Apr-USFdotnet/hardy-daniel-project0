using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayerUnitTest
{
    [TestClass]
    public class DataLayerUnitTest
    {
        [TestMethod]
        public void TestMapping()
        {
            Models.Resturant r = new Models.Resturant();
            DataLayer.Resturant r1 = new DataLayer.Resturant();
            Models.Resturant tmp = DataLayer.DataManager.DataToModel(r1);
            DataLayer.Resturant tmp1 = DataLayer.DataManager.ModelToData(r);
            Assert.AreEqual(r.GetType(), tmp.GetType());
            Assert.AreEqual(r1.GetType(), tmp1.GetType());
        }

        [TestMethod]
        public void TestAddResturant()
        {
            DataLayer.DataManager dm = new DataLayer.DataManager();
            Models.Resturant test = new Models.Resturant();
            test.Name = "Mortons Steak House";
            test.Address = "4390 Suncoast Dr.";
            test.City = "Costa Mesa";
            test.State = "CA";
            test.FoodType = "American";
            dm.addResturant(test);
            List<Models.Resturant> list = dm.GetResturants().ToList();
            Models.Resturant verify = list.Where(x => x.Name == "Mortons Steak House").FirstOrDefault();

            Assert.AreEqual(test.Name, verify.Name);

        }
        [TestMethod]
        public void TestGetResturants()
        {
            DataLayer.DataManager dm = new DataLayer.DataManager();
            var tmp = dm.GetResturants().ToList();
            string expected = "Chili's";
            Assert.AreEqual(expected, tmp[0].Name);
        }
        [TestMethod]
        public void TestBLGetTopResturants()
        {
            BusinessLibrary bl = new BusinessLibrary();
            var list = bl.getTopResturants();
            Assert.AreEqual("Gino's", list[0].Name);
        }
        [TestMethod]
        public void TestBLGetResturantsByState()
        {
            BusinessLibrary bl = new BusinessLibrary();
            var list = bl.getResturantsbyState();
            Assert.AreEqual("CA", list[0].State);
        }

        [TestMethod]
        public void TestBLSearchResturants()
        {
            BusinessLibrary bl = new BusinessLibrary();
            var list = bl.SearchRestutants("Gin");
            Assert.AreEqual("Gino's", list[0].Name);
        }

        [TestMethod]
        public void TestBLGetResturantsByName()
        {
            BusinessLibrary bl = new BusinessLibrary();
            var list = bl.getResturantsbyName();
            Assert.AreEqual("Apple Bees", list[0].Name);
        }


    }

    //internal class List<T>
    //{
    //}
}
