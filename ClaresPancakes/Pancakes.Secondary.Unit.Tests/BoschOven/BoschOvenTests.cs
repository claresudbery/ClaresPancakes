using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pancakes.Secondary.Ports;

namespace Pancakes.Secondary.Unit.Tests.BoschOven
{
    [TestClass]
    public class BoschOvenTests
    {
        [TestMethod]
        public void Oven_Should_Bake_Correct_Number_Of_Pancakes()
        {
            // Arrange
            var oven = new Oven.Bosch.BoschOven();
            var pancakeMix = new PancakeMix();
            var expectedNumberOfPancakes = 6;

            // Act
            var pancakes = oven.BakeMeSomePancakes(pancakeMix, expectedNumberOfPancakes);

            // Assert
            Assert.AreEqual(pancakes.Count, expectedNumberOfPancakes);
        }
    }
}