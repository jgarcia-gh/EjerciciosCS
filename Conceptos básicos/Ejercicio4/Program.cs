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
            Console.WriteLine("Escribe un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("Los números entre 0 y " + num + " son:");
                for (int i = 0; i<=num; i++)
                {
                    Console.WriteLine(i);
                }
            } else {
                Console.Write("Número inválido");
            }
            Console.ReadKey();
        }
    }
}
