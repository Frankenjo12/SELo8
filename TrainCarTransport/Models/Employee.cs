using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCarTransport.Models
{
    public class Employee
    {
        public Employee(string name, int ticketPercentage)
        {
            Name = name;
            TicketPercentage = ticketPercentage;
        }

        public string Name { get; set; }
        public int TicketPercentage { get; set; }
        public double TotalIncome { get; set; }

        public void FillVehicle(Vehicle vehicle)
        {
            vehicle.Fuel = 100;
        }

        public void ParkVehicle(Vehicle vehicle, Train train)
        {
            if(!train.ReachedCapacity())
            {
                train.Vehicles.Add(vehicle);
            }
        }

        public double CalculateSalary(Vehicle vehicle)
        {
            double salary = vehicle.Price * (TicketPercentage / 100.0);
            TotalIncome += salary;
            return salary;
        }

        public override string ToString() => $"{Name} {TicketPercentage}";
    }
}
