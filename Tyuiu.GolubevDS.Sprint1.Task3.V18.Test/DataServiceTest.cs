using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GolubevDS.Sprint1.Task3.V18.Lib;

namespace Tyuiu.GolubevDS.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double c = 4;
            double wait = 24;
            var res = ds.HowManySquares(x, y, c);
            Assert.AreEqual(wait, res);

        }
    }
}
