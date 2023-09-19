using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint1.Task1.V13.Lib;

namespace Tyuiu.LoginovMV.Sprint1.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(2, res);
        }
    }
}
