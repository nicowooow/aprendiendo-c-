using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Programa_Consola
{
    internal class Tipos_de_variable
    {

        // FORMAS NUMERICAS
        uint ui = 100; // esta variable es un Z+, toma los valores de 0 a 4 mil millones 
        int i = 5; // toma los valores de -2 millones a 2 millones
        sbyte sby = 120; // toma los valores de -128 a 127
        decimal dec = 30.5M; // Dinero/Finanzas/Contabilidad, usan M o m como sufijo en un número real
        double dob = 30.5D; // Ciencia, Ingeniería, uso general, usan D o d como sufijo o por usar en un número real
        float f = 30.5F;// Gráficos 3D, Unity, ML, Arrays gigantes, usan F o f como sufijo o por usar en un número real
        long l = 5L; // puede tomar valores muy grandes (±9 trillones)
        ulong ul = 5UL; // toma valores absurdamente grandes
        byte b = 127; // de 0 a 255
        short s = 127; // de -32,768 a 32,767
        ushort us = 127; // de 	0 a 65,535

        // FORMAS DE ALFABETICAS
        string str = "este es un string"; // cadena de caracteres alfanumericos
        // el @ antes de las comillas permite hacer saltos de linea dentro del texto
        string s_salto_de_linea = @"este es un string
que permite hacer saltos de lineas";
        char c = 'c'; // solo permite un caracter

        // BOOLEAN
        bool boolean = false; // toma false o true

    }
}
