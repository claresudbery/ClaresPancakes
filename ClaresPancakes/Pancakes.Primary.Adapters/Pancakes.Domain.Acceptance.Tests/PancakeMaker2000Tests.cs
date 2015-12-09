using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pancakes.Service;

namespace Pancakes.Domain.Unit.Tests
{
    [TestClass]
    public class PancakeMaker2000Tests
    {
        [TestMethod]
        public void PancakeMaker_Should_Return_Correct_Number_Of_Pancakes()
        {
            // Arrange
            var pancakeMaker = new PancakeMakerFactory().CreatePancakeMaker();
            var expectedNumberOfPancakes = 6;

            // Act
            var pancakes = pancakeMaker.GiveMePancakes(expectedNumberOfPancakes);

            // Assert
            Assert.AreEqual(pancakes.Count, expectedNumberOfPancakes);
        }
    }
}