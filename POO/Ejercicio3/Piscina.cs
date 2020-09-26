using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Piscina
    {
        /* El ancho, largo, profundo y altura del agua se han definido como propiedades
         * En C# el convenio utilizar propiedades y no atributos.
         * La diferencia es que un atributo se declara de la siguiente forma: 
         * private double ancho;
         * y requiere la definición de un método para obtener su valor y otro para modificarlo (getter y setter)
         */

        public double Ancho { get; set; }
        public double Largo { get; set; }
        public double Profundo { get; set; }
        public double AlturaAgua { get; set; }

        public Piscina(double ancho, double largo, double profundo)
        {
            Ancho = ancho;
            Largo = largo;
            Profundo = profundo;
            AlturaAgua = 0;  // El enunciado indica que por defecto es 0
        }

        public string ObtenDescripcion()
        {
            //Devolvemos un string ¡No lo mostramos por pantalla!
            //En las clases vamos a evitar utilizar el Console.WriteLine()
            return "Ancho: " + Ancho + " Largo: " + Largo + " Profundo: " + Profundo + " Altura del agua: " + AlturaAgua;
        }

    }
}
