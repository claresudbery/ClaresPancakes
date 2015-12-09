using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pancakes.Secondary.Unit.Tests.BrevilleMixDispenser
{
    [TestClass]
    public class BrevilleMixDispenserTests
    {
        [TestMethod]
        public void Dispenser_Should_Return_Some_Mixture()
        {
            // Arrange
            var mixDispenser = new MixDispenser.Breville.BrevilleMixDispenser();

            // Act
            var pancakeMix = mixDispenser.GiveMeSomeMixture();

            // Assert
            Assert.IsNotNull(pancakeMix);
        }
    }
}