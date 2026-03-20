using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Primer_Programa_Consola.clases
{
    internal class clase_animales: I_interfaz_animal
    {

        public virtual void Comer()
        {
            Console.WriteLine("el animal esta comiendo");
        }

        public void Dormir()
        {
            Console.WriteLine("el animal esta durmiendo");
        }

    }
}
