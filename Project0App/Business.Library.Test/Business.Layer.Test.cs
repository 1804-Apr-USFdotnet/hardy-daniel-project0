using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Layer;
namespace Business.Library.Test
{
    [TestClass]
    public class UnitTest1
    {


        List<Resturant> list;

        [TestMethod]
        public void TestGetAllResturants()
        {
            //Arrange
            BusinessLayer bl = new BusinessLayer();
            Serializer.InputFile = "\\revature\\hardy-daniel-project0\\Project0App\\Resturants.XML";
            list = Serializer.Deserialize();
            List<Resturant> tmp;
            int Expected = 5;

            //Action
            tmp = bl.GetAllResturants(list);

            Assert.AreEqual(Expected, tmp.Count);
        }
        [TestMethod]
        public void GetTop3Resturants()
        {
            //Arrange
            BusinessLayer bl = new BusinessLayer();
            //Serializer.InputFile = "\\revature\\hardy-daniel-project0\\Project0App\\Resturants.XML";
            list = Serializer.Deserialize();
            List<Resturant> tmp;
            List<Resturant> Expected = new List<Resturant>();
            Resturant r = new Resturant();
            float avg = (5 + 3 + 4) / (3);
            r.Name = "Chili's";
            r.Location = "123 Homer st.";
            r.FoodType = "American";
            r.AddRating(new ResturantRating(3, "Daniel", "Good enviornment, needs cleaning"));
            r.AddRating(new ResturantRating(4, "Amy", "Good enviornment, Good Food"));
            r.AddRating(new ResturantRating(5, "Michael", "Food was HOOT, service was moderate"));
            Expected.Add(r);

            r = new Resturant();
            r.Name = "AppleBee's";
            r.Location = "125 Homer st.";
            r.FoodType = "American";
            r.AddRating(new ResturantRating(4, "Jake", "Good enviornment, needs cleaning"));
            r.AddRating(new ResturantRating(4, "Dez", "Good enviornment, Good Food"));
            r.AddRating(new ResturantRating(1, "Steph", "Server was to chatty, service was slow"));
            Expected.Add(r);

            r = new Resturant();
            r.Name = "Wood Ranch";
            r.Location = "125 N. Nebraska st.";
            r.FoodType = "BBQ";
            r.AddRating(new ResturantRating(4, "Rusty", "Food was GREAT, but super long wait"));
            r.AddRating(new ResturantRating(4, "Tammy", "Hot Food, Cold Drinks.. Great Experence"));
            r.AddRating(new ResturantRating(1, "Tamera", "My car got stolen from the parking lot, so sad"));
            Expected.Add(r);

            //Action
            tmp = bl.GetTop3Resturants(list);

            Assert.AreEqual(tmp[1].GetAverageRating(), 3);
        }
        [TestMethod]
        public void TestGetResturant()
        {
            BusinessLayer bl = new BusinessLayer();
            Serializer.InputFile = "\\revature\\hardy-daniel-project0\\Project0App\\Resturants.XML";
            list = Serializer.Deserialize();

            Resturant r = new Resturant();
            r.Name = "The Wok";
            r.Location = "714 Gothard st";
            r.FoodType = "Thai";
            r.AddRating(new ResturantRating(4, "Rusty", "Food was GREAT, but super long wait"));
            r.AddRating(new ResturantRating(1, "Tammy", "Hot Food, Cold Drinks.. Great Experence"));
            r.AddRating(new ResturantRating(1, "Tamera", "Good Food, Chow min was great"));
            Resturant r1 = bl.GetResturant(list, "The Wok");

            Assert.AreEqual(r.Name, r1.Name);

        }
        [TestMethod]
        public void TestGetReviews()
        {
            BusinessLayer bl = new BusinessLayer();
            Serializer.InputFile = "\\revature\\hardy-daniel-project0\\Project0App\\Resturants.XML";
            list = Serializer.Deserialize();

            Resturant r = new Resturant();
            r.Name = "The Wok";
            r.Location = "714 Gothard st";
            r.FoodType = "Thai";
            r.AddRating(new ResturantRating(4, "Rusty", "Food was GREAT, but super long wait"));
            r.AddRating(new ResturantRating(1, "Tammy", "Hot Food, Cold Drinks.. Great Experence"));
            r.AddRating(new ResturantRating(1, "Tamera", "Good Food, Chow min was great"));

            Assert.AreEqual(r.Ratings.Count, list[4].Ratings.Count);
        }
        [TestMethod]
        public void TestReturnFromPartial()

        {
            //Arrange
            BusinessLayer bl = new BusinessLayer();
            Serializer.InputFile = "\\revature\\hardy-daniel-project0\\Project0App\\Resturants.XML";
            list = Serializer.Deserialize();
            List<Resturant> expected = new List<Resturant>();
            Resturant r = new Resturant();
            r.Name = "The Wok";
            r.Location = "714 Gothard st";
            r.FoodType = "Thai";
            r.AddRating(new ResturantRating(4, "Rusty", "Food was GREAT, but super long wait"));
            r.AddRating(new ResturantRating(1, "Tammy", "Hot Food, Cold Drinks.. Great Experence"));
            r.AddRating(new ResturantRating(1, "Tamera", "Good Food, Chow min was great"));
            expected.Add(r);
            //Action
            List<Resturant> partial = bl.ReturnFromPartial(list, "The");

            //Assert
            //System.Console.WriteLine("----- Unit test: partial[0] = {0}",partial[0].Name);
            //Assert.AreEqual(1.0,1.0);
            Assert.AreEqual(expected[0].Name, partial[0].Name);
        }
   
    }
}
