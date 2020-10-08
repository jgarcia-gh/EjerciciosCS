using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Gato : Animal
    {
        public Gato (string nombre, int anyoNacimiento):base(nombre, anyoNacimiento)
        {

        }

        public void Ronronear()
        {
            Console.WriteLine("BRRR");
        }

        public int ObtenerEdadHumana()
        {
            return ObtenerEdad() * 7;
        }
    }
}
