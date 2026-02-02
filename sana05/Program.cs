using System;
using System.Collections.Generic;
using System.Text;

namespace Sana05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

          
            List<Vehicle> fleet = new List<Vehicle>
            {
                new Car("Toyota", "Camry", 2022, 850000, 4, "Бензин"),
                new Car("Tesla", "Model 3", 2023, 1200000, 4, "Електро"),
                new Truck("MAN", "TGX", 2021, 2500000, 20, 3),
                new Motorcycle("Honda", "CBR 1000RR", 2020, 450000, 1000, true),
                new Motorcycle("Yamaha", "MT-07", 2019, 280000, 689, false)
            };

            Console.WriteLine("=== Інформація про транспортні засоби ===\n");

            double totalTax = 0;
            Vehicle fastestVehicle = fleet[0];

      
            foreach (var vehicle in fleet)
            {
                
                vehicle.DisplayInfo();

            
                totalTax += vehicle.CalculateTax();

            
                if (vehicle.GetMaxSpeed() > fastestVehicle.GetMaxSpeed())
                {
                    fastestVehicle = vehicle;
                }
            }

            Console.WriteLine("========================================");
            Console.WriteLine($"Загальна сума податків: {totalTax} грн");
            Console.WriteLine($"Найшвидший транспорт: {fastestVehicle.Brand} {fastestVehicle.Model} ({fastestVehicle.GetMaxSpeed()} км/год)");

            Console.ReadLine();
        }
    }
}