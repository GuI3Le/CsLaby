namespace Lab3b;

public interface IElectricCar
{
    bool ElectricEngine { get; set; }
    bool Battery { get; set; }
    void Fuel();
    void Drive();
}