using Calculator;
using NUnit.Framework;

namespace CalculatorUnitTests
{
    public class Tests
    {
        [Test]
        public void TestSum()
        {
            // Arrange (Testo duomenys)
            int number1 = 5;
            int number2 = 2;
            int expectedResult = 10;

            // Act (Testo veiksmai)
            int actualResult = Methods.Sum(number1, number2);

            // Assert (Testo rezultatų palyginimas)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 2, 2.5)]
        [TestCase(7, 2, 3.5)]
        [TestCase(1, 3, 0.3333)]
        [TestCase(1, 8, 0.125)]
        public void TestDivision(int number1, int number2, double expectedResult)
        {
            double actualResult = Methods.Divide(number1, number2);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
