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
    internal class Moto : Vehiculo
    {
        int id;
        string marca;
        string modelo;
        int km;
        decimal precio;
        int anio;
        int airbag;

        public Moto(int id, string marca, string modelo, int km, decimal precio, int anio) : base(id, marca, modelo, km, precio, anio)
        {
        }
    }
}
