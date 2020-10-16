using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Actor
    {

        public string Nombre { get; set; }
        public int AnyoNacimiento { get; set; }

        public Actor(string nombre, int anyoNacimiento)
        {
            Nombre = nombre;
            AnyoNacimiento = anyoNacimiento;
        }

        public override string ToString()
        {
            return Nombre + " " + AnyoNacimiento;
        }
    }
}
