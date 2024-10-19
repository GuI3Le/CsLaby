using System;

namespace Lab3b
{
    public class PetrolElectricCar : ICar, IPetrolCar, IElectricCar
    {
        private bool _electricEngineRunning;
        private bool _batteryCharged;
        private bool _combustionEngineRunning;
        private bool _petrolTankFull;
        
        public bool IsElectricEngineRunning
        {
            get=>_electricEngineRunning;
            set => _electricEngineRunning=value;
        }

        public bool IsBatteryCharged
        {
            get=>_batteryCharged;
            set => _batteryCharged = value;
        }

        public bool IsCombustionEngineRunning
        {
            get => _combustionEngineRunning;
            set => _combustionEngineRunning = value;
        }

        public bool IsPetrolTankFull
        {
            get => _petrolTankFull;
            set => _petrolTankFull = value;
        }

        public PetrolElectricCar()
        {
            _electricEngineRunning=false;
            _batteryCharged=false;
            _combustionEngineRunning=false;
            _petrolTankFull=false;
        }

        void IPetrolCar.Start()
        {
            if (!_combustionEngineRunning)
            {
                _combustionEngineRunning = true;
                Console.WriteLine("Starting combustion engine");
            }
            else
            {
                Console.WriteLine("Combustion engine already running");
            }
        }

        void IElectricCar.Start()
        {
            if (!_electricEngineRunning)
            {
                _electricEngineRunning=true;
                Console.WriteLine("Starting electric engine");
            }
            else
            {
                Console.WriteLine("Electric engine is already running");
            }
        }

        void ICar.Start()
        {
            if (!_electricEngineRunning && !_combustionEngineRunning)
            {
                ((IElectricCar)this).Start();
                ((IPetrolCar)this).Start();
            }
            else
            {
                Console.WriteLine("Combustion and electric engine are already running");
            }
        }

        public void Start()
        {
            ((ICar)this).Start();
        }

        void IPetrolCar.Stop()
        {
            if (_combustionEngineRunning)
            {
                _combustionEngineRunning = false;
                Console.WriteLine("Stopping combustion engine");
            }
            else
            {
                Console.WriteLine("Combustion engine is not started");
            }
        }

        void IElectricCar.Stop()
        {
            if (_electricEngineRunning)
            {
                _electricEngineRunning=false;
                Console.WriteLine("Stopping electric engine");
            }
            else
            {
                Console.WriteLine("Electric engine is not running");
            }
        }

        void ICar.Stop()
        {
            if (_electricEngineRunning && _combustionEngineRunning)
            {
                ((IElectricCar)this).Stop();
                ((IPetrolCar)this).Stop();
            }else if (_electricEngineRunning)
            {
                ((IElectricCar)this).Stop();
            }else if (_electricEngineRunning)
            {
                ((IPetrolCar)this).Stop();
            }
            else
            {
                Console.WriteLine("Neither petrol nor electric engine is running");
            }
        }

        public void Stop()
        {
            ((ICar)this).Stop();
        }

        void IPetrolCar.Fuel()
        {
            if (!_petrolTankFull)
            {
                _petrolTankFull = true;
                Console.WriteLine("Fueling up petrol tank");
            }
            else
            {
                Console.WriteLine("Petrol tank is already full");
            }
        }

        void IElectricCar.Fuel()
        {
            if (!_batteryCharged)
            {
                _batteryCharged=true;
                Console.WriteLine("Charging battery");
            }
            else
            {
                Console.WriteLine("Battery is already charged");
            }
        }

        void ICar.Fuel()
        {
            if (!_batteryCharged && !_petrolTankFull)
            {
                ((IPetrolCar)this).Fuel();
                ((IElectricCar)this).Fuel();
            }else if (!_batteryCharged)
            {
                ((IElectricCar)this).Fuel();
            }else if (_petrolTankFull)
            {
                ((IPetrolCar)this).Fuel();
            }
            else
            {
                Console.WriteLine("Petrol tank and battery are already full");
            }
        }

        public void Fuel()
        {
            ((ICar)this).Fuel();
        }

        void IPetrolCar.Drive()
        {
            if (_petrolTankFull && _combustionEngineRunning)
            {
                _petrolTankFull = false;
                Console.WriteLine("Driving car using combustion engine");
            }else if (!_petrolTankFull)
            {
                Console.WriteLine("Not enough petrol, fuel up");
            }else
            {
                Console.WriteLine("Combustion engine is not running");
            }
        }

        void IElectricCar.Drive()
        {
            if (_batteryCharged && _electricEngineRunning)
            {
                _batteryCharged=false;
                Console.WriteLine("Driving car using electric engine");
            }else if (!_electricEngineRunning)
            {
                Console.WriteLine("Not enough battery, charge");
            }
            else
            {
                Console.WriteLine("Electric engine is not running");
            }
        }

        void ICar.Drive()
        {
            if (_electricEngineRunning)
            {
                if (_batteryCharged)
                {
                    ((IElectricCar)this).Drive();
                }
                else
                {
                    Console.WriteLine("Not enough battery, charge");
                }
            }else if (_combustionEngineRunning)
            {
                if (_petrolTankFull)
                {
                    ((IPetrolCar)this).Drive();
                }
                else
                {
                    Console.WriteLine("Not enough petrol, fuel up");
                }
            }
            else
            {
                Console.WriteLine("Neither electric nor petrol engine is running");
            }
        }

        public void Drive()
        {
            ((ICar)this).Drive();
        }
    }
}