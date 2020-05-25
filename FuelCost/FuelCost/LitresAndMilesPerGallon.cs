using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelCost
{
    class LitresAndMilesPerGallon : FuelEconomyData
    {
        public override void CalulateCost()
        { 
            Console.Clear();
            Console.WriteLine("To convert between Litres per 100KM and Miles Per Gallon, please provide a value and \n" +
                $"click on the required button. For example, to find out the equivalent MPG value for 6L/100KM, please \n" +
                $"put 6 in the value text box then click on the Convert from L/ 100KM to MPG button.");
            Console.WriteLine("1 - Convert from MPG to L/100Km");
            Console.WriteLine("2 - Convert from L/100Km to MPG");
            int convertOptions = Convert.ToInt32(Console.ReadLine());

            switch (convertOptions)
            {
                case 1:
                    Console.WriteLine("Value:");
                    var valueMpg = Console.ReadLine();
                    double valueInputMpg;

                    while (!double.TryParse(valueMpg, out valueInputMpg))
                    {
                        Console.WriteLine("This is not a number");
                        Console.WriteLine("Please try again");
                        valueMpg = Console.ReadLine();
                    }
                    Console.Clear();
                    Console.WriteLine($"Value:\n{valueMpg}");
                    if (valueInputMpg > 0)
                    {
                        double resultMpg = ImperialGallonsConst / valueInputMpg;
                        Console.Clear();
                        Console.WriteLine($"{valueInputMpg} MPG is {Math.Round(resultMpg, 2)}L/100KM");
                    }
                    else
                    {
                        Console.WriteLine("Enter a number please");
                    }
                    break;
                case 2:
                    Console.WriteLine("Value:");
                    var valueL = Console.ReadLine();
                    double valueInputL;
                    while (!double.TryParse(valueL, out valueInputL))
                    {
                        Console.WriteLine("This is not a number");
                        Console.WriteLine("Please try again");
                        valueL = Console.ReadLine();
                    }
                    Console.Clear();
                    Console.WriteLine($"Value:\n{valueL}");
                    if (valueInputL > 0)
                    {
                        double resultL = ImperialGallonsConst / valueInputL;
                        Console.Clear();
                        Console.WriteLine($"{valueInputL} L is {Math.Round(resultL, 2)}MPG");
                    }
                    else
                    {
                        Console.WriteLine("Enter a number please");
                    }
                    break;
            }
            Console.Read();
        }
    }
}
