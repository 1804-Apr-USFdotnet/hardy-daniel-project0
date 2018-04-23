using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using codingChallenge;

namespace TestCoddingChallenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckPapalindrome()
        {
            //Arrange
            string str = "never Odd or Even";
            bool expect = true;

            //Action
            bool actual = str.CheckPapalindrome();

            //Assert
            Assert.AreEqual(expect, actual);

        }
    }
}
