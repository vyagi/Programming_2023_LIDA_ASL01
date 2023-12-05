using System;

namespace Encapsulation
{
    class Student
    {
        private string _name;
        private string _lastName;
        private int _age;

        public Student(string name, string lastName, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name is required");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentNullException("Last name is required");

            if (age < 16)
                throw new ArgumentException("Age must be minimum 16");

            _name = name;
            _lastName = lastName;
            _age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("James", "Bond", 40);
            Console.WriteLine($"{s.name} {s.lastName} is {s.age}.");

            s.age = -10;
            s.name = null;
            s.lastName = "   ";
            Console.WriteLine($"{s.name} {s.lastName} is {s.age}.");
        }
    }
}
