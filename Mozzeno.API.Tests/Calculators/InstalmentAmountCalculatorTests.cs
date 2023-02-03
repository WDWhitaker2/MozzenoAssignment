using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozzeno.API.Calculators;

namespace Mozzeno.API.Tests.Calculators
{
    [TestClass]
    public class InstalmentAmountCalculatorTests
    {
        [TestMethod]
        public void CalculateWithNominalRate_Returns_CorrectInstalmentAmount()
        {
            // Arrange
            const decimal amount = 1315.22m;
            const decimal rate = 3.42955145m;
            const int months = 24;

            // Act
            var result = InstalmentAmountCalculator.Calculate(amount, rate / 100, months);

            // Assert
            Assert.AreEqual(56.7799810782547m, result);
        }

        [TestMethod]
        public void CalculateWithZeroRate_Returns_CorrectInstalmentAmount()
        {
            // Arrange
            const decimal amount = 2700m;
            const decimal rate = 0m;
            const int months = 10;

            // Act
            var result = InstalmentAmountCalculator.Calculate(amount, rate / 100, months);

            // Assert
            Assert.AreEqual(270m, result);
        }
    }
}
