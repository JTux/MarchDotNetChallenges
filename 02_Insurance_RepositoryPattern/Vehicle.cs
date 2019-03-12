using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Insurance_RepositoryPattern
{
    public enum VehicleType
    {
        Car = 1, Boat, Motorcycle, Plane
    }

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle() { }
        public Vehicle(string make, string model, int year, string color, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            TypeOfVehicle = typeOfVehicle;
        }
    }
}
