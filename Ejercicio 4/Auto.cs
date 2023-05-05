using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Auto : Vehiculo
    {
        // Atributos
        bool airbag;

        // Constructor
        public Auto(int id, string marca, string model, int km, decimal precio, int annio, bool airbag) : base(id, marca, model, km, precio, annio)
        {
            this.airbag = airbag;
        }

        // propiedades
        public bool Airbag { get => airbag; set => airbag = value; }

        // Métodos
        public override string ToString()
        {
            if (airbag)
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + (base.Precio + (decimal)200) + "\nAnnio: " + base.Annio;
            }
            else
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + base.Precio + "\nAnnio: " + base.Annio;
            }

        }

    }
}
