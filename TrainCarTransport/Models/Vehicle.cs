using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCarTransport.Models
{
    public abstract class Vehicle
    {
        protected Vehicle(FuelType fuelType)
        {
            Fuel = GenerateFuel();
            _FuelType = fuelType;
            Price = CalculatePrice();
            VehicleType = DetermineVehicleType();
        }

        private int GenerateFuel()
        {
            return new Random().Next(1, 100);
        }

        public int Fuel { get; set; }
        public int Price { get; set; }
        public FuelType _FuelType { get; set; }
        public VehicleTrainType VehicleType { get; set; }


        public override string ToString() 
            => $"Fuel: {Fuel}\tPrice: {Price}\tFuelType: {_FuelType}\tVehicleType:{VehicleType}";

        public abstract int CalculatePrice();
        public abstract VehicleTrainType DetermineVehicleType();
    }
}
