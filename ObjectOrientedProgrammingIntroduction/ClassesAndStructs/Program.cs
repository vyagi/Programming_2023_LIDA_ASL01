using System;

namespace ClassesAndStructs
{
    public struct Student 
    {
        public string Name;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "James Bond";
            s.Age = 40;
            Console.WriteLine($"{s.Name} is {s.Age} years old");

            Update(s);
            Console.WriteLine($"{s.Name} is {s.Age} years old");

        }

        public static void Update(Student student)
        {
            student.Name = "Mr. Bean";
            student.Age = 50;
        }
    }
}
