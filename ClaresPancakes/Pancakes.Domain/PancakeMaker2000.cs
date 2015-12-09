using System.Collections.Generic;
using Pancakes.Primary.Ports;
using Pancakes.Secondary.Ports;

namespace Pancakes.Domain
{
    public sealed class PancakeMaker2000 : IPancakeMaker
    {
        private readonly IPancakeMixDispenser _pancakeMixDispenser;
        private readonly IPancakeOven _pancakeOven;

        public PancakeMaker2000(
            IPancakeOven pancakeOven,
            IPancakeMixDispenser pancakeMixDispenser)
        {
            _pancakeOven = pancakeOven;
            _pancakeMixDispenser = pancakeMixDispenser;
        }

        public List<Pancake> GiveMePancakes(int numPancakes)
        {
            var pancakeMix = _pancakeMixDispenser.GiveMeSomeMixture();

            var pancakes = _pancakeOven.BakeMeSomePancakes(pancakeMix, numPancakes);

            return pancakes;
        }
    }
}