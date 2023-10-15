using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MarinenkovaKD.Sprint2.Task7.V4.Lib;

namespace Tyuiu.MarinenkovaKD.Sprint2.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.7;
            double y = 0.7;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
