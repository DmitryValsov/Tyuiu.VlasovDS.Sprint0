using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VlasovDS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.VlasovDS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Дмитрий";
            var res = DataService.GetMessage(name);
            // Task2
            Assert.AreEqual("Привет..., Дмитрий", res);
        }
    }
}
