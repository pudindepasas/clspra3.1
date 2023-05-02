using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Estudiante:Persona
    {

        public Estudiante(string nombre):base(nombre)
        {
           
        }
        public void Estudiar()
        {
            Console.WriteLine("Estudiando...");
        }

    }
}
