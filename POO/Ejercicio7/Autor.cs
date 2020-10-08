using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class Autor
    {
        public String Nombre { get; set; }
        public int AnyoNacimiento { get; set; }

        public Autor(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            string cadena = "Nombre: " + Nombre;
            cadena += "\n\tAño nacimiento: " + AnyoNacimiento;
            return cadena;
        }
    }
}
