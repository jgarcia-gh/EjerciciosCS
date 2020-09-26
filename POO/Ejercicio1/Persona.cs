using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Persona
    {
        // Atributos de una persona (por defecto private)
        string nombre;
        int edad;
        double peso;
        double altura;

        /* Métodos para obtener los diferentes atributos
           Cuando expliquemos las propiedades utilizaremos siempre propiedades
           en vez de estos métodos */
        public string ObtenNombre()
        {
            return nombre;
        }
        public int ObtenEdad()
        {
            return edad;
        }
        public double ObtenPeso()
        {
            return peso;
        }
        public double ObtenAltura()
        {
            return altura;
        }

        /* Métodos para modificar los diferentes atributos
           Cuando expliquemos las propiedades utilizaremos siempre propiedades
           en vez de estos métodos*/
        public void CambiaNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void CambiaEdad(int edad)
        {
            this.edad = edad;
        }
        public void CambiaPeso(double peso)
        {
            this.peso = peso;
        }
        public void CambiaAltura(double altura)
        {
            this.altura = altura;
        }

        /* Con los constructores hacemos que sea obligatorio indicar ciertos atributos
         * al instanciar la clase. De esta forma nos aseguramos que los atributos
         * tienen ciertos valores. Como ejemplo se han añadido dos constructores.
         * 
         * El valor de los atributos posteriormente se puede modificar con los métodos
         * CambiaAltura, CambiaEdad, CambiaNombre, etc.*/

        // Constructor que recibe como parámetros el nombre, peso y altura
        public Persona(string nombre, double peso, double altura)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.altura = altura;
        }
        // Constructor que recibe como parámetros todos los atributos
        public Persona (string nombre, int edad, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.peso = peso;
            this.altura = altura;
        }
        // Método para obtener el índice de masa corporal
        public double ObtenIMC()
        {
            return peso / Math.Pow(altura, 2);
        }


    }
}
