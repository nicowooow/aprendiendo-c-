using Primer_Programa_Consola.clase_generica;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Primer_Programa_Consola
{
    // el <T> hace referencia a que tipo de dato usa la clase
    internal class Locker <T> where T: IObjetoLocker
    {

        public T ElementoGuardado { get; set; }

        public Locker(int alto, T elemento) 
        {

        }
        public bool EstaVacio()
        {
            return ElementoGuardado == null;
        }

        // metododo generico

        public T DameValor(T valor) {

            return valor;
        
        }
    }
}
