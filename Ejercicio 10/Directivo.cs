using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Directivo:Persona
    {
        string categoria;
        List<Empleado> empleados;

        public Directivo(string nombre, int edad, string categoria, List<Empleado> empleados) :base(nombre, edad)
        {
            this.Categoria = categoria;
            this.Empleados = empleados;
        }

        public string Categoria { get => categoria; set => categoria = value; }
        internal List<Empleado> Empleados { get => empleados; set => empleados = value; }

        public void MostrarDirectivo()
        {
            Console.WriteLine("DATOS DIRECTIVO");
            Console.WriteLine("Nombre empleado: " + Nombre);
            Console.WriteLine("Edad empleado: " + Edad);
            Console.WriteLine("Categoria: " + categoria);
        }
    }
}
