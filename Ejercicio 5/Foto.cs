using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_5
{
    internal class Foto
    {
        int idfoto;
        int tamaniomb;
        int fecha;
        string comentarios;

        public Foto(int idfoto, int tamaniomb, int fecha, string comentarios)
        {
            this.Idfoto = idfoto;
            this.Tamaniomb = tamaniomb;
            this.Fecha = fecha;
            this.Comentarios = comentarios;
             
        }

       
        public int Idfoto { get => idfoto; set => idfoto = value; }
        public int Tamaniomb { get => tamaniomb; set => tamaniomb = value; }
        public int Fecha { get => fecha; set => fecha = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        public override string ToString()
        {
            return "ID de la foto " + idfoto + "\n" + "Tamaño en MB " + tamaniomb + "\n" + "Fecha " + fecha + "\n" + "Comentarios " + comentarios + "\n";
        }

    }

}
