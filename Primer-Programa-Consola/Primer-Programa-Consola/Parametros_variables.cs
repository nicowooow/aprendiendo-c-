using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Programa_Consola
{
    internal class Parametros_variables
    {
        // con la notación " params " sirve para queal introducir los datos no sea necesario ponerlos en
        // {} <= se consideran arrays
        // los llamarian asi ImprimirNumero(1,2,3) , sin que esten dentro de los ({1,2,3})
        public void ImprimirNumeros(params int[] numeros)
        {
            Console.WriteLine("numeros : ");
            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        // parametro nulo | parametro abligatorio | parametro por defecto ( siempre deben ir al fonal)
        public void NombreMetodo(int? parametro0, int parametro1, int parameto2 = 0)
        {
            Console.WriteLine("hoola");
        }
    }
}
