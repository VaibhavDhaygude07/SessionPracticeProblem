using UnitTesting;

namespace TestCalcultor
{
    public class Tests
    {
        private CalculatorApp calculatorApp;

        [SetUp]
        public void Setup()
        {
            calculatorApp = new CalculatorApp();
        }

        [Test]
        public void AddResultInteger()
        {
            //Arrange
            int a = 10;
            int b = 20;
            int expected = 30;

            //Act
            int actual = CalculatorApp.Add(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SubtractResultInteger()
        {
            //Arrange
            int a = 20;
            int b = 10;
            int expected = 10;

            //Act
            int actual = CalculatorApp.Subtract(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void MultiplyResultInteger()
        {
            //Arrange
            int a = 20;
            int b = 10;
            int expected = 200;

            //Act
            int actual = CalculatorApp.Multiply(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void DivideResultInteger()
        {
            //Arrange
            int a = 20;
            int b = 10;
            int expected = 2;

            //Act
            int actual = CalculatorApp.Divide(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}