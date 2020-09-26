using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos/instanciamos la primera piscina
            Piscina piscina1 = new Piscina(20, 40, 6);
            // Creamos/instanciamos la segunda piscina
            Piscina piscina2 = new Piscina(10, 20, 5);

            // Creamos/instanciamos un polideportivo
            Polideportivo polideportivo = new Polideportivo("Polideportivo San Blas", "Calle sin nombre 5", 1995);

            // Asignamos a las piscinas EL MISMO polideportivo

            piscina1.Polideportivo = polideportivo;
            piscina2.Polideportivo = polideportivo;

            Console.WriteLine("La primera piscina tiene las siguientes características:");
            Console.WriteLine(piscina1.ObtenDescripcion());
            Console.WriteLine("Se encuentra en el polideportivo: ");
            Console.WriteLine(piscina1.Polideportivo.Nombre);
            Console.WriteLine(piscina1.Polideportivo.Direccion);


            Console.WriteLine("La segunda piscina tiene las siguientes características:");
            Console.WriteLine(piscina2.ObtenDescripcion());
            Console.WriteLine("Se encuentra en el polideportivo: ");
            Console.WriteLine(piscina2.Polideportivo.Nombre);
            Console.WriteLine(piscina2.Polideportivo.Direccion);

            Console.ReadKey();

        }
    }
}
