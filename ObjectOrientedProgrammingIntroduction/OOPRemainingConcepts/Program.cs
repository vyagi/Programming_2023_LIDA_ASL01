using System;

namespace OOPRemainingConcepts
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Unspecified sound....");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hau hau");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Miau miau");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            d.MakeSound();

            var c = new Cat();
            c.MakeSound();

            ProduceSounds(new Animal[] { d, c, new Dog(), new Cat() });
        }

        static void ProduceSounds(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
