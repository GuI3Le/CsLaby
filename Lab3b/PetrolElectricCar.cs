using System;

namespace Lab3b
{
    public class PetrolElectricCar : ICar, IPetrolCar, IElectricCar
    {
        public PetrolElectricCar()
        {
            IsElectricEngineRunning = false;
            IsBatteryCharged = false;
            IsCombustionEngineRunning = false;
            IsPetrolTankFull = false;
        }

        void ICar.Start()
        {
            IsCombustionEngineRunning = true;
            IsElectricEngineRunning = true;
            Console.WriteLine("Starting electric and combustion engine");
        }

        void ICar.Stop()
        {
            IsElectricEngineRunning = false;
            IsCombustionEngineRunning = false;
            Console.WriteLine("Stopping combustion and electric engine");
        }

        void ICar.Fuel()
        {
            IsBatteryCharged = true;
            IsPetrolTankFull = true;
            Console.WriteLine("Charging battery and fueling up with petrol");
        }

        void ICar.Drive()
        {
            IsPetrolTankFull = false;
            IsBatteryCharged = false;
            Console.WriteLine("Driving car using electric and petrol engine");
        }

        public bool IsElectricEngineRunning { get; set; }

        public bool IsBatteryCharged { get; set; }

        void IElectricCar.Start()
        {
            IsElectricEngineRunning = true;
            Console.WriteLine("Starting electric engine");
        }

        void IElectricCar.Stop()
        {
            IsElectricEngineRunning = false;
            Console.WriteLine("Stopping electric engine");
        }

        void IElectricCar.Fuel()
        {
            IsBatteryCharged = true;
            Console.WriteLine("Charging battery");
        }

        void IElectricCar.Drive()
        {
            IsBatteryCharged = false;
            Console.WriteLine("Driving car using electric engine");
        }

        public bool IsCombustionEngineRunning { get; set; }

        public bool IsPetrolTankFull { get; set; }

        void IPetrolCar.Start()
        {
            IsCombustionEngineRunning = true;
            Console.WriteLine("Starting combustion engine");
        }

        void IPetrolCar.Stop()
        {
            IsCombustionEngineRunning = false;
            Console.WriteLine("Stopping combustion engine");
        }

        void IPetrolCar.Fuel()
        {
            IsPetrolTankFull = true;
            Console.WriteLine("Fueling up petrol tank");
        }

        void IPetrolCar.Drive()
        {
            IsPetrolTankFull = false;
            Console.WriteLine("Driving car using combustion engine");
        }

        public void Start()
        {
            if (!IsElectricEngineRunning && !IsElectricEngineRunning)
                ((ICar)this).Start();
            else if (!IsElectricEngineRunning)
                ((IElectricCar)this).Start();
            else if (!IsPetrolTankFull)
                ((IPetrolCar)this).Start();
            else
                Console.WriteLine("Electric and petrol engine are already running");
        }

        public void Stop()
        {
            if (IsElectricEngineRunning && IsCombustionEngineRunning)
                ((ICar)this).Stop();
            else if (IsElectricEngineRunning)
                ((IElectricCar)this).Stop();
            else if (IsPetrolTankFull)
                ((IPetrolCar)this).Stop();
            else
                Console.WriteLine("Electric and petrol engine are already stopped");
        }

        public void Fuel()
        {
            if (!IsBatteryCharged && !IsPetrolTankFull)
                ((ICar)this).Fuel();
            else if (!IsBatteryCharged)
                ((IElectricCar)this).Fuel();
            else if (IsPetrolTankFull)
                ((IPetrolCar)this).Fuel();
            else
                Console.WriteLine("Petrol tank and battery are already full");
        }

        public void Drive()
        {
            if (IsElectricEngineRunning)
            {
                if (IsBatteryCharged)
                    ((IElectricCar)this).Drive();
                else
                    Console.WriteLine("Not enough battery, charge");
            }
            else if (IsCombustionEngineRunning)
            {
                if (IsPetrolTankFull)
                    ((IPetrolCar)this).Drive();
                else
                    Console.WriteLine("Not enough petrol, fuel up");
            }
            else
            {
                Console.WriteLine("Neither electric nor petrol engine is running");
            }
        }
    }
}