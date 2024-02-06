using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainCarTransport.Models;
using TrainCarTransport.Repo;

namespace TrainCarTransport
{
    class Program
    {
        static IEmployeeRepo eRepo = new EmployeeRepo();
        static IVehicleRepo vRepo = new VehicleRepo();

        static void Main(string[] args)
        {

            eRepo.AddEmployee(new Employee("Karlo", 10));
            eRepo.AddEmployee(new Employee("Leon", 11));

            vRepo.AddVehicle(new Car(FuelType.Gas));
            vRepo.AddVehicle(new Van(FuelType.Battery));
            vRepo.AddVehicle(new Bus(FuelType.Battery));
            vRepo.AddVehicle(new Truck(FuelType.Gas));

            while (true)
            {
                Console.WriteLine("Enter command(ticket, employee, vehicles):");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "ticket":
                        BuyTicket();
                        break;
                    case "employee":
                        ShowEmployees();
                        break;
                    case "vehicles":
                        ShowVehicles();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void ShowVehicles()
        {
            List<Vehicle> vehicles = vRepo.GetVehicles();
            List<Vehicle> arrived = vRepo.GetArrived();
            List<Vehicle> departed = vRepo.GetDeparted();

            Console.WriteLine("Available vehicles:\n");
            vehicles.ForEach(vehicle =>
            {
                Console.WriteLine($"Fuel:{vehicle.Fuel}, Price:{vehicle.Price}, FuelType:{vehicle._FuelType}, VehicleType:{vehicle.VehicleType}\n");
            });

            Console.WriteLine("Arrived vehicles:\n");
            arrived.ForEach(vehicle =>
            {
                Console.WriteLine($"Fuel:{vehicle.Fuel}, Price:{vehicle.Price}, FuelType:{vehicle._FuelType}, VehicleType:{vehicle.VehicleType}\n");
            });

            Console.WriteLine("Departed vehicles:\n");
            departed.ForEach(vehicle =>
            {
                Console.WriteLine($"Fuel:{vehicle.Fuel}, Price:{vehicle.Price}, FuelType:{vehicle._FuelType}, VehicleType:{vehicle.VehicleType}\n");
            });
        }

        private static void ShowEmployees()
        {
            List<Employee> employees = eRepo.GetAll();

            Console.WriteLine("Employees:\n");
            employees.ForEach(employee =>
                Console.WriteLine($"Name:{employee.Name}, Percentage:{employee.TicketPercentage}, TotalIncome:{employee.TotalIncome}"));
        }

        private static void BuyTicket()
        {
            Vehicle vehicle = ChooseRandomVehicle();
            Console.WriteLine($"Your vehicle: {vehicle}");
            Employee employee = ChooseRandomEmployee();
            Console.WriteLine($"Your employee: {employee}");
            Console.WriteLine($"Employee earnings: {employee.CalculateSalary(vehicle)}");

            Console.WriteLine($"Vehicle fuel at: {vehicle.Fuel}");
            if (vehicle.Fuel <= 10)
            {
                employee.FillVehicle(vehicle);
                Console.WriteLine("Employee filled vehicle");
            }

            if(vehicle.VehicleType == VehicleTrainType.Small)
            {
                employee.ParkVehicle(vehicle, new Train(VehicleTrainType.Small));
                Console.WriteLine("Vehicle parked in small train");
            }
            else
            {
                employee.ParkVehicle(vehicle, new Train(VehicleTrainType.Large));
                Console.WriteLine("Vehicle parked in large train");
            }

            vRepo.Depart(vehicle);
            Console.WriteLine("Vehicle Departed");

            vRepo.Arrive(vehicle);
            Console.WriteLine("Vehicle Arrived");
        }

        private static Employee ChooseRandomEmployee()
        {
            List<Employee> employees = eRepo.GetAll();
            Random random = new Random();
            int eIndex = random.Next(employees.Count());

            return employees[eIndex];
        }

        private static Vehicle ChooseRandomVehicle()
        {
            List<Vehicle> vehicles = vRepo.GetVehicles();
            Random random = new Random();
            int vIndex = random.Next(vehicles.Count());

            return vehicles[vIndex];
        }
    }
}
