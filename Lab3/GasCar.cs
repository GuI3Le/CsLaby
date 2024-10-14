using System;

namespace Lab3
{
    class GasCar : IGasCar, ICar
    {
        private bool _isStarted;
        private bool _isFueled;

        public GasCar()
        {
            _isStarted = false;
            _isFueled = false;
        }

        void IGasCar.Start()
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

        void IGasCar.Stop()
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

        void IGasCar.Fuel()
        {
            if (!_isFueled)
            {
                Console.WriteLine("Fueling up car with gas");
                _isFueled = true;
            }
            else
            {
                Console.WriteLine("Car is already fueled up with gas");
            }
        }

        void IGasCar.Drive()
        {
            if (_isStarted && _isFueled)
            {
                Console.WriteLine("Driving on gas");
                _isFueled = false;
            }
            else if(!_isFueled)
            {
                Console.WriteLine("Not enough gas, fuel up");
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
                Console.WriteLine("Fueling up car with gas");
                _isFueled = true;
            }
            else
            {
                Console.WriteLine("Car is already fueled up with gas");
            }
        }

        void ICar.Drive()
        {
            if (_isStarted && _isFueled)
            {
                Console.WriteLine("Driving on gas");
                _isFueled = false;
            }
            else if(!_isFueled)
            {
                Console.WriteLine("Not enough gas, fuel up");
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }
    }
}