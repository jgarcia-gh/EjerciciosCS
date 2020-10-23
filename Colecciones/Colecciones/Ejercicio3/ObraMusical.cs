using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class ObraMusical : Obra
    {
        public string Estilo { get; set; }

        public ObraMusical(string nombre, Autor autor) : base(nombre, autor)
        {
        }
        public ObraMusical(string nombre, Autor autor, String estilo) : base(nombre, autor)
        {
            Estilo = estilo;
        }

        public override string ToString()
        {
            return base.ToString() + "\nEstilo: " + (Estilo != null ? Estilo : "-");
        }
    }
}
