using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Programa_Consola
{
    public static class crear_extensiones
    {
        public static void ImprimirConsola(this string input)
        {
            Console.WriteLine(input);
        }
    }
}
