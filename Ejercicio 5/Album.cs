using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_5
{
    internal class Album
    {
        int id;
        string nombre;
        int fecha;
        int total;
        int totalgb;
        List<Foto> fotos;

        public Album(int id, string nombre, int fecha, int total, int totalgb, List<Foto> fotos)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Fecha = fecha;
            this.Total = total;
            this.Totalgb = totalgb;
            this.Fotos = fotos;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public int Total { get => total; set => total = value; }
        public int Totalgb { get => totalgb; set => totalgb = value; }
        internal List<Foto> Fotos { get => fotos; set => fotos = value; }

        public void aniadirFoto(Foto f)
        {
            try
            {
                
                this.Fotos.Add(f);
                this.total += 1;
                Console.WriteLine("Se añadió uan nueva Foto");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se añadió una nueva foto debido a: \n" + ex.Message);
                Console.WriteLine();

            }
        }
        public void mostrarFoto()
        {
            foreach (Foto f in this.fotos)
            {
                Console.WriteLine("------------");
                Console.WriteLine(f.ToString());
            }
        }
        public void vaciarAlbum()
        {
            {
                Console.WriteLine("Está seguro que desea eliminar todos los elementos mostrados en el album?: S/N");
                Console.WriteLine("Hay un total de {0} fotos.", fotos.Count);
                string resp = Console.ReadLine();
                if (resp == "S" || resp == "s")
                {
                    fotos = new List<Foto>();
                    this.total = 0;
                    Console.WriteLine("Se han eliminado las fotos correctamente");

                }
                else
                {
                    Console.WriteLine("No se eliminó, Hay {0} fotos disponibles en el album.", fotos.Count);
                    Console.WriteLine("Enter para continuar.");
                }
                Console.ReadLine();
            }

        }
        public void eliminarFoto(Foto f)
        {
            fotos.Remove(f);
            total = 0;
            Console.WriteLine("Se ha eliminado la foto, quedaron {0} en el album",fotos.Count);
            Console.ReadLine();
        }

        public double TamanoAlbum()
        {
            double ttt = 0;
            foreach (Foto foto in Fotos)
            {
                ttt += foto.Tamaniomb;
            }
            return ttt / 1024;
        }


    }
}
