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
            List<Obra> obras = new List<Obra>();

            Autor a = new Autor("Goya");
            a.AnyoNacimiento = 1746;

            ObraArte oa = new ObraArte("Perro semihundido", a);
            oa.Tecnica = "Óleo sobre revoco";
            obras.Add(oa);
            obras[0].AnyoCreacion = 1823;
            obras.Add(new ObraArte("El quitasol", a));
            obras[1].AnyoCreacion = 1777;

            a = new Autor("Beethoven");
            a.AnyoNacimiento = 1770;
            ObraMusical om = new ObraMusical("Para Elisa", a);
            om.Estilo = "Clásica";
            om.AnyoCreacion = 1810;
            obras.Add(om);
            a = new Autor("Vivaldi");
            a.AnyoNacimiento = 1678;
            om = new ObraMusical("Las cuatro estaciones", a);
            om.AnyoCreacion = 1721;
            obras.Add(om);

            a = new Autor("Cervantes");
            a.AnyoNacimiento = 1547;
            ObraLiteraria ol = new ObraLiteraria("Don Quijote", a);
            ol.Genero = "Novela";
            ol.AnyoCreacion = 1605;
            obras.Add(ol);
            a = new Autor("Quevedo");
            a.AnyoNacimiento = 1580;
            ol = new ObraLiteraria("Sueños y discursos", a);
            obras.Add(ol);
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
