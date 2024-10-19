namespace Lab3b
{
    public interface IGasCar
    {
        bool IsCombustionEngineRunning { get; set; }
        bool IsGasCylinderFull { get; set; }
        void Start();
        void Stop();
        void Drive();
        void Fuel();
    }
}