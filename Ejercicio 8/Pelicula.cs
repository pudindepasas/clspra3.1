using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Pelicula
    {
        string nombre;
        int anio;
        List<Actor> actores;

        public Pelicula(string nombre, int anio, List<Actor> actores)
        {
            this.nombre = nombre;
            this.anio = anio;
            this.actores = actores;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Anio { get => anio; set => anio = value; }
        internal List<Actor> Actores { get => actores; set => actores = value; }

        public void AgregarActor(Actor actor)
        {
            Actores.Add(actor);
        }
        
    }
}
