using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Primer_Programa_Consola
{
    //internal class Overloadable_operators
    //{
    public struct Complex // esta es una clase que representa a los numeros complejos
    {
        // {get; set;} es la forma corta de poner los getters y setters de la variable
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Acceso | Estático | Qué devuelve | Palabra clave | El símbolo | (Lo que sumas)
           public static Complex operator +(Complex c1, Complex c2) 
        {
            // con esto definiminos que el operador " + "
            // haga cierta accion cuando los dos parametros
            // sean de la clase Complex y devuelve Complex
            return new Complex
            {
                Real = c1.Real + c2.Real,
                Imaginary = c1.Imaginary + c2.Imaginary
            };
        }

        public override string ToString() {
            return $"{Real} + {Imaginary}i";
        }
      }
    }
