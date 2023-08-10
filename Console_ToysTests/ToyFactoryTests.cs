using Microsoft.VisualStudio.TestTools.UnitTesting;
using Console_Toys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Toys.Tests
{
    [TestClass()]
    public class ToyFactoryTests
    {
        [TestMethod()]
        public void MakeToyTest()
        {
            //Arrange
            ToyFactory factory = new ToyFactory();

            //Act
            var result = factory.MakeToy("PS5") as PS5;

            //Assert
            Assert.AreEqual(typeof(PS5), result.GetType()); //typeof(型別)
        }
 
        [TestMethod()]
        public void PlayTest_Soso()
        {
            //Arrange
            ToyFactory factory = new ToyFactory();
            var testToy = factory.MakeToy("Lego");

            //Act
            string result = testToy.Play();

            //Assert
            Assert.AreEqual("中好玩", result);
        }
    }
}