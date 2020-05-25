using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost
{
    class RequiredFuel : FuelEconomyData
    {
        public override void CalulateCost()
        {
            Console.Clear();
            Console.WriteLine($"To calculate how much fuel you'll need for a given journey, please provide the distance in miles \n" +
                             $" you will be covering on your journey, and the estimated MPG of your vehicle.");
            Console.WriteLine("Distance(miles):");
            var miles = Console.ReadLine();
            double getMiles;
            while (!double.TryParse(miles, out getMiles))
            {
                Console.WriteLine("This is not a number");
                Console.WriteLine("Please try again");
                miles = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"Miles:\n{miles}");

            Console.WriteLine("MPG:");
            var mpg = Console.ReadLine();
            int getMpg;

            while (!int.TryParse(mpg, out getMpg))
            {
                Console.WriteLine("This is not a number");
                Console.WriteLine("Please try again");
                mpg = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"Miles:\n{miles}");
            Console.WriteLine($"MPG:\n{mpg}");

            List<object> milesAndMpg = new List<object>();
            milesAndMpg.Add(getMiles);
            milesAndMpg.Add(getMpg);

            if (getMiles != 0 && getMpg != 0)
            {
                double getResult = getMiles / getMpg;
                double getDistanceInKm = getMiles * KilometersInOneMile;
                double getLitres = ImperialGallonsConst / getMpg;
                double getResultInLitres = getDistanceInKm / getLitres;
                Console.WriteLine($"You would require {Math.Round(getResult,1)} gallons for this journey.Or {Math.Round(getResultInLitres,2)} litres");
            }
            Console.ReadLine();
        }
    }
}
