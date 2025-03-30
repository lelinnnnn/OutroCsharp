using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerospares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Números pares de 1 a 100:");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
