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

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Name is required");

                _name = value;
            }
        }

        public string LastName => _lastName;

        public int Age => _age;

        public bool IsAdult => _age >= 18;

        public string FullName
        {
            get => $"{Name} {LastName}";
            set
            {
               //Home work

            }
        }
    }
        //Java approach (don't do it in C#)
        //    public string GetName()
        //    {
        //        return _name;
        //    }

        //    public void SetName(string newName)
        //    {
        //        if (string.IsNullOrWhiteSpace(newName))
        //            throw new ArgumentNullException("Name is required");

        //        _name = newName;
        //    }

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("James", "Bond", 40);
            Console.WriteLine($"{s.Name} {s.LastName} is {s.Age}.");

            s.FullName = "Jorge Smith";
            Console.WriteLine($"{s.FullName} is {s.Age}, {s.IsAdult}");
        }
    }
}
