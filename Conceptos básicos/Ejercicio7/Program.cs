using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números quieres introducir?");
            int longitud = Convert.ToInt32(Console.ReadLine());

            // Creamos un array de la longitud indicada por el usuario
            int[] numeros = new int[longitud];

            // Utilizamos un bucle for para pedir los números que guardaremos en el array
            for(int i=0; i<numeros.Length; i++)
            {
                Console.Write("Introduce el número " + (i+1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Los números introducidos en orden inverso son: ");

            // Recorremos el array al revés para mostrar los valores por pantalla
            for (int i = numeros.Length-1; i >= 0; i--)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
