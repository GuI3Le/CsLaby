namespace Lab3b
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var petrolElectricCar = new PetrolElectricCar();
            petrolElectricCar.Start();
            ((ICar)petrolElectricCar).Start();
            ((IElectricCar)petrolElectricCar).Start();
            ((IPetrolCar)petrolElectricCar).Start();
            
            
        }
    }
}