using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainCarTransport.Models;

namespace TrainCarTransport.Repo
{
    public class VehicleRepo : IVehicleRepo
    {
        List<Vehicle> vehicles;
        List<Vehicle> arrived;
        List<Vehicle> departed;

        public VehicleRepo() 
        { 
            vehicles = new List<Vehicle>();
            arrived = new List<Vehicle>();
            departed = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void Arrive(Vehicle vehicle)
        {
            arrived.Add(vehicle);
        }

        public void ClearVehicles()
        {
            vehicles.Clear();
        }

        public void Depart(Vehicle vehicle)
        {
            departed.Add(vehicle);
        }

        public List<Vehicle> GetArrived()
        {
            return arrived;
        }

        public List<Vehicle> GetDeparted()
        {
            return departed;
        }

        public List<Vehicle> GetVehicles()
        {
            return vehicles;
        }
    }
}
