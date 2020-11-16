using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("EJERCICIO 1");
            //Muestra las palabras de la lista que empiezan por la letra M.
            List<string> frutas = new List<string>() {
                 "Limon", "Manzana", "Naranja", "Lima", "Sandía", "Melón" };

            // Primer opción: con for
            Console.WriteLine("Opción con for");
            for (int i = 0; i < frutas.Count; i++)
            {
                if (frutas[i][0] == 'M')
                {
                    Console.WriteLine(frutas[i]);
                }
            }

            Console.WriteLine("Opción con foreach");
            // Segunda opción: con foreach
            foreach (string fruta in frutas)
            {
                if (fruta[0] == 'M')
                {
                    Console.WriteLine(fruta);
                }
            }

            Console.WriteLine("Opción 1 con linq");
            // Tercera opción: con linq
            IEnumerable<string> f = from fruta in frutas
                                    where fruta[0] == 'M' || fruta[0] == 'm'
                                    select fruta;

            foreach (string fr in f)
            {
                Console.WriteLine(fr);
            }

            Console.WriteLine("Opción 2 con linq");
            // O también

            IEnumerable<string> enumFrut = frutas.Where(fruta => fruta.StartsWith("m") ||
                                                        fruta.StartsWith("M"));


            foreach (string ef in enumFrut)
            {
                Console.WriteLine(ef);
            }

            // Muestra los números que son múltiplos de 4 o 6.

            Console.WriteLine("EJERCICIO 2");

            List<int> numeros = new List<int>()
            {
             15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine("Opción 1 con linq");
            IEnumerable<int> n = from num in numeros
                                 where (num % 4 == 0) || (num % 6 == 0)
                                 select num;

            foreach (int num in n)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("Opción 2 con linq");
            // Otra forma de hacerlo con linq
            IEnumerable<int> n2 = numeros.Where(num => (num % 4 == 0) || (num % 6 == 0));

            foreach (int num in n2)
            {
                Console.WriteLine(num);
            }

            // Muestra los nombres ordenados alfabéticamente.
            Console.WriteLine("EJERCICIO 3");
            List<string> nombres = new List<string>()
             {
             "Sara", "Lourdes", "Enrique", "María", "Sebastián", "Sergio",
             "Javier", "Carlos", "Rocío", "Adrián", "Marcos", "Daniel",
             "Sofía", "Amanda", "Ricardo", "Ariadna", "Bruno",
             "Gregorio", "Pablo", "Evangelina", "Víctor", "Irene",
             "Francisco", "Martín"
             };


            Console.WriteLine("Opción 1 con linq");
            IEnumerable<string> resultado = from nombre in nombres
                                            orderby nombre ascending
                                            select nombre;
            foreach (string nombre in resultado)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("Opción 2 con linq");
            List<string> resultado2 = nombres.OrderBy(nom => nom).ToList();

            foreach (string nombre in resultado2)
            {
                Console.WriteLine(nombre);
            }

            //Muestra la suma de todos los valores.
            Console.WriteLine("EJERCICIO 4");
            List<double> adquisiciones = new List<double>()
             {
             2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
             };

            Console.WriteLine("Opción 1 con linq");

            double total = adquisiciones.Sum();
            Console.WriteLine("El total es " + total);

            Console.WriteLine("Opción 2 con linq");
            double total2 = (from cantidad in adquisiciones select cantidad).Sum();
            Console.WriteLine("El total es " + total2);


            //Muestra el valor más alto.
            Console.WriteLine("EJERCICIO 5");

            List<double> precios = new List<double>()
             {
             879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
             };


            Console.WriteLine("Opción con for");
            double precioMayor = 0;
            for (int i = 0; i < precios.Count; i++)
            {
                if (precios[i] > precioMayor)
                {
                    precioMayor = precios[i];
                }
            }
            Console.WriteLine("El precio máximo es: " + precioMayor);

            Console.WriteLine("Opción 1 con linq");
            double maximo = precios.Max();
            Console.WriteLine("El precio más alto es: " + maximo);

            // Crea una clase alumno con dos propiedades: Nombre y Nota.
            // En el programa principal crea la siguiente lista:
            List<Alumno> alumnos = new List<Alumno>
            {
             new Alumno {Nombre = "Juan", Nota = 5},
             new Alumno {Nombre = "Pedro", Nota = 8},
             new Alumno {Nombre = "Andrés", Nota = 3}
            };
            //6.Muestra únicamente los nombres de los alumnos.
            Console.WriteLine("EJERCICIO 6");
            Console.WriteLine("Opción 1 con Linq");
            IEnumerable<string> nombreAlumnos = from al in alumnos
                                                select al.Nombre;
            foreach (string nom in nombreAlumnos)
            {
                Console.WriteLine(nom);
            }
            Console.WriteLine("Opción 2 con Linq");
            IEnumerable<string> nombreAlumnos2 = alumnos.Select(al => al.Nombre);
            foreach (string nom in nombreAlumnos2)
            {
                Console.WriteLine(nom);
            }
            //7.Muestra la nota media de todos los alumnos.
            // Primero obtenemos las notas
            Console.WriteLine("EJERCICIO 7");
            double media = (alumnos.Select(al => al.Nota)).Average();
            Console.WriteLine("La nota media de los alumnos es: " + media);

            //8.Muestra el nombre de los alumnos que estén aprobados
            Console.WriteLine("EJERCICIO 8");
            Console.WriteLine("Opción 1 con linq");
            IEnumerable<string> nombreAlumnos3 = from al in alumnos
                                                 where al.Nota >= 5
                                                 select al.Nombre;

            foreach (string nombre in nombreAlumnos3)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("Opción 2 con linq");
            IEnumerable<string> nombreAlumnos4 = alumnos.Where(al => al.Nota >= 5).Select(al => al.Nombre);
            foreach (string nombre in nombreAlumnos4)
            {
                Console.WriteLine(nombre);
            }
            Console.ReadKey();
        }

    }
}

