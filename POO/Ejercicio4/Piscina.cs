using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
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

        public void Llenar(double metros)
        {
            if(AlturaAgua + metros <= Profundo)
            {
                /* En este caso al sumar los metros a la altura del agua, el resultado es igual o inferior a la profundidad,
                 * por lo que el nivel del agua no desborda y es correcto. Podemos modificar la altura del agua.*/
                AlturaAgua += metros;
            } else
            {

                /* En este caso al sumar los metros a la altura del agua, el resultado es superior a la profundidad,
                 * por lo que el nivel del agua ha desbordado (estamos intentando llenar la piscina con más agua de la que cabe).
                 * Especificamos que la altura del agua es igual a la profundidad, es decir, la piscina está llena.*/
                AlturaAgua = Profundo;
            }
        }

        public void Vaciar(double metros)
        {
            if (AlturaAgua - metros >= 0)
            {
                /* En este caso al restar los metros a la altura del agua, el resultado es superior o igual a 0,
                 * por lo que el nivel del agua es correcto. Podemos modificar la altura del agua.*/
                AlturaAgua -= metros;
            }
            else
            {
                /* En este caso al restar los metros a la altura del agua, el resultado inferior a 0,
                 * por lo que el nivel del agua no es correcto (estamos vaciando más agua de la que hay).
                 * Especificamos que la altura del agua es 0 (piscina vacía).*/
                AlturaAgua = 0;
            }
        }

        public double CantidadLitros()
        {
            double volumen = AlturaAgua * Ancho * Largo;
            double litros = volumen * 1000;
            return litros;
        }

        public string ObtenDescripcion()
        {
            //Devolvemos un string ¡No lo mostramos por pantalla!
            //En las clases vamos a evitar utilizar el Console.WriteLine()
            return "Ancho: " + Ancho + " Largo: " + Largo + " Profundo: " + Profundo + " Altura del agua: " + AlturaAgua;
        }

    }
}
