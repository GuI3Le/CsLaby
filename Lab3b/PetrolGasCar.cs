using System;

namespace Lab3b
{
    public class PetrolGasCar: ICar,IPetrolCar,IGasCar
    {
        private bool _combustionEngineRunning;
        private bool _petrolTankFull;
        private bool _gasCylinderFull;

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

        public bool IsGasCylinderFull
        {
            get => _gasCylinderFull;
            set => _gasCylinderFull = value;
        }

        public PetrolGasCar()
        {
            _combustionEngineRunning = false;
            _petrolTankFull = false;
            _gasCylinderFull = false;
        }

        public void Start()
        {
            if (!_combustionEngineRunning)
            {
                _combustionEngineRunning = true;
                Console.WriteLine("Starting petrol gas car");
            }
            else
            {
                Console.WriteLine("Petrol gas car is already running");
            }
        }

        public void Stop()
        {
            if (_combustionEngineRunning)
            {
                _combustionEngineRunning = false;
                Console.WriteLine("Stopping petrol gas car");
            }
            else
            {
                Console.WriteLine("Petrol gas car is not running");
            }
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

        void IGasCar.Fuel()
        {
            if (!_gasCylinderFull)
            {
                _gasCylinderFull = true;
                Console.WriteLine("Fueling up gas cylinder");
            }
            else
            {
                Console.WriteLine("Gas cylinder is already full");
            }
        }

        void ICar.Fuel()
        {
            if (_petrolTankFull && _gasCylinderFull)
            {
                Console.WriteLine("Petrol tank and gas cylinder are full");
            }
            else
            {
                ((IPetrolCar)this).Fuel();
                ((IGasCar)this).Fuel();
            }
        }
        void Fuel()
        {
            ((ICar)this).Fuel();
        }

        void IPetrolCar.Drive()
        {
            if (_petrolTankFull && _combustionEngineRunning)
            {
                _petrolTankFull = false;
                Console.WriteLine("Driving car on petrol");
            }else if (!_petrolTankFull)
            {
                Console.WriteLine("Not enough petrol, fuel up");
            }else
            {
                Console.WriteLine("Combustion engine is not running");
            }
        }

        void IGasCar.Drive()
        {
            if (_gasCylinderFull && _combustionEngineRunning)
            {
                _gasCylinderFull = false;
                Console.WriteLine("Driving car on gas");
            }else if (!_gasCylinderFull)
            {
                Console.WriteLine("Not enough gas, fuel up");
            }
            else
            {
                Console.WriteLine("Combustion engine is not running");
            }
        }

        void ICar.Drive()
        {
            if (_combustionEngineRunning)
            {
                if (_gasCylinderFull)
                {
                    ((IGasCar)this).Fuel();
                }
                else
                {
                    ((IPetrolCar)this).Fuel();
                }
            }
            else
            {
                Console.WriteLine("Combustion engine is not running");
            }
        }

        void Drive()
        {
            ((ICar)this).Drive();
        }
    }
}