namespace Lab3b
{
    public interface IPetrolCar
    {
        bool IsCombustionEngineRunning { get; set; }
        bool IsPetrolTankFull { get; set; }
        void Start();
        void Stop();
        void Drive();
        void Fuel();
    }
}