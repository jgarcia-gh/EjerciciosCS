using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    public class ObraArte : Obra
    {
        public string Tecnica { get; set; }

        public ObraArte(string nombre, Autor autor) : base(nombre, autor)
        {
        }
        public ObraArte(string nombre, Autor autor, String tecnica) : base(nombre, autor)
        {
            Tecnica = tecnica;
        }

        public override string ToString()
        {
            return base.ToString() + "\nTécnica: " + (Tecnica!=null? Tecnica : "-");
        }
    }
}
