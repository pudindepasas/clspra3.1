using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    internal class Paquete
    {
        int codigo;
        string descripcion;
        string destinatario;
        string direccion;
        List<Ciudad> ciudades;

        public Paquete(int codigo, string descripcion, string destinatario, string direccion, List<Ciudad> ciudades)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Destinatario = destinatario;
            this.Direccion = direccion;
            this.Ciudades = ciudades;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Ciudad> Ciudades { get => ciudades; set => ciudades = value; }
        public void AddCiudad(Ciudad ci)
        {
            ciudades.Add(ci);
        }
    }
}
