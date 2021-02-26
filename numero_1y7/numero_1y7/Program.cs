using System;

namespace numero_1y7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero del 1 al 7");
            n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.Write("Hoy es LUNES");
            }

            if (n == 2)
            {
                Console.Write("Hoy es MARTES");
            }
            if (n == 3)
            {
                Console.Write("Hoy es MIERCOLES");
            }

            if (n == 4)
            {
                Console.Write("Hoy es JUEVES");
            }
            if (n == 5)
            {
                Console.Write("Hoy es VIERNES");
            }

            if (n == 6)
            {
                Console.Write("Hoy es SABADO");
            }
            if (n == 7)
            {
                Console.Write("Hoy es DOMINGO");
            }

   
        }
    }
}
