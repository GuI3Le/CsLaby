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
            
                _combustionEngineRunning = true;
                Console.WriteLine("Starting combustion engine");
            
        }

        void IElectricCar.Start()
        {
           
                _electricEngineRunning=true;
                Console.WriteLine("Starting electric engine");
            
        }

        void ICar.Start()
        {
                _combustionEngineRunning = true;
                _electricEngineRunning=true;
                Console.WriteLine("Starting electric and combustion engine");
        }

        public void Start()
        {
            if (!_electricEngineRunning && !_electricEngineRunning)
            {
                ((ICar)this).Start();
            }else if (!_electricEngineRunning)
            {
                ((IElectricCar)this).Start();
            }else if (!_petrolTankFull)
            {
                ((IPetrolCar)this).Start();
            }
            else
            {
                Console.WriteLine("Electric and petrol engine are already running");
            }
        }

        void IPetrolCar.Stop()
        {
                _combustionEngineRunning = false;
                Console.WriteLine("Stopping combustion engine");
        }

        void IElectricCar.Stop()
        {
            
                _electricEngineRunning=false;
                Console.WriteLine("Stopping electric engine");
            
        }

        void ICar.Stop()
        {
            _electricEngineRunning=false;
            _combustionEngineRunning=false;
            Console.WriteLine("Stopping combustion and electric engine");
        }

        public void Stop()
        {
            if (_electricEngineRunning && _combustionEngineRunning)
            {
                ((ICar)this).Stop();
            }else if (_electricEngineRunning)
            {
                ((IElectricCar)this).Stop();
            }else if (_petrolTankFull)
            {
                ((IPetrolCar)this).Stop();
            }
            else
            {
                Console.WriteLine("Electric and petrol engine are already stopped");
            }
        }

        void IPetrolCar.Fuel()
        {
            
                _petrolTankFull = true;
                Console.WriteLine("Fueling up petrol tank");
        }

        void IElectricCar.Fuel()
        {
            
                _batteryCharged=true;
                Console.WriteLine("Charging battery");
            
        }

        void ICar.Fuel()
        {
            _batteryCharged=true;
            _petrolTankFull=true;
            Console.WriteLine("Charging battery and fueling up with petrol");
        }

        public void Fuel()
        {
            if (!_batteryCharged && !_petrolTankFull)
            {
                ((ICar)this).Fuel();
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

        void IPetrolCar.Drive()
        {
            
                _petrolTankFull = false;
                Console.WriteLine("Driving car using combustion engine");
            
        }

        void IElectricCar.Drive()
        {
            
                _batteryCharged=false;
                Console.WriteLine("Driving car using electric engine");
            
        }

        void ICar.Drive()
        {
            _petrolTankFull = false;
            _batteryCharged = false;
            Console.WriteLine("Driving car using electric and petrol engine");
        }

        public void Drive()
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
    }
}