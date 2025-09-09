using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PautovaMO.Sprint0.Task2.V0.Lib;


namespace Tyuiu.PautovaMO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessagValid()

        {
            var name = "Мария";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Мария", res);

        }
    }
}
