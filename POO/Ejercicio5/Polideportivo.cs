using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Polideportivo
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Anyo { get; set; }

        public Polideportivo(string nombre, string direccion, int anyo)
        {
            Nombre = nombre;
            Direccion = direccion;
            Anyo = anyo;
        }
    }
}
