using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint1.Task7.V26.Lib;

namespace Tyuiu.LoginovMV.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 16;
            var res = ds.Calculate(x, y);
            var result = 1.294;
            Assert.AreEqual(result, res);
        }
    }
}
