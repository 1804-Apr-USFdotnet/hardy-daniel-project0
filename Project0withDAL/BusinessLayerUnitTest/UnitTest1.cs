using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BusinessLibrary bl = new BusinessLibrary();
            List<Models.Resturant> list = bl.getTopResturants();
            Assert.AreEqual("Gino's", list[0].Name);
        }
    }
}
