using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio_3
{
    internal class Computadora
    {
        decimal capacidad;
        decimal espacio;
        bool encendido;

        public Computadora(decimal capacidad, decimal espacio, bool encendido)
        {
            this.capacidad = capacidad;
            this.espacio = espacio;
            this.encendido = encendido;
        }

        public void aniadirDatos(int datos)
        {
            
            if (encendido)
            {
                if (espacio < datos)
                {
                    Console.WriteLine("No hay suficiente espacio en el disco. Solo se añadirán {0} GB.", espacio);
                    espacio = 0;
                }
                else
                {
                    espacio -= datos;
                    Console.WriteLine("Se han añadido {0} GB al disco. Espacio disponible: {1} GB", datos, espacio);
                }
            }
            else
            {
                Console.WriteLine("No es posible, computadora apagada.");
            }
        }

        public void eliminarDatos(int datos)
        {
            if (encendido)
            {
                espacio += datos;
                if (espacio > capacidad)
                {
                    espacio = capacidad;
                }
                Console.WriteLine("Se han borrado {0} GBs del disco. Espacio disponible: {1} GBs", datos, espacio);
            }
            else
            {
                Console.WriteLine("No es posible, computadora apagada.");
            }
        }

        public void encender()
        {
            if (!encendido)
            {
                Console.WriteLine("Bienvenido, computadora encendida.");
                encendido = true;
            }
            else
            {
                Console.WriteLine("La computadora ya está encendida.");
            }
        }

        public void apagar()
        {
            if (encendido)
            {
                Console.WriteLine("Computadora apagada.");
                encendido = false;
            }
            else
            {
                Console.WriteLine("No es posible, computadora apagada.");
            }
        }
    }
}

