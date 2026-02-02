using System;

namespace Sana05
{
    public class Vehicle
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

       
        public Vehicle(string brand, string model, int year, double price)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

   
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, Price: {Price} UAH");
        }

        public virtual double CalculateTax()
        {
            return Price * 0.01; 
        }

        public virtual double GetMaxSpeed()
        {
            return 100; 
        }
    }
}