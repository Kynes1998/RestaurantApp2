using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restauranttest;

namespace UnitTestProject1
{
    [TestClass]
    public class RestaurantTestyJednostkowe
    {
        [TestMethod]
        public void TestMethod1()
        {


            Form1 form1 = new Form1();
            double zmiennaTest = form1.iSubTotal;

            Assert.AreEqual(form1.iSubTotal, zmiennaTest, "zgadza sie");
        }
    }
}
