using System;

namespace Sana05
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public string FuelType { get; set; }

        public Car(string brand, string model, int year, double price, int doors, string fuel)
            : base(brand, model, year, price)
        {
            NumberOfDoors = doors;
            FuelType = fuel;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Light Car: {Brand} {Model}, Doors: {NumberOfDoors}, Fuel: {FuelType}");
            Console.WriteLine($"Price: {Price}, Tax: {CalculateTax()}");
        }

        public override double CalculateTax()
        {
            return (FuelType == "Електро" || FuelType == "Electro") ? Price * 0.005 : Price * 0.015;
        }

        public override double GetMaxSpeed()
        {
            return 180;
        }
    }
}