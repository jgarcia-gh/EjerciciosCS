using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Rufo", 2009);
            Console.WriteLine(a.Nombre + " es un animal que nació en " + a.AnyoNacimiento + " y tiene " + a.ObtenerEdad() + " años.");

            Gato g = new Gato("Runchi", 2011);
            Console.WriteLine(g.Nombre + " es un gato que nació en " + g.AnyoNacimiento + " y tiene " + g.ObtenerEdad() + " años que son " + g.ObtenerEdadHumana() + " años humanos");
            Console.ReadKey();
        }
    }
}
