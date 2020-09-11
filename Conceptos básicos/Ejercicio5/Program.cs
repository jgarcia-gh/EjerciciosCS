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

            // Pedimos los dos valores mínimo y máximo
            Console.Write("Introduce el valor mínimo del rango: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el valor máximo del rango: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int valor;

            do
            {
                // Pedimos el tercer valor
                Console.Write("Introduce un valor entre " + min + " y " + max + ": ");
                valor = Convert.ToInt32(Console.ReadLine());


                /* Comprobamos si el valor está dentro del rango, en caso contrario, 
                 * mostramos un mensaje de error */
                if (valor < min || valor > max)
                {
                    Console.WriteLine("Valor introducido está fuera de rango");
                }
            /* En la condición del while comprobamos de nuevo si el valor está dentro de rango o no. 
             * Si no está dentro de rango volveremos a pedir que el usuario introduzca un nuevo valor
             */
            } while ( valor<min || valor>max ); 

        }
    }
}
