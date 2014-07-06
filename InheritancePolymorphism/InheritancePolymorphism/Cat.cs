using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public class Cat : Animal
    {
        public Cat()
        {

        }
        public Cat(string name)
        {
            this.Name = name;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Meow");
        }
        public override string ToString()
        {
            return Name + " cat";
        }
    }
}
