using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void MakeNoise()
        {
            Console.WriteLine("generic noise");
        }
    }
}
