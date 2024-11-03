using System;

namespace Lab3b
{
    public class GasCar : ICar, IGasCar
    {
        public GasCar()
        {
            IsCombustionEngineRunning = false;
            IsGasCylinderFull = false;
        }

        public void Start()
        {
            if (!IsCombustionEngineRunning)
            {
                IsCombustionEngineRunning = true;
                Console.WriteLine("Starting gas car");
            }
            else
            {
                Console.WriteLine("Gas car is already running");
            }
        }

        public void Stop()
        {
            if (IsCombustionEngineRunning)
            {
                IsCombustionEngineRunning = false;
                Console.WriteLine("Stopping gas car");
            }
            else
            {
                Console.WriteLine("Gas car is not running");
            }
        }

        public void Fuel()
        {
            if (!IsGasCylinderFull)
            {
                IsGasCylinderFull = true;
                Console.WriteLine("Fueling up car with gas");
            }
            else
            {
                Console.WriteLine("Car is already fueled with gas");
            }
        }

        public void Drive()
        {
            if (IsGasCylinderFull && IsCombustionEngineRunning)
            {
                IsGasCylinderFull = false;
                Console.WriteLine("Driving car on gas");
            }
            else if (!IsGasCylinderFull)
            {
                Console.WriteLine("Not enough gas, fuel up");
            }
            else
            {
                Console.WriteLine("Combustion engine is not running");
            }
        }

        public bool IsCombustionEngineRunning { get; set; }

        public bool IsGasCylinderFull { get; set; }
    }
}