using Pancakes.Domain;
using Pancakes.MixDispenser.Breville;
using Pancakes.Oven.Bosch;
using Pancakes.Primary.Ports;

namespace Pancakes.Service
{
    public class PancakeMakerFactory
    {
        public IPancakeMaker CreatePancakeMaker()
        {
            return new PancakeMaker2000(
                new BoschOven(),
                new BrevilleMixDispenser());
        }
    }
}