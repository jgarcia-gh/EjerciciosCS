using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos e inicializamos el array.
            int[] array = new int[10];

            // Instanciamos la clase Random
            Random random = new Random();

            // Asignamos valores
            for (int i = 0; i < array.Length;  i++ )
            {
                array[i] = random.Next(0, 11);
                // El siguiente código comentado permite mostrar los elementos del array
                //Console.Write(array[i] + " ");
                //Console.WriteLine();
            }

            // Pedimos un número
            Console.Write("Escribe un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // Recorremos el array para contar cuántas veces aparece ese número
            int contador = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    contador++;
                }
            }

            Console.WriteLine("El número " + num + " aparece " + contador + " veces en el array");
            Console.ReadKey();
        }
    }
}
