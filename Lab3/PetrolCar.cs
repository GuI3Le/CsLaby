using System;

namespace Lab3
{
    internal class PetrolCar : IPetrolCar, ICar
    {
        private bool _isFueled;
        private bool _isStarted;

        public PetrolCar()
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
                Console.WriteLine("Fueling up car with petrol");
                _isFueled = true;
            }
            else
            {
                Console.WriteLine("Car is already fueled up with petrol");
            }
        }

        public void Drive()
        {
            if (_isStarted && _isFueled)
            {
                Console.WriteLine("Driving on petrol");
                _isFueled = false;
            }
            else if (!_isFueled)
            {
                Console.WriteLine("Not enough petrol, fuel up");
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }
    }
}