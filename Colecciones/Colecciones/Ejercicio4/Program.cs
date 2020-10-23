using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Cliente> clientes = new Dictionary<string, Cliente>();
            StreamReader sr = new StreamReader("Datos.txt");
            do
            {
                String s = sr.ReadLine();
                String[] tokens = s.Split(';');

                Cliente c = new Cliente();
                c.Dni = tokens[0];
                c.Nombre = tokens[1];

                List<Tratamiento> tratamientos = new List<Tratamiento>();
                for(int i = 2; i<tokens.Length-1; i+=2)
                {
                    Tratamiento t = new Tratamiento();
                    t.Descripcion = tokens[i];
                    t.Precio = Convert.ToDouble(tokens[i + 1]);
                    c.Tratamientos.Add(t);
                }
                clientes.Add(c.Dni, c);
            } while (!sr.EndOfStream);

            Console.Write("Introduce un DNI: ");
            String dni = Console.ReadLine();
            if (clientes.ContainsKey(dni))
            {
                Console.WriteLine(clientes[dni]);
            }
            
            Console.ReadKey();
        }
    }
}
