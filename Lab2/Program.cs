using System;
using System.Collections.Generic;

namespace Lab2
{
    internal abstract class Car
    {
        public bool IsStarted = false;
        public bool IsFueled = false;
        public abstract void Start();
        public abstract void Stop();
        public abstract void Fuel();
        public abstract void Drive();

        public void TestDrive(Car car)
        {
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
    }

    internal class PetrolCar : Car
    {

        public override void Start()
        {
            if (!IsStarted)
            {
                Console.WriteLine("Starting car");
                IsStarted = true;
            }
            else
            {
                Console.WriteLine("Car is already started");
            }
        }

        public override void Stop()
        {
            if (IsStarted)
            {
                Console.WriteLine("Stopping car");
                IsStarted = false;
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }

        public override void Fuel()
        {
            if (!IsFueled)
            {
                Console.WriteLine("Fueling up car with petrol");
                IsFueled = true;
            }
            else
            {
                Console.WriteLine("Car is already fueled up with petrol");
            }
        }

        public override void Drive()
        {
            if (IsStarted)
            {
                if (IsFueled)
                {
                    Console.WriteLine("Driving on petrol");
                    IsFueled = false;
                }
                else
                {
                    Console.WriteLine("Not enough petrol, fuel up");
                }
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }
    }

    internal class GasCar : Car
    {

        public override void Start()
        {
            if (!IsStarted)
            {
                Console.WriteLine("Starting car");
                IsStarted = true;
            }
            else
            {
                Console.WriteLine("Car is already started");
            }
        }

        public override void Stop()
        {
            if (IsStarted)
            {
                Console.WriteLine("Stopping car");
                IsStarted = false;
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }
        public override void Fuel()
        {
            if (!IsFueled)
            {
                Console.WriteLine("Fueling up car with gas");
                IsFueled = true;
            }
            else
            {
                Console.WriteLine("Car is already fueled up with gas");
            }
        }

        public override void Drive()
        {
            if (IsStarted && IsFueled)
            {
                Console.WriteLine("Driving on gas");
                IsFueled= false;
            }
            else if (!IsFueled) {
                Console.WriteLine("Not enough gas, fuel up");

            }
            else
            {
                Console.WriteLine("Car is not started");

            }
        }

    }

    internal class ElectricCar : Car
    {
        public override void Start()
        {
            if (!IsStarted)
            {
                Console.WriteLine("Starting car");
                IsStarted = true;
            }
            else
            {
                Console.WriteLine("Car is already started");
            }
        }

        public override void Stop()
        {
            if (IsStarted)
            {
                Console.WriteLine("Stopping car");
                IsStarted = false;
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }

        public override void Fuel()
        {
            if (!IsFueled)
            {
                Console.WriteLine("Charging car");
                IsFueled = true;
            }
            else
            {
                Console.WriteLine("Car is already charged");
            }
        }

        public override void Drive()
        {
            if (IsStarted)
            {
                if (IsFueled)
                {
                    Console.WriteLine("Driving on electricity");
                    IsFueled = false;
                }
                else
                {
                    Console.WriteLine("Not enough electricity, charge the car");
                }
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }
    }

    

        internal class Program
        {
            public static void Main(string[] args)
            {
            ElectricCar electricCar = new ElectricCar();
            PetrolCar petrolCar = new PetrolCar();
            GasCar gasCar = new GasCar();
            var carList = new List<Car>();
            carList.Add(petrolCar);
            carList.Add(gasCar);
            carList.Add(electricCar);
            foreach (var car in carList)
            {
                car.TestDrive(car);
                Console.WriteLine();
            }
        }
        }
    
}