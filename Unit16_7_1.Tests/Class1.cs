using NUnit.Framework;

namespace Unit16_7_1.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestAdditional()
        {
            Calculator calculator = new Calculator();

            Assert.True(calculator.Additional(2, 3) == 5);
        }

        [Test]
        public void TestSubtraction()
        {
            Calculator calculator = new Calculator();

            Assert.True(calculator.Subtraction(10, 2) == 8);
        }

        [Test]
        public void TestMultiplication()
        {
            Calculator calculator = new Calculator();

            Assert.True(calculator.Multiplication(4, 5) == 20);
        }

        [Test]
        public void TestDivision()
        {
            Calculator calculator = new Calculator();

            Assert.True(calculator.Division(20, 4) == 5);
        }
    }
}