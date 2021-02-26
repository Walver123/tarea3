using System;

namespace num_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int i;
            int cont = 0;

            while (num <= 1000)
            {
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont == 2)
                {
                    Console.WriteLine("es primo");
                }

                else
                {
                    Console.WriteLine("no es primo" );
                }

            }
        }
    }
}
