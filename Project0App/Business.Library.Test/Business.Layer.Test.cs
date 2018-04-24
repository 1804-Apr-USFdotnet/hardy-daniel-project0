using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business.Layer;
namespace Business.Library.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReturn10()
        {
            //Arrange
            BusinessLayer bl = new BusinessLayer();
            Resturant r = new Resturant();
            r.Name = "Chili's";
            r.Location = "123 Homer st.";
            r.FoodType = "American";
            r.AddRating(new ResturantRating(3, "Daniel", "Good enviornment, needs cleaning"));
            r.AddRating(new ResturantRating(4, "Amy", "Good enviornment, Good Food"));
            r.AddRating(new ResturantRating(2, "Michael", "Food was cold, service was slow"));

            r.Name = "AppleBee's";
            r.Location = "125 Homer st.";
            r.FoodType = "American";
            r.AddRating(new ResturantRating(3, "Dani", "Good enviornment, needs cleaning"));
            r.AddRating(new ResturantRating(4, "Daniel", "Good enviornment, Good Food"));
            r.AddRating(new ResturantRating(2, "Daniel", "Food was cold, service was slow"));
            //Action


            //Assert

        }
    }
}
