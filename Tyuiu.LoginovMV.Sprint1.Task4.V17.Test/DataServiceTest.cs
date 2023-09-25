using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint1.Task4.V17.Lib;

namespace Tyuiu.LoginovMV.Sprint1.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}
