using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ClaseGenericaEjercicio
{
    internal class Lista<T>
    {
        private T[] ListaElementos;
        private int Cantidad = 0;

        public Lista(int capacidad = 100)
        {
            ListaElementos = new T[capacidad];
        }

        public void Add(T elemento)
        {
            ListaElementos[Cantidad] = elemento;
            Cantidad++;

            Console.WriteLine("se agrego el elemento " + elemento);
        }

        public void Remove(T elemento)
        {
            for (int i = 0; i < Cantidad; i++)
            {
                if (Equals(ListaElementos[i], elemento) || ListaElementos[i].Equals(elemento))
                {
                    for (int j = i; j < Cantidad - 1; j++) // hacemos que los elementos recorran una posicion atras
                    {
                        ListaElementos[j] = ListaElementos[j + 1];
                    }
                    Cantidad--;// Reducimos el tamaño del los elementos en el array
                    ListaElementos[Cantidad] = default(T); // lo ponemos en valor por defecto

                    Console.WriteLine("se elimino el elemento " + elemento);
                    Console.WriteLine();
                    return;
                }
            }
        }

        public bool Contains(T elemento)
        {
            bool contiene = false;
            for (int i = 0; i < ListaElementos.Length; i++)
            {
                if (Equals(ListaElementos[i], elemento)) contiene= true;
            }
            Console.WriteLine($"el array {(contiene?"si":"no")} contiene el elemento {elemento} ");
                    Console.WriteLine();
            return contiene;

        }

        public void MostrarElementos()
        {
            Console.WriteLine("--------lista de elementos----------");
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine(ListaElementos[i]);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine();

        }
        public int Count()
        {
            Console.WriteLine("cantidad de elementos es " + Cantidad);
                    Console.WriteLine();
            return Cantidad;
        }
    }
}
