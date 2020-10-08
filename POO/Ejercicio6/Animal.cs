using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Animal
    {
        public string Nombre { get; set; }
        public int AnyoNacimiento { get; set; }

        public Animal (string nombre, int anyoNacimiento)
        {
            Nombre = nombre;
            AnyoNacimiento = anyoNacimiento;
        }

        public int ObtenerEdad()
        {
            return DateTime.Now.Year - AnyoNacimiento;
        }
    }
}
