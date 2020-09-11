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
            // Mostramos el menú
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");

            // Solicitamos que el usuario indique la opción
            Console.WriteLine("Indica una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Y pedimos dos números
            Console.WriteLine("Indica el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indica el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res = 0;

            // Variable que utilizamos para saber si el usuario ha elegido una opción válida o no
            bool operacionValida = true;

            // En función de la opción escogida haremos una suma, resta, multiplicación o división
            switch (opcion)
            {
                case 1:
                    res = num1 + num2;
                    break;
                case 2:
                    res = num1 - num2;
                    break;
                case 3:
                    res = num1 * num2;
                    break;
                case 4:
                    res = num1 / num2;
                    break;
                default:
                    // No se ha elegido una opción válida
                    operacionValida = false;
                    Console.WriteLine("Operación inválida");
                    break;
            }

            if (operacionValida)
            {
                // Solo se muestra este mensaje si la opción elegida por el usuario es válida
                Console.WriteLine("Resultado " + res);
            }

            Console.ReadKey();
        }
    }
}
