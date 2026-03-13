using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Text;

namespace Primer_Programa_Consola
{
    public class castings
    {
        public void TiposCasting()
        {
            // conversión explicita
        int entero = 10;
         double num_decimal = (double)entero;

            // conversion parse
            string texto= "10";
            int texto_a_entero = int.Parse(texto);
            // try parse

            // conversion estatica
            double numero_decimal = 10.5;
            int decial_a_entero = Convert.ToInt32(numero_decimal);

        }
        // variable de la clase
        public int Valor { get; }

        public castings(int valor) // cosntructor que recibe un parametro 
        {
            Valor = valor;
        }
        // Acceso | Estático | metodo (implicit) | Palabra clave | que devuelve | (clase a convertir)
        public static implicit operator int (castings clase)
        {
            return (int)clase.Valor;
        }

        // Acceso | Estático | metodo (explicit) | Palabra clave | que devuelve | (parametro a convertir)
        public static implicit operator castings(int valor)
        {
            return new castings(valor);
        }
    }

    public class Point // clase punto
    {
        public int X;
        public int Y;
        public Point(int x , int y)
        {
            X = x;
            Y = y;
        }

        // escribimos una funcion para el operador de +
        public static Point operator + (Point p1, Point p2)
        {

            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

    }
}
