using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you provide what Fuel-Economy option do you want to check");
            Console.WriteLine("1 - Jorney Cost"); 
            Console.WriteLine("2 - Required Fuel");
            Console.WriteLine("3 - Litres/100Km & Miles Per Gallon");
            var optionResult = Console.ReadLine();
            int resultOption = int.Parse(optionResult);

            FuelEconomyFactory economyFactory = new FuelEconomyFactory();
            IFuelEconomy calculator = economyFactory.FuelEconomy(resultOption);

            calculator.CalulateCost();
            
        }
    }
}
