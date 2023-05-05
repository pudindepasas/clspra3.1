using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec = new Rectangulo(2, 2);
            Circulo cir = new Circulo(3);
            rec.coordenada = new Ubicacion(2, 4);
            rec.CalPerimetro();
            rec.CalArea();
            Console.WriteLine(rec.ToString());
            cir.coordenada = new Ubicacion(6, 9);
            cir.CalPerimetro();
            cir.CalArea();
            Console.WriteLine(cir.ToString());

            Console.ReadKey();
        }
    }
}