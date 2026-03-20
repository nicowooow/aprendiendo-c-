namespace Programa_simple___if_de_notas_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cuantas notas desea ingresar => ");
            int cantidad_notas = Convert.ToInt32(Console.ReadLine());
            int aprobados = 0;
            int desaprobados = 0;
            int[] notas = new int[cantidad_notas];
            for (int i = 0; i < cantidad_notas; i++)
            {
                Console.Write("ingrese la nota del alumno entre el 0 a 100: ");
                int nota = Convert.ToInt32(Console.ReadLine());
                notas[i] = nota;
                if (nota >= 70)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
                Console.WriteLine();
            }

            Console.WriteLine($"han aprobado {aprobados} y an desaprobado {desaprobados}");
            Console.WriteLine("las notas son : ");
            foreach (var nota in notas)
            {
                Console.Write(nota + " |");
            }
        }
    }
}
