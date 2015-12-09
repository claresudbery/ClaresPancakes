using Pancakes.Secondary.Ports;

namespace Pancakes.MixDispenser.Breville
{
    public sealed class BrevilleMixDispenser : IPancakeMixDispenser
    {
        public PancakeMix GiveMeSomeMixture()
        {
            return new PancakeMix();
        }
    }
}