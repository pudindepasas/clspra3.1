using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Persona[] personas = new Persona[3];
            for (int i = 0; i < personas.Length; i++)
            {
                Console.Write("De su nombre: ");
                string nombre = Console.ReadLine();

                if(i<2)
                {
                    personas[i] = new Estudiante(nombre);
                }
                else
                {
                    personas[i] = new Profesor(nombre);
                }
            }

            for (int i = 0; i < personas.Length; i++)
            {
                if (personas[i] is Estudiante)
                {
                    ((Estudiante)personas[i]).Estudiar();
                }
                else if (personas[i] is Profesor)
                {
                    ((Profesor)personas[i]).Explicar();

                }
            }


            Console.ReadLine();
        }
    }
}