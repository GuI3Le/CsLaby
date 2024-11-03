using System;

namespace Lab3b
{
    public class PetrolGasCar : ICar, IPetrolCar, IGasCar
    {
        public PetrolGasCar()
        {
            IsCombustionEngineRunning = false;
            IsPetrolTankFull = false;
            IsGasCylinderFull = false;
        }


        public void Start()
        {
            if (!IsCombustionEngineRunning)
            {
                IsCombustionEngineRunning = true;
                Console.WriteLine("Starting petrol gas car");
            }
            else
            {
                Console.WriteLine("Petrol gas car is already running");
            }
        }

        public void Stop()
        {
            if (IsCombustionEngineRunning)
            {
                IsCombustionEngineRunning = false;
                Console.WriteLine("Stopping petrol gas car");
            }
            else
            {
                Console.WriteLine("Petrol gas car is not running");
            }
        }

        void ICar.Fuel()
        {
            IsPetrolTankFull = true;
            IsGasCylinderFull = true;
            Console.WriteLine("Fueling up petrol tank and gas cylinder");
        }

        void ICar.Drive()
        {
        }

        public bool IsGasCylinderFull { get; set; }

        void IGasCar.Fuel()
        {
            IsGasCylinderFull = true;
            Console.WriteLine("Fueling up gas cylinder");
        }

        void IGasCar.Drive()
        {
            IsGasCylinderFull = false;
            Console.WriteLine("Driving car on gas");
        }

        public bool IsCombustionEngineRunning { get; set; }

        public bool IsPetrolTankFull { get; set; }

        void IPetrolCar.Fuel()
        {
            IsPetrolTankFull = true;
            Console.WriteLine("Fueling up petrol tank");
        }

        void IPetrolCar.Drive()
        {
            IsPetrolTankFull = false;
            Console.WriteLine("Driving car on petrol");
        }

        private void Fuel()
        {
            if (!IsPetrolTankFull && !IsGasCylinderFull)
                ((ICar)this).Fuel();
            else if (!IsGasCylinderFull)
                ((IGasCar)this).Fuel();
            else if (!IsPetrolTankFull)
                ((IPetrolCar)this).Fuel();
            else
                Console.WriteLine("Petrol tank and gas cylinder are already full");
        }

        private void Drive()
        {
            if (IsCombustionEngineRunning)
            {
                if (IsGasCylinderFull)
                    ((IGasCar)this).Fuel();
                else if (IsPetrolTankFull)
                    ((IPetrolCar)this).Fuel();
                else
                    Console.WriteLine("Cannot drive, both gas cylinder and petrol tank are empty");
            }
            else
            {
                Console.WriteLine("Combustion engine is not running");
            }
        }
    }
}