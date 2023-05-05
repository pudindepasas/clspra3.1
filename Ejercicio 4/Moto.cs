using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
Crea una clase Vehículo que sea la misma que la clase Vehículo que se trabajo en el ejercicio 1.

Crea dos clases hijas: Auto y Moto

La clase Auto tendrá un atributo airbag, sobrescribe el método precio, si tiene airbag el precio aumentara $200.

La clase Moto tendrá un atributo sidecar, sobrescribe el método precio, si tiene sidecar el precio aumentara $50.

— Vehículo.
 */
namespace Ejercicio_4
{
    class Moto : Vehiculo
    {
        // Atributos
        bool sidecar;

        // Constructor
        public Moto(int id, string marca, string model, int km, decimal precio, int annio, bool sidecar) : base(id, marca, model, km, precio, annio)
        {
            this.sidecar = sidecar;
        }

        // propiedades
        public bool Sidecar { get => sidecar; set => sidecar = value; }

        // Métodos
        public override string ToString()
        {
            if (sidecar)
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + (base.Precio + (decimal)50) + "\nAnnio: " + base.Annio;
            }
            else
            {
                return "Modelo: " + base.Model + "\nMarca: " + base.Marca + "\nKilometraje: " + base.Km + "\nPrecio: " + base.Precio + "\nAnnio: " + base.Annio;
            }

        }
    }
}
