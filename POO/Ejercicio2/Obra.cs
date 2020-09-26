using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Obra
    {
        string titulo;
        string autor;
        int anyo;
        string estilo;

        /* Métodos para obtener y modificar los atributos.
         * Cuando expliquemos las propiedades dejaremos de utilizar estos métodos
         * para utilizar exclusivamente las propiedades 
         * */
        public string ObtenTitulo()
        {
            return titulo;
        }
        public void CambiaTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string ObtenAutor()
        {
            return autor;
        }
        public void CambiaAutor(string autor)
        {
            this.autor = autor;
        }
        public string ObtenAnyo()
        {
            return estilo;
        }
        public void CambiaEstilo(string estilo)
        {
            this.estilo = estilo;
        }
        public int ObtenEstilo()
        {
            return anyo;
        }
        public void CambiaAnyo(int anyo)
        {
            this.anyo = anyo;
        }
        public Obra (string titulo)
        {
            this.titulo = titulo;
        }
        public Obra(string titulo, int anyo)
        {
            this.titulo = titulo;
            this.anyo = anyo;
        }
        public int ObtenAntiguedad()
        {
           return DateTime.Now.Year - anyo;
        }


    }
}
