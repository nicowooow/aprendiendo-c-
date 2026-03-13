using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Channels;

namespace Primer_Programa_Consola
{
    internal class Conditionals_estructura_de_control_
    {

        // se tiene los mismo de otros lenguajes de programacion
        public void suma( int v1, int v2)
        {
            Console.WriteLine( v1 + v2);
        }

        public void condicionales(bool v1, bool v2, int v3, int v4)
        {

            // SECUENCIA IF, ELSE IF, ELSE
            if (v1 == v2)
            {
                Console.WriteLine("v1 es igual que v2, pero no al 100%");
            }else if (v3 <= v4)
            {
                Console.WriteLine("v3 es menor que v4");
            }
            else
            {
                Console.WriteLine("else por deecto");
            }

            // OPERADORES TERNARIOS
            string result = v4 == v3 ? "son iguales":"no son iguales";

            // SWITCH 
            int caso = 0;
            switch (caso)
            {
                case 0:
                    Console.WriteLine("caso 0");
                    break;
                case 1:
                    Console.WriteLine("caso 1");
                    break;
                case 2:
                    Console.WriteLine("caso 2");
                    break;

                default:
                    Console.WriteLine("caso por defecto");
                    break;
            }

            // BUCLES
            int vueltas = 10;
            
            // FOR
            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine($"vuelta numero {i}");
            }

            // WHILE
            while (vueltas >= 0)
            {
                Console.WriteLine($"vuelta numero {vueltas}");
                vueltas--;
            }

            // DO WHILE
            do
            {
                Console.WriteLine($"vuelta numero {vueltas}");
                vueltas++;
            }
            while (vueltas<= 10);

            // FOREACH

            foreach (int item in new int[4] { 1,2,3,4})
            {
                Console.WriteLine($"item {item}");
            }
        }
    }
}
