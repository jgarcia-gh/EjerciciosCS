using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitamos la nota
            Console.WriteLine("Introduce una nota: ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 0 && nota <= 4)
            {
                Console.WriteLine("Insuficiente");
            }
            else if (nota == 5)
            {
                Console.WriteLine("Suficiente");
            }
            else if (nota == 6)
            {
                Console.WriteLine("Bien");
            }
            else if (nota < 9)
            {
                Console.WriteLine("Notable");
            }
            else if (nota < 10)
            {
                Console.WriteLine("Sobresaliente");
            }
            else
            {
                // Si no se ha cumplido ninguna de las condiciones anteriores la nota está fuera de rango
                Console.WriteLine("Nota fuera de rango");
            }

            Console.ReadKey();
        }
    }
}
