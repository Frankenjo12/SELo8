using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCarTransport.Models
{
    public class Train
    {
        public Train(VehicleTrainType vehicleTrainType)
        {
            _VehicleTrainType = vehicleTrainType;
            Capacity = DetermineCapacity();
            Vehicles = new List<Vehicle>();
        }

        public  VehicleTrainType _VehicleTrainType { get; set; }
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public int DetermineCapacity()
        {
            if(_VehicleTrainType == VehicleTrainType.Small)
            {
                return 8;
            }
            else
            {
                return 6;
            }
        }

        public bool ReachedCapacity()
        {
            if(Vehicles.Count() == Capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString() 
            => $"Vehicle and train types:{_VehicleTrainType}\tCapacity: {Capacity}";
    }
}
