using System;

namespace Lab3
{
    interface IElectricCar
    {
        void Start();
        void Stop();
        void Fuel();
        void Drive();
    }
    
    class ElectricCar : IElectricCar, ICar
    {
        private bool _isStarted;
        private bool _isFueled;

        public ElectricCar()
        {
            _isStarted = false;
            _isFueled = false;
        }

        void IElectricCar.Start()
        {
            if (!_isStarted)
            {
                Console.WriteLine("Starting car");
                _isStarted = true;
            }
            else
            {
                Console.WriteLine("Car already started");
            }
        }

        void IElectricCar.Stop()
        {
            if (_isStarted)
            {
                Console.WriteLine("Stopping car");
                _isStarted = false;
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }

        void IElectricCar.Fuel()
        {
            if (!_isFueled)
            {
                Console.WriteLine("Charging car with electricity");
                _isFueled = true;
            }
            else
            {
                Console.WriteLine("Car is already charged");
            }
        }

        void IElectricCar.Drive()
        {
            if (_isStarted && _isFueled)
            {
                Console.WriteLine("Driving on electricity");
                _isFueled = false;
            }
            else if(!_isFueled)
            {
                Console.WriteLine("Not enough electricity, charge");
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }
        void ICar.Start()
        {
            if (!_isStarted)
            {
                Console.WriteLine("Starting car");
                _isStarted = true;
            }
            else
            {
                Console.WriteLine("Car already started");
            }
        }

        void ICar.Stop()
        {
            if (_isStarted)
            {
                Console.WriteLine("Stopping car");
                _isStarted = false;
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }

        void ICar.Fuel()
        {
            if (!_isFueled)
            {
                Console.WriteLine("Charging car with electricity");
                _isFueled = true;
            }
            else
            {
                Console.WriteLine("Car is already charged");
            }
        }

        void ICar.Drive()
        {
            if (_isStarted && _isFueled)
            {
                Console.WriteLine("Driving on electricity");
                _isFueled = false;
            }
            else if(!_isFueled)
            {
                Console.WriteLine("Not enough electricity, charge");
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }
    }
}