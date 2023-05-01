using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Actor ac = new Actor("Keanu", "Reeves");
            Console.WriteLine("Nombre del actor: " + ac.Nombre);
            Console.WriteLine("Apellido del actor: " + ac.Apellido);
            Console.ReadLine();

            Pelicula pe = new Pelicula("Elysium", 2013, new List<Actor>());
            pe.AgregarActor(new Actor("Keanu", "Reeves"));
            Console.WriteLine("Nombre de la película: " + pe.Nombre);
            Console.WriteLine("Año de la película: " + pe.Anio);
            Console.WriteLine("Actores en la película:");
            Console.WriteLine("Nombre del actor: " +ac.Nombre+ " " + ac.Apellido);
            Console.ReadLine();

            Estudio es = new Estudio("Cuphead Studios", "Sr. Modi Wiczyk, Sr. Asif Satchu", new List<Pelicula>());
            es.AgregarPelicula(pe);
            Console.WriteLine("Nombre del estudio: " + es.Nombre);
            Console.WriteLine("Producción: " + es.Produccion);
            Console.ReadLine();

            
           









        }
    }
}
