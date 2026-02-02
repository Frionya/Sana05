using System;

namespace Sana05
{
    public class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }
        public int NumberOfAxles { get; set; }

        public Truck(string brand, string model, int year, double price, double capacity, int axles)
            : base(brand, model, year, price)
        {
            LoadCapacity = capacity;
            NumberOfAxles = axles;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck: {Brand} {Model}, Capacity: {LoadCapacity} tons");
            Console.WriteLine($"Price: {Price}, Tax: {CalculateTax()}");
        }

        public override double CalculateTax()
        {
            return (Price * 0.02) + (LoadCapacity * 1000);
        }

        public override double GetMaxSpeed()
        {
            return 120;
        }
    }
}