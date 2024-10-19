namespace Lab3b;

public interface IPetrolCar
{
    bool CombustionEngine { get; set; }

    bool PetrolTank { get; set; }
    void Fuel();
    void Drive();
}