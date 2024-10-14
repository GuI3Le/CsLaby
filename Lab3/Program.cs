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
            var petrolCar = new PetrolCar();
            var electricCar = new ElectricCar();
            var gasCar = new GasCar();
            var petrolGasCar = new PetrolGasCar();
            var petrolElectricCar = new PetrolElectricCar();
            // petrolGasCar = (petrolCar);
            var carList = new List<ICar>();
            carList.Add(petrolCar);
            carList.Add(electricCar);
            carList.Add(gasCar);
            carList.Add(petrolGasCar);
            carList.Add(petrolElectricCar);
            foreach (var car in carList)
            {
                TestDrive(car);
                Console.WriteLine();
            }

            Test();
        }
    }
}