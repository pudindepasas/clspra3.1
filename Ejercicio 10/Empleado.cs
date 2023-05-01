using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Empleado:Persona
    {
        double sueldo_bruto;

        public Empleado(string nombre, int edad, double sueldo_bruto) :base(nombre, edad)
        {
            this.Sueldo_bruto = sueldo_bruto;
        }

        public double Sueldo_bruto { get => sueldo_bruto; set => sueldo_bruto = value; }

        public void MostrarEmpleado()
        {
            Console.WriteLine("DATOS EMPLEADO");
            Console.WriteLine("Nombre empleado: " + Nombre);
            Console.WriteLine("Edad empleado: " + Edad);
            Console.WriteLine("Sueldo bruto: $"+sueldo_bruto);
        }
        public void SueldoNeto()
        {
            double s1 = sueldo_bruto * 0.15;
            double s2 = sueldo_bruto - s1; 
            Console.WriteLine("El sueldo neto es de: $"+s2);
        }
    }
}
