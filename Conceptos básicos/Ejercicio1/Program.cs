using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            // Solicitamos los tres números
            Console.WriteLine("Introduce el primer número:");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Introduce el segundo número:");
            Int32.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Introduce el tercer número:");
            Int32.TryParse(Console.ReadLine(), out num3);

            // Comprobamos si num1 está entre num2 y num3 o si num1 está entre num3 y num2
            if (num1 > num2 && num1 < num3 || num1 > num3 && num1 < num2)
            {
                Console.WriteLine(num1 + " se encuentra entre " + num2 + " y " + num3);
            }
            else
            {
                Console.WriteLine(num1 + " NO se encuentra entre " + num2 + " y " + num3);
            }

            /* Console.ReadKey(); al final del programa sirve para que la aplicación no se 
             * cierre hasta que el usuario no pulse una tecla*/
            Console.ReadKey();
        }
    }
}
