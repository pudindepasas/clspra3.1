using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Cliente:Persona
    {
        int telefono_contacto;

        public Cliente(string Nombre, int telefono_contacto, int Edad) : base(Nombre, Edad)
        {
            
            this.Telefono_contacto = telefono_contacto;
        }

        public int Telefono_contacto { get => telefono_contacto; set => telefono_contacto = value; }

        public void MostrarCliente()
        {
            Console.WriteLine("DATOS CLIENTE");
            Console.WriteLine("Nombre empleado: " + Nombre);
            Console.WriteLine("Edad empleado: " + Edad);
            Console.WriteLine("Telefono de contacto: #" + telefono_contacto);
        }
    }

}
