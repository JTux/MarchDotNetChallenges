using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_InsuranceChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string username = Console.ReadLine();

            Console.WriteLine($"Hello {username}. Enter your age:");
            string userAge = Console.ReadLine();
            int userAgeInt = int.Parse(userAge);

            Console.WriteLine("Enter your vehicle type:\n" +
                "1. Car\n" +
                "2. Boat\n" +
                "3. Motorcycle\n" +
                "4. Plane");

            string vehicleType = Console.ReadLine();
            int vehicleTypeInt = int.Parse(vehicleType);

            decimal ageCost = 0m;
            if (userAgeInt < 16)
            {
                Console.WriteLine("You're too young");
            }
            else if (userAgeInt < 22)
            {
                ageCost = 300m;
            }
            else
            {
                ageCost = 25m;
            }

            string vehicleTypeString = "";
            decimal vehicleCost = 0m;
            switch (vehicleTypeInt)
            {
                case 1: // Car
                    vehicleTypeString = "car";
                    vehicleCost = 100m;
                    break;
                case 2: // Boat
                    vehicleTypeString = "boat";
                    vehicleCost = 125m;
                    break;
                case 3: // Motorcycle
                    vehicleTypeString = "motorcycle";
                    vehicleCost = 150m;
                    break;
                case 4: // Plane
                    vehicleTypeString = "plane";
                    vehicleCost = 200m;
                    break;
            }

            decimal monthlyCost = ageCost + vehicleCost;

            Console.WriteLine($"{username} here is your monthly cost for your {vehicleTypeString}: ${monthlyCost}.");

            Console.ReadLine();
        }
    }
}
