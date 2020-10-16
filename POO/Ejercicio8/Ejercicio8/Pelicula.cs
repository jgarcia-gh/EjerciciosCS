using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Pelicula
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public List<Actor> Actores { get; set; }
        public int Anyo { get; set; }

        // En este constructor solo pedimos título, género y año
        public Pelicula(string titulo, string genero, int anyo)
        {
            Titulo = titulo;
            Genero = genero;
            Anyo = anyo;
            Actores = new List<Actor>(); // Instancio la lista
        }

        // En este constructor recibimos un actor
        public Pelicula(string titulo, string genero, int anyo, Actor actor)
        {
            Titulo = titulo;
            Genero = genero;
            Anyo = anyo;
            Actores = new List<Actor>(); // Instancio la lista
            Actores.Add(actor);
        }

        // En este constructor recibo muchos actores
        public Pelicula(string titulo, string genero, int anyo, List<Actor> actores)
        {
            Titulo = titulo;
            Genero = genero;
            Anyo = anyo;
            Actores = actores;
        }


        public override string ToString()
        {
            string descripcion = "Película:\n" + Titulo + " filmada en " + Anyo + " y su género es " + Genero + "\nActores: \n";
            for (int i = 0; i < Actores.Count; i++)
            {
                descripcion += Actores[i] + "\n";
            }
            return descripcion;
        }
    }
}
