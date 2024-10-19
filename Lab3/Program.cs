using System;
using System.Collections.Generic;

namespace Lab3
{
    internal class Program
    {
        private static void TestDrive(ICar car)
        {
            car.Fuel();
            car.Fuel();
            car.Drive();
            car.Start();
            car.Start();
            car.Drive();
            car.Drive();
            car.Drive();
            car.Stop();
            car.Stop();
        }

        private static void Test()
        {
            var testCar1 = new PetrolElectricCar();
            Console.WriteLine("Refueling petrol test");
            ((IPetrolCar)testCar1).Fuel();
            Console.WriteLine("Charging test");
            ((ICar)testCar1).Fuel();
        }

        public static void Main(string[] args)
        {
            var carList = new List<ICar>
            {
                new PetrolCar(),
                new ElectricCar(),
                new GasCar(),
                new PetrolElectricCar(),
                new PetrolGasCar()
            };
            foreach (var car in carList)
            {
                TestDrive(car);
                Console.WriteLine();
            }
            // Test();
        }
    }
}