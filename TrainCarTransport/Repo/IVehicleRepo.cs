using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainCarTransport.Models;

namespace TrainCarTransport.Repo
{
    public interface IVehicleRepo
    {
        public List<Vehicle> GetVehicles();
        public void AddVehicle(Vehicle vehicle);
        public void ClearVehicles();
        public List<Vehicle> GetArrived();
        public List<Vehicle> GetDeparted();
        public void Depart(Vehicle vehicle);
        public void Arrive(Vehicle vehicle);
    }
}
