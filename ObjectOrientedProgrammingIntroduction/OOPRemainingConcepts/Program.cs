using System;

namespace OOPRemainingConcepts
{
    public interface IPet
    {
        void Play();
    }

    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    class Dog : Animal, IPet
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hau hau");
        }

        public void Play()
        {
            MakeSound();
            MakeSound();
            MakeSound();
        }
    }

    class Cat : Animal, IPet
    {
        public override void MakeSound()
        {
            Console.WriteLine("Miau miau");
        }

        public void Play()
        {
            MakeSound();
            MakeSound();
        }
    }

    class Donkey : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Ihaaa Ihaaa");
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

            ProduceSounds(new Animal[] { d, c, new Dog(), new Cat(), new Donkey() });
            PlayWithPets(new IPet[] { d, c, new Dog() });
        }

        static void ProduceSounds(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }

        static void PlayWithPets(IPet[] pets)
        {
            foreach (var pet in pets)
            {
                pet.Play();
            }
        }
    }
}
