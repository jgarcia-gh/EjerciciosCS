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



            List<Pelicula> peliculas = new List<Pelicula>();

            bool continuar = true;
            while (continuar)
            {
                // Solicitamos título, año y género de la película

                Console.Write("Introduzca el título de la película: ");
                string titulo = Console.ReadLine();

                Console.Write("Introduzca el año de filmación: ");
                int anyo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca el género de la película: ");
                string genero = Console.ReadLine();

                Pelicula p = new Pelicula(titulo, genero, anyo);

                //Pedimos los datos de los actores
                bool fin = false;
                while (!fin)
                {
                    Console.Write("Dime un actor: ");
                    string nombreActor = Console.ReadLine();

                    Console.Write("Dime un año de nacimiento: ");
                    int anyoNacimiento = Convert.ToInt32(Console.ReadLine());

                    Actor ac = new Actor(nombreActor, anyoNacimiento);
                    p.Actores.Add(ac);

                    Console.WriteLine("¿Desea añadir otra actor? [s/n]");
                    string ok = Console.ReadLine();
                    fin = !(ok == "si" || ok == "s");
                }

                peliculas.Add(p);

                Console.WriteLine("¿Desea añadir otra película? [s/n]");
                string res = Console.ReadLine();
                continuar = (res == "si" || res == "s");
            }

            Console.WriteLine("-----------PELICULAS------------");

            // Mostramos los datos de la película
            foreach (Pelicula peli in peliculas)
            {
                Console.WriteLine(peli + "\n");
            }
            Console.ReadKey();

        }
    }
}
