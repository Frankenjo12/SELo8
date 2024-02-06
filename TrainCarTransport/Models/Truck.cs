using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCarTransport.Models
{
    public class Truck : Vehicle
    {
        public Truck(FuelType fuelType) : base(fuelType)
        {
        }

        public override int CalculatePrice() => 10;

        public override VehicleTrainType DetermineVehicleType() => VehicleTrainType.Large;
    }
}
