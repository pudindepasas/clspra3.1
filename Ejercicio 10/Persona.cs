﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Persona
    {
        string nombre;
        int edad;

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public void mostrar()
        {
            Console.WriteLine("Nombre: "+nombre);
            Console.WriteLine("Edad: " + edad);
        }
    }
}
