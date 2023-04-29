using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class CasaComercial
    {
        //campo de la clase Casa Comercial
        string nombre;
        string correo;
        int total;
        //esto es composicion, ya que la clase casa comercial tiene una lista de objetos de de tipo vehiculo
        //si hay una lista, se hace una composición
        List<Vehiculo> vehiculos;

        //Constructor
        public CasaComercial(string nombre, string correo, int total, List<Vehiculo> vehiculos)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.total = total;
            this.vehiculos = vehiculos;
        }
        //Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Total { get => total; set => total = value; }
        internal List<Vehiculo> Vehiculos { get => vehiculos; set => vehiculos = value; }

        //áñadimos cada uno de los metodos

        public void aniadirVehiculo(Vehiculo V)
        {
            try
            {
                //añadimos un nuevo objeto a la lista vehiculo
                this.vehiculos.Add(V);
                //actualizamos el total de vehiculos
                this.total += 1;
                Console.WriteLine("Se añadió un nuevo vehiculo");
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se añadió un nuevo vehiculo debido a: \n" + ex.Message);
                Console.WriteLine();

            }

        }

        public void mostrarVehiculos()
        {
            foreach (Vehiculo v in this.vehiculos)
            {
                Console.WriteLine("------------");
                Console.WriteLine(v.ToString());
            }

        }

        public void vaciarVehiculo()
        {
            Console.WriteLine("Está segguro desea eliminar todos los elementos mostrados en la lista?: S/N");
            string response = Console.ReadLine();
            if (response == "S" || response == "s")
            {
                vehiculos = new List<Vehiculo>();
                this.total = 0;
                Console.WriteLine("Se han eliminado los objetos correctamente");

            }
            else
            {
                Console.WriteLine("No se eliminó, Hay {0} vehiculos registrados", total);
                Console.WriteLine("Enter para continuar.");
            }
            Console.ReadLine();
        }
        
        public void eliminarVehiculo()
        {
            vehiculos.Clear();
            total = 0;
            Console.WriteLine("Se ha eliminado el vehiculo", total);
            Console.ReadLine();

        }


    }
}