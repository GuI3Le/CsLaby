using System;

namespace Lab3
{
    public class PetrolElectricCar : ICar, IPetrolCar, IElectricCar
    {
        private bool _isCharged;
        private bool _isPetrolFueled;
        private bool _isStarted;

        public PetrolElectricCar()
        {
            _isStarted = false;
            _isPetrolFueled = false;
            _isCharged = false;
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
            if (!_isPetrolFueled && !_isCharged)
            {
                ((IPetrolCar)this).Fuel();
                ((IElectricCar)this).Fuel();
                Console.WriteLine("Fueling up with petrol and charging");
            }
            else if (!_isPetrolFueled)
            {
                ((IPetrolCar)this).Fuel();
            }
            else if (!_isCharged)
            {
                ((IElectricCar)this).Fuel();
                Console.WriteLine("Car already fueled up, charging...");
            }
            else
            {
                Console.WriteLine("Car is already fueled and charged");
            }
        }

        void ICar.Drive()
        {
            if (_isStarted)
            {
                if (_isCharged)
                {
                    ((IElectricCar)this).Drive();
                    Console.WriteLine("Driving car on electricity");
                }
                else if (_isPetrolFueled)
                {
                    ((IPetrolCar)this).Drive();
                    Console.WriteLine("Driving car on petrol");
                }
                else
                {
                    Console.WriteLine("Car is neither charged nor fueled with petrol");
                }
            }
            else
            {
                Console.WriteLine("Car is not started");
            }
        }

        void IElectricCar.Fuel()
        {
            _isCharged = true;
        }

        void IElectricCar.Drive()
        {
            _isCharged = false;
        }

        void IPetrolCar.Fuel()
        {
            _isPetrolFueled = true;
            Console.WriteLine("Fueling up with petrol");
        }

        void IPetrolCar.Drive()
        {
            _isPetrolFueled = false;
        }
    }
}