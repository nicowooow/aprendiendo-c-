using System;
using System.Collections.Generic;
using System.Text;

namespace Metodos_de_extension
{
    public static class Extensiones
    {

        extension(string srt)
        {
            public string ToTitleCase()
            {

                string[] palabras = srt.Split(" "); // partimos la cadena de texto siempre y cuando tenga un espacio de por medio
                string texto = ""; // variable vacia STRING
                for (int i = 0; i < palabras.Length; i++) // bucle para alcanzar a la longitud de la palabra
                {
                    texto += palabras[i][..1].ToUpper() + palabras[i][1..]+ " "; 
                    // con el [..numero] es desde el inico hasta el numero
                    // con el [numero..] es desde dicho numero hasta el final
                    // con [numero1..numero2] desde que numero hasta que numero
                }

                return texto;
            }

            public string ToReverse()
            {
                string texto = "";
                for (int i = srt.Length; i > 0; i--)
                {
                    texto += srt[i - 1];
                }
                return texto;
            }
        }

        extension (int number)
        {
            public bool EsPar()
            {
                return Convert.ToBoolean(number % 2);
            }

            public int Factorial()
            {
                int factorial = 1;

                while(number != 0)
                {
                    factorial *= number;
                    number--;
                }

                return factorial;
            }
        }
    }
}
