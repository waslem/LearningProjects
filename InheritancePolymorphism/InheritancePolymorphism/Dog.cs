using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public class Dog : Animal
    {
        public Dog()
        {

        }
        public Dog(string name)
        {
            this.Name = name;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Woof!");
        }

        public override string ToString()
        {
            return Name + " dog";
        }

        public void OnlyDogMethod()
        {
            Console.WriteLine("secret dog only method");
        }

    }
}
