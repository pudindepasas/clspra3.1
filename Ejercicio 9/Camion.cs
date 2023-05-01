using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Camion
    {
        string potencia;
        string matricula;
        string modelo;
        string tipo;
        

        public Camion(string potencia, string matricula, string modelo, string tipo)
        {
            this.Potencia = potencia;
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Tipo = tipo;
        }

        public string Potencia { get => potencia; set => potencia = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
