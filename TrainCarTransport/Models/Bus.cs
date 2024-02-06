using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCarTransport.Models
{
    public class Bus : Vehicle
    {
        public Bus(FuelType fuelType) : base(fuelType)
        {
        }

        public override int CalculatePrice() => 8;

        public override VehicleTrainType DetermineVehicleType() => VehicleTrainType.Large;
    }
}
