using System.Collections.Generic;
using Pancakes.Primary.Ports;
using Pancakes.Service;

namespace Pancakes.REST.API
{
    public class PancakeModule
    {
        private readonly IPancakeMaker _pancakeMaker;

        public PancakeModule()
        {
            _pancakeMaker = new PancakeMakerFactory().CreatePancakeMaker();
        }

        public List<Pancake> Get(int numPancakes)
        {
            return _pancakeMaker.GiveMePancakes(numPancakes);
        }
    }
}