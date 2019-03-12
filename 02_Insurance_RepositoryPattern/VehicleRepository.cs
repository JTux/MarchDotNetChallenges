using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Insurance_RepositoryPattern
{
    public class VehicleRepository
    {
        private List<Vehicle> _vehicleList;

        public VehicleRepository()
        {
            _vehicleList = new List<Vehicle>();
        }

        public void AddVehicleToList(Vehicle newVehicle)
        {
            _vehicleList.Add(newVehicle);
        }

        public List<Vehicle> GetVehicleList()
        {
            return _vehicleList;
        }
    }
}
