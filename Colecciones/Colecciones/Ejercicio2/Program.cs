using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Serie> series = new List<Serie>();

            Serie s = new Serie()
            {
                Titulo = "The Witcher",
                Plataforma = "Netflix"
            };

            series.Add(s);

            s = new Serie()
            {
                Titulo = "Modern Family",
                Plataforma = "Netflix"
            };

            series.Add(s);

            s = new Serie()
            {
                Titulo = "Mr Robot",
                Plataforma = "Amazon Prime"
            };

            series.Add(s);

            s = new Serie()
            {
                Titulo = "Juego de Tronos",
                Plataforma = "HBO"
            };

            series.Add(s);

            s = new Serie()
            {
                Titulo = "Roma",
                Plataforma = "HBO"
            };

            series.Add(s);

            // Mostramos las series
            MostrarSeries(series);


            // Pedimos una plataforma de streaming. De la plataforma elegida se borrarán todas las películas
            Console.WriteLine("Introduce el nombre de la plataforma de la que quieres borrar sus películas: ");
            string plataforma = Console.ReadLine();
            int num = BorraSeries(series, plataforma);
            Console.WriteLine("En total se han borrado " + num + " series");

            // Volvemos a mostrar las series
            MostrarSeries(series);


            Console.ReadKey();

        }
        /* Método para borrar las series de la plataforma indicada */
        public static int BorraSeries(List<Serie> sr, string plataforma)
        {
            int numSeriesBorradas = 0;
            for (int i = sr.Count - 1; i >= 0; i--)
            {
                if (sr[i].Plataforma.ToLower() == plataforma.ToLower())
                {
                    numSeriesBorradas++;
                    sr.RemoveAt(i);
                }
            }
            return numSeriesBorradas;
        }

        /* Método para mostrar las series */
        public static void MostrarSeries(List<Serie> series)
        {
            Console.WriteLine("-------");
            Console.WriteLine("Series:");
            foreach (Serie serie in series)
            {
                Console.WriteLine(serie.Titulo + " - " + serie.Plataforma);
            }
            Console.WriteLine("-------");
        }
    }
}
