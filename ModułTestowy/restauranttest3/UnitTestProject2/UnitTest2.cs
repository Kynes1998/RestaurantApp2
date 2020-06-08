using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using restauranttest;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form1 = new Form1();

            double Podatek = (form1.iSubTotal * 3.9) / 100;

            Assert.AreEqual(form1.iTax, Podatek, "wynik poprawny");
        }
    }
}