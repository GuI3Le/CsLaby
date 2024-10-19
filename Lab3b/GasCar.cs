using System;

namespace Lab3b
{
    public class GasCar : ICar, IGasCar
    {
        private bool _combustionEngineRunning;
        private bool _gasCylinderFull;

        public bool IsCombustionEngineRunning
        {
            get => _combustionEngineRunning;
            set => _combustionEngineRunning = value;
        }

        public bool IsGasCylinderFull
        {
            get => _gasCylinderFull;
            set => _gasCylinderFull = value;
        }

        public GasCar()
        {
            _combustionEngineRunning = false;
            _gasCylinderFull = false;
        }

        public void Start()
        {
            if (!_combustionEngineRunning)
            {
                _combustionEngineRunning = true;
                Console.WriteLine("Starting gas car");
            }
            else
            {
                Console.WriteLine("Gas car is already running");
            }
        }

        public void Stop()
        {
            if (_combustionEngineRunning)
            {
                _combustionEngineRunning = false;
                Console.WriteLine("Stopping gas car");
            }
            else
            {
                Console.WriteLine("Gas car is not running");
            }
        }

        public void Fuel()
        {
            if (!_gasCylinderFull)
            {
                _gasCylinderFull = true;
                Console.WriteLine("Fueling up car with gas");
            }
            else
            {
                Console.WriteLine("Car is already fueled with gas");
            }
        }

        public void Drive()
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
    }
}