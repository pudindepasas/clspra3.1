using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ciudad
            Ciudad ci = new Ciudad(1232131, "California");
            //datos camion
            Camion ca = new Camion("500 HP", "NYC321", "Freightliner Cascadia", "Cascadia Sleeper");
            //datos paquete
            Paquete pa = new Paquete(12345, "5,000 LBS. de alimentos para Bobinos", "Sr. Walter White", "Alaska, PBA 12312", new List<Ciudad>());
            pa.AddCiudad(ci);
            Console.WriteLine("DATOS CIUDAD DESTINATARIA DEL PAQUETE");
            Console.WriteLine("Codigo: " + ci.Codigo);
            Console.WriteLine("Nombre: " + ci.Nombre);
            Console.WriteLine();

            //datos camionero
            Camionero cam = new Camionero("Jhon Wick", 05060789, "New York City, CA3242", "Estadounidense", "RFC-JW23243", 12000, new List<Camion>(), new List<Paquete>());
            cam.AddCamion(ca);
            cam.AddPaquete(pa);
            Console.WriteLine("DATOS CAMIONERO");
            Console.WriteLine("Nombre camionero: " + cam.Nombre);
            Console.WriteLine("Nombre telefono: " + cam.Telefono);
            Console.WriteLine("Direccion: " + cam.Direccion);
            Console.WriteLine("Poblacion: " + cam.Poblacion);
            Console.WriteLine("RFC: " + cam.Rfc);
            Console.WriteLine("Salario: " + cam.Salario);
            Console.WriteLine();
            Console.WriteLine("DATOS CAMION");
            Console.WriteLine("Potencia: "+ca.Potencia);
            Console.WriteLine("Matricula: "+ca.Matricula);
            Console.WriteLine("Modelo: "+ca.Modelo);
            Console.WriteLine("Tipo: " + ca.Tipo);
            Console.WriteLine();
            Console.WriteLine("DATOS PAQUETE");
            Console.WriteLine("Codigo: " + pa.Codigo);
            Console.WriteLine("Descripcion: "+pa.Descripcion);
            Console.WriteLine("Destinatario: " + pa.Destinatario);
            Console.WriteLine("Direccion: " + pa.Direccion);

            Console.ReadLine();



        }
    }
}
