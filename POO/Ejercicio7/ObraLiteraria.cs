using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class ObraLiteraria : Obra
    {
        public string Genero { get; set; }

        public ObraLiteraria(string nombre, Autor autor) : base(nombre, autor)
        {
        }
        public ObraLiteraria(string nombre, Autor autor, String genero) : base(nombre, autor)
        {
            Genero = genero;
        }

        public override string ToString()
        {
            return base.ToString() + "\nGénero: " + (Genero != null ? Genero : "-");
        }
    }
}
