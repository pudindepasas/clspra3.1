using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo(1, "Chevrolet", "Aveno", 5000, 1000, 2017);
            Console.WriteLine(vehiculo1.ToString());
            Console.ReadLine();

        }
    }
}
