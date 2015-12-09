using System.Collections.Generic;
using Pancakes.Primary.Ports;
using Pancakes.Secondary.Ports;

namespace Pancakes.Oven.Bosch
{
    public class BoschOven : IPancakeOven
    {
        public List<Pancake> BakeMeSomePancakes(PancakeMix someMixture, int numPancakes)
        {
            var pancakes = new List<Pancake>();

            for (var pancakeCount = 1; pancakeCount <= numPancakes; pancakeCount++)
            {
                pancakes.Add(new Pancake());
            }

            return pancakes;
        }
    }
}