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
            Console.Write("Introduce un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Con la variable i recorremos del 1 al número introducido
            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Tabla del " + i);
                Console.WriteLine("----------------------------");


                // Con la variable j recorremos del 1 al 10
                for (int j = 1; j <= 10; j++)
                {
                    // Calculamos el producto
                    int res = i * j;
                    // Mostramos por pantalla el resultado
                    Console.WriteLine(i + " x " + j + " = " + res);
                }
            }

            Console.ReadKey();
        }
    }
}
