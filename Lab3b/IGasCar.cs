namespace Lab3b;

public interface IGasCar
{
    bool CombustionEngine { get; set; }

    bool GasCylinder { get; set; }

    void Fuel();
    void Drive();
}