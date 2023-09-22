using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint1.Task3;
using Tyuiu.LoginovMV.Sprint1.Task3.Lib;
namespace Tyuiu.LoginovMV.Sprint1.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double x2 = 2;
            double y1 = 1;
            double y2 = 2;
            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(true, res);
        }
    }
}
