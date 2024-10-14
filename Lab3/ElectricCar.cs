using System;

namespace Lab3
{
    internal class ElectricCar : IElectricCar, ICar
    {
        private bool _isFueled;
        private bool _isStarted;

        public ElectricCar()
        {
            _isStarted = false;
            _isFueled = false;
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

        public void Fuel()
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

        public void Drive()
        {
            if (_isStarted && _isFueled)
            {
                Console.WriteLine("Driving on electricity");
                _isFueled = false;
            }
            else if (!_isFueled)
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