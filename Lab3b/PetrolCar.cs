using System;

namespace Lab3b
{
    public class PetrolCar: ICar, IPetrolCar
    {
        private bool _isCombustionEngineRunning;

        public bool IsCombustionEngineRunning
        {
            get => _isCombustionEngineRunning;
            set => _isCombustionEngineRunning = value;
        }

        private bool _isPetrolTankFull;

        public bool IsPetrolTankFull
        {
            get=>_isPetrolTankFull;
            set=>_isPetrolTankFull = value;
        }
        public PetrolCar()
        {
            _isCombustionEngineRunning = false;
            _isPetrolTankFull = false;
        }
        public void Start()
        {
            if (!_isCombustionEngineRunning)
            {
                _isCombustionEngineRunning = true;
                Console.WriteLine("Starting petrol car");
            }
            else
            {
                Console.WriteLine("Petrol engine already running");
            }
        }

        public void Stop()
        {
            if (_isCombustionEngineRunning)
            {
                _isCombustionEngineRunning = false;
                Console.WriteLine("Stopping petrol car");
            }
            else
            {
                Console.WriteLine("Petrol engine is not started");
            }
        }

        public void Fuel()
        {
            if (!_isPetrolTankFull)
            {
                _isPetrolTankFull = true;
                Console.WriteLine("Fueling up car with petrol");
            }
            else
            {
                Console.WriteLine("Car is already fueled up with petrol");
            }
        }

        public void Drive()
        {
            if (_isPetrolTankFull && _isCombustionEngineRunning)
            {
                _isPetrolTankFull = false;
                Console.WriteLine("Driving car on petrol");
            }else if (!_isPetrolTankFull)
            {
                Console.WriteLine("Not enough petrol, fuel up");
            }else
            {
                Console.WriteLine("Combustion engine is not running");
            }
                
        }
    }
}