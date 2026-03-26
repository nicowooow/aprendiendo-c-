

namespace ClaseGenericaEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ejercio pero con listas");
            
            Lista<int?> listaEnteros = new Lista<int?>();
            listaEnteros.Count();
            listaEnteros.MostrarElementos();
            listaEnteros.Add(1);
            listaEnteros.Add(2);
            listaEnteros.MostrarElementos();
            listaEnteros.Remove(1);
            listaEnteros.MostrarElementos();
            listaEnteros.Contains(1);
            listaEnteros.Count();
            listaEnteros.MostrarElementos();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ejercio pero con clases");
            Lista<Persona?> listaPersonas = new Lista<Persona?>();
            listaPersonas.Count();
            listaPersonas.MostrarElementos();
            listaPersonas.Add(new Persona());
            listaPersonas.Add(new Persona("a","b"));
            listaPersonas.MostrarElementos();
            listaPersonas.Remove(new Persona());
            listaPersonas.MostrarElementos();
            listaPersonas.Contains(new Persona("a", "b"));
            listaPersonas.Count();
            listaPersonas.MostrarElementos();
        }
    }
}
