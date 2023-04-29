using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Vehiculo
    {
        //Definimos los campos de la clase
        int id;
        string marca;
        string modelo;
        int km;
        decimal precio;
        int anio;

        public Vehiculo(int id, string marca, string modelo, int km, decimal precio, int anio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
            this.Anio = anio;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Anio { get => anio; set => anio = value; }

        public override string ToString()
        {
            return "Modelo " + modelo + "\n" + "Marca " + marca + "\n" + "Kilometraje " + km + "\n" + "Precio " + precio + "\n" + "Año " + anio + "\n";
        }
    }
}