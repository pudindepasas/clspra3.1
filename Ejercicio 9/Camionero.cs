using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Camionero
    {
        string nombre;
        int telefono;
        string direccion;
        string poblacion;
        string rfc;
        int salario;
        List<Camion> camiones;
        List<Paquete> paquetes;

        public Camionero(string nombre, int telefono, string direccion, string poblacion, string rfc, int salario, List<Camion> camiones, List<Paquete> paquetes)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Poblacion = poblacion;
            this.Rfc = rfc;
            this.Salario = salario;
            this.Camiones = camiones;
            this.Paquetes = paquetes;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Poblacion { get => poblacion; set => poblacion = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public int Salario { get => salario; set => salario = value; }
        internal List<Camion> Camiones { get => camiones; set => camiones = value; }
        internal List<Paquete> Paquetes { get => paquetes; set => paquetes = value; }

        public void AddCamion(Camion ca)
        {
            camiones.Add(ca);
        }
        public void AddPaquete(Paquete pa)
        {
            paquetes.Add(pa);
        }
    }
}
