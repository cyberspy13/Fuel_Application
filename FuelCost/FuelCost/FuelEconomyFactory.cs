using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost
{
    class FuelEconomyFactory
    {
        public IFuelEconomy FuelEconomy(int resultOption)
        {
            switch (resultOption)
            {
                case 1:
                    return new JourneyCost();
                case 2:
                    return new RequiredFuel();
                case 3:
                    return new LitresAndMilesPerGallon();
                default:
                    throw new ArgumentException("Unrecognised input type", nameof(resultOption));
            }
        }
    }
}
