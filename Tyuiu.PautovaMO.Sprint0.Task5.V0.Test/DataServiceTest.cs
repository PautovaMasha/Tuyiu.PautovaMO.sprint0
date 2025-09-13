using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PautovaMO.Sprint0.Task5.V0.Lib;

namespace Tyuiu.PautovaMO.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckedMultipliactionValid()
        {
            Assert.AreEqual(50, DataService.Multipliaction(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
        
    }
}
