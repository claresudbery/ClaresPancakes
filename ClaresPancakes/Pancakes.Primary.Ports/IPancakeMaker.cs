using System.Collections.Generic;

namespace Pancakes.Primary.Ports
{
    public interface IPancakeMaker
    {
        List<Pancake> GiveMePancakes(int numPancakes);
    }
}