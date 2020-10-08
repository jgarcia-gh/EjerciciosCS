using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Obra
    {
        public String Nombre { get; set; }
        public Autor Autor { get; set; }
        public int AnyoCreacion { get; set; }

        public Obra(String nombre, Autor autor){
            this.Nombre = nombre;
            this.Autor = autor;
        }

        public override string ToString()
        {
            string cadena = "Nombre de la obra: " + Nombre;
            cadena += "\nAño : " + AnyoCreacion;
            cadena += "\nAutor: \n\t" + Autor.ToString();
            return cadena;
        }
    }
}
