using CoreApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CoreApp_MS_Testing
{
    [TestClass]
    public class CalculatorMSTest
    {
        private CalculatorApp calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new CalculatorApp();
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = calculator.Add(10, 5);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            int result = calculator.Subtract(10, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            int result = calculator.Multiply(10, 5);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            int result = calculator.Divide(10, 5);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
