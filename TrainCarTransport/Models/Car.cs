using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCarTransport.Models
{
    public class Car : Vehicle
    {
        public Car(FuelType fuelType) : base(fuelType)
        {
        }

        public override int CalculatePrice() => 7;

        public override VehicleTrainType DetermineVehicleType() => VehicleTrainType.Small;
    }
}
