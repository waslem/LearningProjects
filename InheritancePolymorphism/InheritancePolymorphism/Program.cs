using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("pearl");
            Dog dog = new Dog("cole");
            Animal randomAnimal = new Animal();

            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(randomAnimal);

            foreach (var animal in animals)
            {
                Console.WriteLine("Animal name: " + animal.Name);
                Console.WriteLine("Animal type: " + animal.GetType());
                animal.MakeNoise();

                if (animal.GetType() == typeof(Dog))
                {
                    Dog dogSecret = (Dog)animal;
                    dogSecret.OnlyDogMethod();
                }
            }

            Console.ReadLine();
        }
    }
}
