using System;
using System.Collections.Generic;

namespace Lab3
{
    
    internal class Program
    {
        static void TestDrive(ICar car)
        {
            Console.WriteLine("Testing car");
            car.Fuel();
            car.Fuel();
            car.Drive();
            car.Start();
            car.Start();
            car.Drive();
            car.Drive();
            car.Stop();
            car.Stop();
        }
        
        public static void Main(string[] args)
        {
            PetrolCar petrolCar = new PetrolCar();
            var carList = new List<ICar>();
            carList.Add(petrolCar);
            foreach (var car in carList)
            {
                TestDrive(car);
                Console.WriteLine();
            }
        }
    }
}