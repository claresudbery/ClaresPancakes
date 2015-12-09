using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pancakes.Secondary.Ports;

namespace Pancakes.Secondary.Unit.Tests.HotpointOven
{
    [TestClass]
    public class HotpointOvenTests
    {
        [TestMethod]
        public void Oven_Should_Bake_Correct_Number_Of_Pancakes()
        {
            // Arrange
            var oven = new Oven.Hotpoint.HotpointOven();
            var pancakeMix = new PancakeMix();
            var expectedNumberOfPancakes = 6;

            // Act
            var pancakes = oven.BakeMeSomePancakes(pancakeMix, expectedNumberOfPancakes);

            // Assert
            Assert.AreEqual(pancakes.Count, expectedNumberOfPancakes);
        }
    }
}