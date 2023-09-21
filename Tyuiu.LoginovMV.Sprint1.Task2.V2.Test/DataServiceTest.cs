using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint1.Task2.V2.Lib;

namespace Tyuiu.LoginovMV.Sprint1.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 90;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(1.5707963267948966, res);
        }
    }
}
