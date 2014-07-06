using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string name = args[0];
                Console.WriteLine("Hi " + name);
            }
            else
            {
                Console.WriteLine("Hi Random");
            }

            Console.ReadLine();

        }
    }
}
