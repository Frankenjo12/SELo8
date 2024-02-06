using TrainCarTransport.Models;
using TrainCarTransport.Repo;

namespace UnitTests
{
    public class Tests
    {
        private IVehicleRepo vRepo;
        private Employee e;
        private Vehicle v;
        private Train t;

        [SetUp]
        public void Setup()
        {
            e = new Employee("Franko", 15);
            v = new Car(FuelType.Gas);
            t = new Train(VehicleTrainType.Small);
            vRepo = new VehicleRepo();
        }

        [Test]
        public void TestVehicleParking()
        {
            e.ParkVehicle(v, t);
            if(t.Vehicles.Contains(v))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestAddingVehicles()
        {
            vRepo.AddVehicle(v);
            if(vRepo.GetVehicles().Contains(v))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestVehiclePriceCalculation()
        {
            Assert.Equals(v.Price, 7);
        }

        [Test]
        public void TestDepartures()
        {
            vRepo.Depart(v);
            if(vRepo.GetDeparted().Contains(v))
            {
                Assert.Pass();
            }
            else { Assert.Fail(); }
        }

        [Test]
        public void TestArrivals()
        {
            vRepo.Arrive(v);
            if (vRepo.GetArrived().Contains(v))
            {
                Assert.Pass();
            }
            else { Assert.Fail(); }
        }

        [Test]
        public void TestFuleFill()
        {
            v.Fuel = 10;
            e.FillVehicle(v);
            Assert.Equals(v.Fuel, 100);
        }

        [Test]
        public void TestSalaryCalculation()
        {
            e.TicketPercentage = 50;
            v.Price = 10;
            double targetResult = 5;
            Assert.Equals(e.CalculateSalary(v), targetResult);
        }

        [Test]
        public void TestTrainCapacity()
        {
            e.ParkVehicle(v, t);
            t.Capacity = 1;
            Assert.IsTrue(t.ReachedCapacity());
        }
    }
}