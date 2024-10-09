using System;

namespace Lab2
{
    internal abstract class Car
    {
        protected bool IsStarted;
        public abstract void Start();
        public abstract void Stop();
        public abstract void Fuel();
        public abstract void Drive();
    }

    internal class PetrolCar : Car
    {
        private bool _isFueled;

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
            if (!_isFueled)
            {
                Console.WriteLine("Fueling up car with petrol");
                _isFueled = true;
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
                if (_isFueled)
                {
                    Console.WriteLine("Driving on petrol");
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

        // class GasCar : Car
        // {
        //     
        // }
        //
        // class ElectricCar : Car
        // {
        //     
        // }

        internal class Program
        {
            public static void Main(string[] args)
            {
            }
        }
    }
}