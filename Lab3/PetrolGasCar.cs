using System;

namespace Lab3
{
    public class PetrolGasCar : ICar, IPetrolCar, IGasCar
    {
        private bool _isGasFueled;
        private bool _isPetrolFueled;
        private bool _isStarted;

        public PetrolGasCar()
        {
            _isStarted = false;
            _isPetrolFueled = false;
            _isGasFueled = false;
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
            if (!_isPetrolFueled && !_isGasFueled)
            {
                ((IPetrolCar)this).Fuel();
                ((IGasCar)this).Fuel();
                Console.WriteLine("Fueling up with petrol and gas");
            }
            else
            {
                Console.WriteLine("Car is already fueled up with petrol and gas");
            }
        }

        void ICar.Drive()
        {
            if (_isStarted)
            {
                if (_isGasFueled)
                {
                    ((IGasCar)this).Drive();
                    Console.WriteLine("Driving car on gas");
                }
                else if (_isPetrolFueled)
                {
                    ((IPetrolCar)this).Drive();
                    Console.WriteLine("Driving car on petrol");
                }
                else
                {
                    Console.WriteLine("Car is not fueled with petrol nor gas");
                }
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }

        void IGasCar.Fuel()
        {
            _isGasFueled = true;
        }

        void IGasCar.Drive()
        {
            _isGasFueled = false;
        }

        void IPetrolCar.Fuel()
        {
            _isPetrolFueled = true;
        }

        void IPetrolCar.Drive()
        {
            _isPetrolFueled = false;
        }
    }
}