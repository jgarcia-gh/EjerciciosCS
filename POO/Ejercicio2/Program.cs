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
            // Array para guardar las cuatro obras
            Obra[] obras = new Obra[4];

            // Instanciamos las obras y las vamos guardando en el array
            Obra o1 = new Obra("La noche estrellada", 1889);
            o1.CambiaAutor("Vincent van Gogh");
            o1.CambiaEstilo("Posimpresionismo");
            obras[0] = o1;

            Obra o2 = new Obra("La Gioconda", 1503);
            o2.CambiaAutor("Leonardo da Vinci");
            o2.CambiaEstilo("Renacimiento");
            obras[1] = o2;

            Obra o3 = new Obra("Guernica", 1937);
            o3.CambiaAutor("Pablo Picasso");
            o3.CambiaEstilo("Cubismo");
            obras[2] = o3;

            Obra o4 = new Obra("El beso", 1908);
            o4.CambiaAutor("Gustav Klimt");
            o4.CambiaEstilo(" Modernismo");
            obras[3] = o4;

            /* Una vez guardadas las cuatro obras, recorremos el array y mostramos
             * los datos de la obra */

            foreach(Obra o in obras)
            {
                Console.WriteLine("Obra: " + o.ObtenTitulo());
                Console.WriteLine("Año: " + o.ObtenAnyo());
                Console.WriteLine("Autor: " + o.ObtenAutor());
                Console.WriteLine("Estilo: " + o.ObtenEstilo());
                Console.WriteLine("Antigüedad: " + o.ObtenAntiguedad() + " años");
                Console.WriteLine("----------------------------------------");
            }

            Console.ReadKey();

        }
    }
}
