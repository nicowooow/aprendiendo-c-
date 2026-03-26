using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseGenericaEjercicio
{
    public class Persona
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

        // Constructor por defecto
        public Persona()
        {
            Nombre = string.Empty;
            Edad = 0;
            Ciudad = string.Empty;
        }

        // Constructor con parámetros
        public Persona(string nombre, string ciudad, int edad = 0)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        // Método para mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}");
        }

        public override string ToString()
        {
            return $"Persona: {Nombre}, Edad: {Edad}";
        }
    }
}
