using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //datos cliente
            Cliente cli = new Cliente("Sr. San Holo", 4353453, 36);
            cli.MostrarCliente();
            Console.WriteLine();

            //datos empleado
            Empleado emp = new Empleado("Sr. Walter White",56, 15000);
            emp.MostrarEmpleado();
            emp.SueldoNeto();
            Console.WriteLine();

            //datos directivo
            Directivo dir = new Directivo("Sr.Jesse Pinkman",45,"Director Financiero", new List<Empleado>());
            dir.MostrarDirectivo();
            Console.WriteLine();

            //datos empresa
            Empresa empr = new Empresa("Agricorp", new List<Empleado>(),new List<Cliente>());
            Console.WriteLine("DATOS EMPRESA");
            Console.WriteLine("Nombre de la empresa: "+empr.Nombre);
            Console.ReadLine();
        }
    }
}
