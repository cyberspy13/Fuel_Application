using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost
{
    public abstract class FuelEconomyData : IFuelEconomy
    {
        protected double ImperialGallonsConst { get; set; } = 282.48;
        protected double KilometersInOneMile { get; set; } = 1.60;
        protected int JorneyDevideConst { get; set; } = 100;

        public abstract void CalulateCost();
    }
}
