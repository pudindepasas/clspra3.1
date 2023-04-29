using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CasaComercial cc2 = new CasaComercial("Casa Pelas", "contacto@casapellas.com", 0, new List<Vehiculo>());
            cc2.aniadirVehiculo(new Vehiculo(2, "Kia", "Prado", 3999, 4999, 2004));



            Console.WriteLine("De el nombre de la casa comercial: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el email: ");
            string contacto = Console.ReadLine();
            //definimos un nuevo objeto de tipo Casa Comercial
            CasaComercial cc = new CasaComercial(nombre, contacto, 0, new List<Vehiculo>());

            //informacion del vehiculo a añadir
            Console.WriteLine("A continuacion de la informacion del primer vehiculo a añadir: ");
            Console.WriteLine("Modelo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine("Marca: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Kilometraje: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Año: ");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            //procedemos a añadir la informacion del nuevo vehiculo haciendo uso del metodo añadir "añadir vehiculo
            //definido en la clase casa comercial

            cc.aniadirVehiculo(new Vehiculo(1, marca, modelo, km, precio, anio));
        }
    }
}
