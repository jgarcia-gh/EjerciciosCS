using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[longitud];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Introduce el número " + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int cantidadNegativos = 0;
            int cantidadCeros = 0;
            int cantidadPositivos = 0;
            int sumaNegativos = 0;
            int sumaPositivos = 0;

            foreach (int num in numeros)
            {
                if(num < 0)
                {
                    // El número es negativo
                    cantidadNegativos++; 
                    sumaNegativos += num; // Vamos sumando los negativos

                } else if( num == 0)
                {
                    // El número es 0
                    cantidadCeros++;
                }
                else
                {
                    // El número es positivo
                    cantidadPositivos++;
                    sumaPositivos += num; // Vamos sumando los positivos

                }
            }

            // Si hay algún número negativo calculamos la media
            if(cantidadNegativos > 0)
            {
                double mediaNegativos = (double)sumaNegativos / cantidadNegativos;
                Console.WriteLine("La media de los negativos es " + mediaNegativos);
            }

            Console.WriteLine("El número de ceros es " + cantidadCeros);

            // Si hay algún número positivo calculamos la media
            if (cantidadPositivos > 0)
            {
                double mediaPositivos = (double)sumaPositivos / cantidadPositivos;
                Console.WriteLine("La media de los positivos es " + mediaPositivos);
            }


            Console.ReadKey();

        }
    }
}
