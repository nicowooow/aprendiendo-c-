namespace Primer_Programa_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("username : ");
            /* esto nos servira para hacer entradas por teclado Console.Read() y Console.ReadLine() */
            string username = Console.ReadLine();
            // si queremos que la variable funcione dentro de console.write tenemos que poner el " $ "
            // adelante de las comillas y la variable dentro { __varible__ }
            Console.WriteLine($"Hello, {username}!");
        }
    }
}
