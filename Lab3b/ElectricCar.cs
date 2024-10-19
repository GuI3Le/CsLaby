using System;

namespace Lab3b
{
    public class ElectricCar : ICar, IElectricCar
    {
        private bool _electricEngineRunning;
        private bool _batteryCharged;

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

        public ElectricCar()
        {
            _electricEngineRunning=false;
            _batteryCharged=false;
        }

        public void Start()
        {
            if (!_electricEngineRunning)
            {
                _electricEngineRunning=true;
                Console.WriteLine("Starting electric car");
            }
            else
            {
                Console.WriteLine("Electric car is already running");
            }
        }

        public void Stop()
        {
            if (_electricEngineRunning)
            {
                _electricEngineRunning=false;
                Console.WriteLine("Stopping electric car");
            }
            else
            {
                Console.WriteLine("Electric car is not running");
            }
        }

        public void Fuel()
        {
            if (!_batteryCharged)
            {
                _batteryCharged=true;
                Console.WriteLine("Charging electric car");
            }
            else
            {
                Console.WriteLine("Car is already charged");
            }
        }

        public void Drive()
        {
            if (_batteryCharged && _electricEngineRunning)
            {
                _batteryCharged=false;
                Console.WriteLine("Driving electric car");
            }else if (!_electricEngineRunning)
            {
                Console.WriteLine("Not enough battery, charge");
            }
            else
            {
                Console.WriteLine("Car is not running");
            }
        }
    }
}