using System;

namespace Encapsulation
{
    class Car
    {
        private readonly string _brand;
        private readonly string _model;
        private readonly int _tankCapacity;
        private readonly double _fuelConsumption;
        private double _fuelLevel;
        private double _odometer;

        public Car(string brand, string model, int tankCapacity, double fuelConsumption)
        {
            //HomeWork - add proper checks
            _brand = brand;
            _model = model;
            _tankCapacity = tankCapacity;
            _fuelConsumption = fuelConsumption;
        }

        public void AddFuel(int howMuch)
        {
            //Home work - protect from negative value
            _fuelLevel += howMuch;

            if (_fuelLevel > _tankCapacity)
                _fuelLevel = _tankCapacity;
        }

        public void Drive(int distance)
        {
            //Home work - protect from negative value
            var maximumDistance = _fuelLevel / _fuelConsumption * 100;

            if (distance < maximumDistance)
            {
                _odometer += distance;
                _fuelLevel -= distance * _fuelConsumption / 100;
            }
            else
            {
                _odometer += maximumDistance;
                _fuelLevel = 0;
            }
        }

        public string BrandAndModel => $"{_brand} {_model}";

        public int FuelLevel => (int)_fuelLevel;

        public int Odometer => (int)_odometer;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Car("Opel", "Insignia", 50, 5);
            c1.AddFuel(30);
            c1.AddFuel(60);

            c1.Drive(50);
            Console.WriteLine($"{c1.BrandAndModel}: {c1.FuelLevel} liter, {c1.Odometer} kilometer");

            c1.Drive(100);
            Console.WriteLine($"{c1.BrandAndModel}: {c1.FuelLevel} liter, {c1.Odometer} kilometer");

            c1.Drive(3000);
            Console.WriteLine($"{c1.BrandAndModel}: {c1.FuelLevel} liter, {c1.Odometer} kilometer");

            //Introduce this "daily (trip) odometer"
            //Introduce method like ResetDailyOdometer which will set it to 0
            //Introduce the limit for this Daily Odometer     
            //Introduce the limit for this normal Odometer     

            var c2 = new Car("Jaguar", "X100", 80, 15.5);

            //var s = new Student("James", "Bond", 40);
            //Console.WriteLine($"{s.Name} {s.LastName} is {s.Age}.");

            //s.FullName = "Jorge Smith";
            //Console.WriteLine($"{s.FullName} is {s.Age}, {s.IsAdult}");
        }
    }
}

//Another homework:
//Implement a CoffeMachine class with a brand, water tank capacity / level
//Coffe grains - handle it
//At least two methods : MakeEspresso, MakeAmericano
//Implement the grounds concept 
