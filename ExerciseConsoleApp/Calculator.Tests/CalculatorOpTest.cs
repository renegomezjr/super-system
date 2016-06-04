using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorOpTest
    {
        [TestMethod]
        public void ShouldAddReturnNineWhenPassedFiveAndFour()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();

            //Act
            int result = sut.Add(5, 4);

            //Assert
            Assert.AreEqual(9, result);

        }

        [TestMethod]
        public void ShouldAddReturnTwentyWhenPassedFiveAndFour()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();

            //Act
            int result = sut.Mul(5, 4);

            //Assert
            Assert.AreEqual(20, result);

        }
    }
}
