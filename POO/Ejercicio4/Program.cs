using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos la instancia de una piscina
            Piscina p = new Piscina(10, 20, 5);

            // Llenamos la piscina

            p.Llenar(1);
            // En total hemos llenado 1 metro
            Console.WriteLine("La piscina tiene " + p.AlturaAgua + " metros de agua");

            p.Llenar(2);
            // En total hemos llenado 3 metros
            Console.WriteLine("La piscina tiene " + p.AlturaAgua + " metros de agua");

            p.Llenar(3);
            // La piscina desborda, por lo que la altura del agua debería ser la máxima (en este caso 5, que es la profundidad)
            Console.WriteLine("La piscina tiene " + p.AlturaAgua + " metros de agua");


            // Vaciamos la piscina

            p.Vaciar(3);
            // En total quedan 2 metros
            Console.WriteLine("La piscina tiene " + p.AlturaAgua + " metros de agua");

            p.Vaciar(3);
            // No podemos vaciar más agua de la que hay. La altura del agua se queda a 0
            Console.WriteLine("La piscina tiene " + p.AlturaAgua + " metros de agua");


            // Llenamos la piscina
            p.Llenar(2);
            Console.WriteLine("La piscina tiene " + p.AlturaAgua + " metros de agua");

            // Probamos el método CantidadLitros
            double totalLitros = p.CantidadLitros();
            Console.WriteLine("La cantidad total de litros es " + totalLitros);

            // Mostramos la descripción por pantalla
            Console.ReadKey();
        }
    }
}
