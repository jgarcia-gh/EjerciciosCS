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
            Obra[] obras = new Obra[6];

            Autor a = new Autor("Goya");
            a.AnyoNacimiento = 1746;

            ObraArte oa = new ObraArte("Perro semihundido", a);
            oa.Tecnica = "Óleo sobre revoco";
            obras[0] = oa;
            obras[0].AnyoCreacion = 1823;
            obras[1] = new ObraArte("El quitasol", a);
            obras[1].AnyoCreacion = 1777;

            a = new Autor("Beethoven");
            a.AnyoNacimiento = 1770;
            ObraMusical om = new ObraMusical("Para Elisa", a);
            om.Estilo = "Clásica";
            obras[2] = om;
            obras[2].AnyoCreacion = 1810;
            a = new Autor("Vivaldi");
            a.AnyoNacimiento = 1678;
            obras[3] = new ObraMusical("Las cuatro estaciones", a);
            obras[3].AnyoCreacion = 1721;


            a = new Autor("Cervantes");
            a.AnyoNacimiento = 1547;
            ObraLiteraria ol = new ObraLiteraria("Don Quijote", a);
            ol.Genero = "Novela";
            obras[4] = ol;
            obras[4].AnyoCreacion = 1605;
            a = new Autor("Quevedo");
            a.AnyoNacimiento = 1580;
            obras[5] = new ObraLiteraria("Sueños y discursos", a);
            obras[5].AnyoCreacion = 1627;

            int opcion;

            do
            {
                Console.WriteLine("BUSCADOR");
                Console.WriteLine("1. Buscar por nombre del autor");
                Console.WriteLine("2. Buscar por año de creación");
                Console.WriteLine("3. Mostrar todas");
                Console.WriteLine("4. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce el nombre del autor: ");
                        string nombre = Console.ReadLine();
                        // Buscamos por nombre

                        Console.WriteLine("Resultados--------");
                        foreach (Obra o in obras)
                            {
                                if(o.Autor.Nombre == nombre)
                                {
                                    Console.WriteLine(o.ToString());
                                }
                        }
                        Console.WriteLine("-----------------");
                        break;
                    case 2:
                        Console.Write("Introduce el año de la obra: ");
                        // Buscamos por año
                        int anyo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Resultados--------");
                        foreach (Obra o in obras)
                        {
                            if (o.AnyoCreacion == anyo)
                            {
                                Console.WriteLine(o.ToString());
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine("-----------------");

                        break;
                    case 3:

                        Console.WriteLine("Resultados--------");
                        foreach (Obra o in obras)
                        {
                             Console.WriteLine(o.ToString());
                            Console.WriteLine();
                        }
                        Console.WriteLine("-----------------");

                        break;
                    default:
                        Console.WriteLine("Introduce una opción válida. ");
                        break;

                }
            } while (opcion != 4);


        }
    }
}
