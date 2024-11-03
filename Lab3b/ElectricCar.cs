using System;

namespace Lab3b
{
    public class ElectricCar : ICar, IElectricCar
    {
        public ElectricCar()
        {
            IsElectricEngineRunning = false;
            IsBatteryCharged = false;
        }

        public void Start()
        {
            if (!IsElectricEngineRunning)
            {
                IsElectricEngineRunning = true;
                Console.WriteLine("Starting electric car");
            }
            else
            {
                Console.WriteLine("Electric car is already running");
            }
        }

        public void Stop()
        {
            if (IsElectricEngineRunning)
            {
                IsElectricEngineRunning = false;
                Console.WriteLine("Stopping electric car");
            }
            else
            {
                Console.WriteLine("Electric car is not running");
            }
        }

        public void Fuel()
        {
            if (!IsBatteryCharged)
            {
                IsBatteryCharged = true;
                Console.WriteLine("Charging electric car");
            }
            else
            {
                Console.WriteLine("Car is already charged");
            }
        }

        public void Drive()
        {
            if (IsBatteryCharged && IsElectricEngineRunning)
            {
                IsBatteryCharged = false;
                Console.WriteLine("Driving electric car");
            }
            else if (!IsElectricEngineRunning)
            {
                Console.WriteLine("Not enough battery, charge");
            }
            else
            {
                Console.WriteLine("Car is not running");
            }
        }

        public bool IsElectricEngineRunning { get; set; }

        public bool IsBatteryCharged { get; set; }
    }
}