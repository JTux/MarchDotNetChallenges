using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Insurance_RepositoryPattern
{
    public class ProgramUI
    {
        private VehicleRepository _vehicleRepo = new VehicleRepository();
        private User _user = new User();

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Hello. What would you like to do?\n" +
                    "1. View Information\n" +
                    "2. Update Information\n" +
                    "3. Register Vehicle\n" +
                    "4. Exit Application");

                string inputAsString = Console.ReadLine();
                //int input = int.Parse(inputAsString);
                if (!int.TryParse(inputAsString, out int input))
                {
                    continue;
                }

                switch (input)
                {
                    case 1:
                        ViewInformation();
                        break;
                    case 2:
                        Register();
                        break;
                    case 3:
                        RegisterVehicle();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }

        private void ViewInformation()
        {
            Console.WriteLine($"Hello {_user.Name}, here is your information:");

            List<Vehicle> vehicles = _vehicleRepo.GetVehicleList();
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }

            Console.ReadLine();
        }

        private void Register()
        {
            Console.WriteLine("Enter your full name:");
            _user.Name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            _user.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Select your gender:\n" +
                "1. Male\n" +
                "2. Female\n" +
                "3. Other");
            string genderAsString = Console.ReadLine().ToLower();
            switch (genderAsString)
            {
                case "male":
                case "1":
                    _user.Gender = GenderType.Male;
                    break;
                case "female":
                case "2":
                    _user.Gender = GenderType.Female;
                    break;
                case "other":
                case "3":
                default:
                    _user.Gender = GenderType.Other;
                    break;
            }
        }

        private void RegisterVehicle()
        {
            Vehicle newVehicle = new Vehicle();

            //Make
            Console.WriteLine("Enter the Make of the vehicle:");
            newVehicle.Make = Console.ReadLine();

            //Model
            Console.WriteLine("Enter the Model of the vehicle:");
            newVehicle.Model = Console.ReadLine();

            //Year
            Console.WriteLine("Enter the Year of the vehicle:");
            newVehicle.Year = int.Parse(Console.ReadLine());

            //Color
            Console.WriteLine("Enter the color of the vehicle:");
            newVehicle.Color = Console.ReadLine();

            //Type of Vehicle
            Console.WriteLine("Enter the type of vehicle:\n" +
                "1. Car\n" +
                "2. Boat\n" +
                "3. Motorcycle\n" +
                "4. Plane");

            string vehicleTypeAsString = Console.ReadLine().ToLower();
            switch (vehicleTypeAsString)
            {
                case "1":
                case "car":
                default:
                    newVehicle.TypeOfVehicle = VehicleType.Car;
                    break;
                case "2":
                case "boat":
                    newVehicle.TypeOfVehicle = VehicleType.Boat;
                    break;
                case "3":
                case "motorcycle":
                    newVehicle.TypeOfVehicle = VehicleType.Motorcycle;
                    break;
                case "4":
                case "plane":
                    newVehicle.TypeOfVehicle = VehicleType.Plane;
                    break;
            }

            _vehicleRepo.AddVehicleToList(newVehicle);
        }
    }
}
