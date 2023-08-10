using Microsoft.VisualStudio.TestTools.UnitTesting;
using prjConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjConsole.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void HelloWorldTest()
        {
            //Arrange
            string name = "Lake";
            Class1 class1 = new Class1();

            //Act
            var result = class1.HelloWorld(name);

            //Assert
            Assert.AreEqual(typeof(string), result.GetType());
            Assert.AreEqual("Hello Lake!", result);
        }

        [TestMethod()]
        public void FisrtMethodTest()
        {
            //Arrange
            int number = 50;
            Class1 class1 = new Class1();

            //Act
            var result = class1.FisrtMethod(number);

            //Assert
            Assert.AreEqual(typeof(bool), result.GetType());
            Assert.AreEqual(false, result);
        }
    }
}