using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Programa_Consola.clases
{
    // internal, es para que funcione dentro del proyecto en el que se define
    internal class clase_perro : clase_animales
    {

        string nombre = "";

        public clase_perro(string nombre_)
        {
            nombre = nombre_;
        }

        public override void Comer()
        {
            Console.WriteLine("el perro esta comiendo croquetas");
        }
    }
}
