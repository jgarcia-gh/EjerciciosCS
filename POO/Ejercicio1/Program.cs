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

            // Pedimos los datos por consola
            Console.Write("Introduce el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduce la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Instanciamos la clase persona, pasándole los valores introducidos por el usuario
            Persona p = new Persona(nombre, edad, peso, altura);

            // Mostramos los datos por pantalla, incluído el IMC
            Console.WriteLine("Los datos de la persona son:");
            Console.WriteLine("Nombre: " + p.ObtenNombre());
            Console.WriteLine("Edad: " + p.ObtenEdad());
            Console.WriteLine("Peso: " + p.ObtenPeso());
            Console.WriteLine("Altura: " + p.ObtenAltura());
            Console.WriteLine("IMC: " + p.ObtenIMC());
            Console.ReadKey();


        }
    }
}
