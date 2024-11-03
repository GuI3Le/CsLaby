using System;

namespace Lab3b
{
    public class PetrolCar : ICar, IPetrolCar
    {
        public PetrolCar()
        {
            IsCombustionEngineRunning = false;
            IsPetrolTankFull = false;
        }

        public void Start()
        {
            if (!IsCombustionEngineRunning)
            {
                IsCombustionEngineRunning = true;
                Console.WriteLine("Starting petrol car");
            }
            else
            {
                Console.WriteLine("Petrol engine already running");
            }
        }

        public void Stop()
        {
            if (IsCombustionEngineRunning)
            {
                IsCombustionEngineRunning = false;
                Console.WriteLine("Stopping petrol car");
            }
            else
            {
                Console.WriteLine("Petrol engine is not started");
            }
        }

        public void Fuel()
        {
            if (!IsPetrolTankFull)
            {
                IsPetrolTankFull = true;
                Console.WriteLine("Fueling up car with petrol");
            }
            else
            {
                Console.WriteLine("Car is already fueled up with petrol");
            }
        }

        public void Drive()
        {
            if (IsPetrolTankFull && IsCombustionEngineRunning)
            {
                IsPetrolTankFull = false;
                Console.WriteLine("Driving car on petrol");
            }
            else if (!IsPetrolTankFull)
            {
                Console.WriteLine("Not enough petrol, fuel up");
            }
            else
            {
                Console.WriteLine("Combustion engine is not running");
            }
        }

        public bool IsCombustionEngineRunning { get; set; }

        public bool IsPetrolTankFull { get; set; }
    }
}