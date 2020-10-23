using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public List<Tratamiento> Tratamientos { get; set; }

        public Cliente()
        {
            Tratamientos = new List<Tratamiento>();
        }
        public double CosteTotal()
        {
            double total = 0;
            foreach(Tratamiento t in Tratamientos)
            {
                total += t.Precio;
            }

            return total;
        }
        public override string ToString()
        {
            string cliente = "Cliente----- \n\tDni:" + Dni + " Nombre: " + Nombre + "\n";

            string tratamientos = "Tratamientos:\n";
            foreach (Tratamiento t in Tratamientos)
            {
                tratamientos += "\t" + t.Descripcion + " " + t.Precio + "\n";
            }
            string total = "El precio total es " + CosteTotal();
            return cliente + tratamientos + total;
        }
    }
}
