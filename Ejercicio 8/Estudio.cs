using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Estudio
    {
        string nombre;
        string produccion;
        List<Pelicula> peliculas;

        public Estudio(string nombre, string produccion, List<Pelicula> peliculas)
        {
            this.nombre = nombre;
            this.produccion = produccion;
            this.peliculas = peliculas;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Produccion { get => produccion; set => produccion = value; }
        internal List<Pelicula> Peliculas { get => peliculas; set => peliculas = value; }
        public void AgregarPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
    }
}
