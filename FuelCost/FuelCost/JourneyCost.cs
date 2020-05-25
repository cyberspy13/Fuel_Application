using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost
{
    class JourneyCost : FuelEconomyData
    {
        public override void CalulateCost()
        {
            Console.Clear();
            Console.WriteLine($"To calculate how much a journey will actually cost in fuel, please provide the miles\n" +
                           $" covered,the estimated MPG for your vehicle, and the price of your petrol in pence.");
            Console.WriteLine("Miles:");
            var miles = Console.ReadLine();
            double totalMiles;
            while (!double.TryParse(miles, out totalMiles))
            {
                Console.WriteLine("This is not a number");
                Console.WriteLine("Please try again");
                miles = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"Miles:\n{miles}");

            Console.WriteLine("MPG:");
            var mpg = Console.ReadLine();
            int averageMpg;
            while (!int.TryParse(mpg, out averageMpg))
            {
                Console.WriteLine("This is not a number");
                Console.WriteLine("Please try again");
                mpg = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"Miles:\n{miles}");
            Console.WriteLine($"MPG:\n{mpg}");


            Console.WriteLine("Fuel Cost(Pence/Litre):");
            var fuelCost = Console.ReadLine();
            decimal fuelPrice;

            while (!decimal.TryParse(fuelCost, out fuelPrice))
            {
                Console.WriteLine("This is not a number");
                Console.WriteLine("Please try again");
                fuelCost = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"Miles:\n{miles}");
            Console.WriteLine($"MPG:\n{mpg}");
            Console.WriteLine($"Fuel Cost:\n{fuelCost}");

            List<object> objectList = new List<object>();
            objectList.Add(miles);
            objectList.Add(mpg);
            objectList.Add(fuelPrice);

            GetJorneyCostDone(totalMiles,averageMpg,fuelPrice);
            Console.Read();
        }
        public void GetJorneyCostDone(double miles,int mpg,decimal fuelCost)
        {
            if (miles > 0 && mpg > 0 && fuelCost > 0)
            {
                double getInmerialGallonsInLitres = ImperialGallonsConst / mpg;

                double distanceInKm = miles * KilometersInOneMile;
                double devideDistanceInKm = distanceInKm / JorneyDevideConst;

                double resDevideDistanceInKm = devideDistanceInKm * getInmerialGallonsInLitres;

                double resDevideDistInKmRound = Math.Round(resDevideDistanceInKm, 2);

                double jorneyCostResult = resDevideDistInKmRound * (double)fuelCost;

                double finalJorneyCostResult = jorneyCostResult / JorneyDevideConst;

                Console.WriteLine($"The Jorney would cost you £{Math.Round(finalJorneyCostResult, 2)}");

            }
            else
            {
                Console.WriteLine("OOOOPs!Write a number greater that '0'");
            }
            Console.Read();
            
        }

    }
}
