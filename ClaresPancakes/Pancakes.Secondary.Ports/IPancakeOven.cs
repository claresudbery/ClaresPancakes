using System.Collections.Generic;
using Pancakes.Primary.Ports;

namespace Pancakes.Secondary.Ports
{
    public interface IPancakeOven
    {
        List<Pancake> BakeMeSomePancakes(PancakeMix someMixture, int numPancakes);
    }
}