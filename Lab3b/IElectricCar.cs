namespace Lab3b
{
    public interface IElectricCar
    {
        bool IsElectricEngineRunning { get; set; }
        bool IsBatteryCharged { get; set; }
        void Start();
        void Stop();
        void Drive();
        void Fuel();
    }
}