using System;

namespace Sana05
{
    public class Motorcycle : Vehicle
    {
        public int EngineVolume { get; set; }
        public bool HasWindshield { get; set; }

        public Motorcycle(string brand, string model, int year, double price, int volume, bool windshield)
            : base(brand, model, year, price)
        {
            EngineVolume = volume;
            HasWindshield = windshield;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Motorcycle: {Brand} {Model}, Engine: {EngineVolume} cm3");
            Console.WriteLine($"Price: {Price}, Tax: {CalculateTax()}");
        }

        public override double CalculateTax()
        {
            return (Price * 0.008) + (EngineVolume * 0.5);
        }

        public override double GetMaxSpeed()
        {
            return 200;
        }
    }
}