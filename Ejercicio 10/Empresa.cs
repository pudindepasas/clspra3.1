using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Empresa
    {
        string nombre;
        List<Empleado> empleados;
        List<Cliente> clientes;

        public Empresa(string nombre, List<Empleado> empleados, List<Cliente> clientes)
        {
            this.Nombre = nombre;
            this.Empleados = empleados;
            this.Clientes = clientes;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Empleado> Empleados { get => empleados; set => empleados = value; }
        internal List<Cliente> Clientes { get => clientes; set => clientes = value; }
    }
}
