using System;

namespace elevacion
{
    class Program
    {
        static int potenciaRecursiva(int b, int exponente)
        {
            if (exponente == 0)
                return 1;
            else
                return b * potenciaRecursiva(b, exponente - 1);
        }
        static void Main(string[] args)
        {
            int b, exponente;
            Console.WriteLine("Favor ingrese la base: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Favor ingrese el exponente: ");
            exponente = int.Parse(Console.ReadLine());

            Console.WriteLine("La potencia entre los dos numeros es de: " + potenciaRecursiva(b, exponente));
            Console.ReadKey();
        }
    }
}
