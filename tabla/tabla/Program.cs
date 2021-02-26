using System;

namespace tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            float n, r;
            Console.WriteLine("ingrese un numero");
            n = float.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                r = (float) (n * i);
                Console.WriteLine($"tabla de {n} y {i} = " + r);
            }
            Console.ReadKey();
        }
    }
}
