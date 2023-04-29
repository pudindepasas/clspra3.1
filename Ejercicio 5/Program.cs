using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Foto ft = new Foto(1, 35, 12052003, "buena foto");
            Console.WriteLine(ft.ToString());
            Console.ReadLine();

            Album alb1 = new Album(2, "Fotos Perrito", 12052002, 23, 0,new List<Foto>());
            alb1.aniadirFoto(new Foto(2, 4, 05252009, "foto hermosa"));
            //añadir una foto
            Console.WriteLine("De el ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Tamaño en MB: ");
            int mb = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de la foto: ");
            int fecha = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el comentario: ");
            string comentario = Console.ReadLine();
            alb1.aniadirFoto(new Foto(id, mb, fecha, comentario));
            //mostrar fotos
            Console.WriteLine("Desea mostrar todas las fotos del album? S/N");
            string resp = Console.ReadLine();
            if (resp == "S"||resp == "s") 
            {
                Console.WriteLine("Todas las fotos del album son las siguientes: ");
                alb1.mostrarFoto();
            }
            else
            {
                Console.WriteLine("Cancelado.");
            }
            //vaciar album
            alb1.vaciarAlbum();
            //eliminar foto
            Console.WriteLine("Desea eliminar la foto del abum? S/N");
            string resp1 = Console.ReadLine();
            if (resp1 == "S" || resp1 == "s")
            {
                Console.WriteLine("Ingrese el Id de la foto que desea eliminar:");
                int id2 = int.Parse(Console.ReadLine());
                var fotoAEliminar = alb1.Fotos.Find(f => f.Idfoto == id);
                if (fotoAEliminar != null)
                {
                    alb1.eliminarFoto(fotoAEliminar);
                }
                else
                {
                    Console.WriteLine("La foto con el Id {0} no fue encontrada en el album", id);
                }
            }
            //tamaño del album
            double tamanoAlbum = alb1.TamanoAlbum();
            Console.WriteLine("El tamaño del album es: " + tamanoAlbum + " GB");

            Console.ReadKey();
            
        }
    }

}
