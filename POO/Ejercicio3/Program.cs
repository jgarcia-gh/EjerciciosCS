using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos la instancia de una piscina
            Piscina p = new Piscina(10, 20, 5);
            // Obtenemos la descripción
            string descripcion = p.ObtenDescripcion();
            // Mostramos la descripción por pantalla
            Console.WriteLine(descripcion);
            Console.ReadKey();
        }
    }
}
