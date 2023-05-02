using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Profesor:Persona
    {
        public Profesor(string nombre) : base(nombre)
        {

        }
        public void Explicar()
        {
            Console.WriteLine("Explicando...");
        }
    }
}
