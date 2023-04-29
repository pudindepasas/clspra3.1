using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computadora com = new Computadora(100,100,false);

            //Estado computadora
            Console.WriteLine("Desea encender la computadora? S/N");
            string resp1 = Console.ReadLine();
            if (resp1 == "S" || resp1 == "s") 
            {
                com.encender();
            }
            else
            {
                Console.WriteLine("Cancelado.");
            }

            //Añadir informacion
            Console.WriteLine("Cuantos GB desea añadir?");
            int datos = int.Parse(Console.ReadLine());
            com.aniadirDatos(datos);

            Console.WriteLine("Cuantos GB desea eliminar?");
            int datos2 = int.Parse(Console.ReadLine());
            com.eliminarDatos(datos2);

            Console.WriteLine("Desea apagar la computadora?S/N");
            string resp2= Console.ReadLine();
            if (resp2 == "S" || resp2 == "s") 
            {
                com.apagar();
            }
            else
            {
                Console.WriteLine("Cancelado.");
            }


        }
        
    }
}
