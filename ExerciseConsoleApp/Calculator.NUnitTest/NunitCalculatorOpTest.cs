using NUnit.Framework;


namespace Calculator.NUnitTest
{

    [TestFixture]
    public class NunitCalculatorOpTest
    {
        [Test]
        public void NunitAddReturnNineWhenPassedFiveAndFour()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();
            //Act
            int result = sut.Add(4, 5);
            //Assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void NunitMulReturnTwentyWhenPassedFiveAndFour()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();
            //Act
            int result = sut.Mul(4, 5);
            //Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void NunitSubReturnOneWhenPassedFiveAndFour()
        {
            //Arrange
            CalculatorOp sut = new CalculatorOp();
            //Act
            int result = sut.Sub(5, 4);
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
