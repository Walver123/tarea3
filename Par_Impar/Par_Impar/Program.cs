using System;

namespace Par_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,r;
            Console.WriteLine("Ingrese un numero");
            a = Double.Parse(Console.ReadLine());
            r = a % 2;
            if(r==0)
            { Console.WriteLine("El numero es par"); }
            else
            { Console.WriteLine("El numero es impar"); }
            
        }
    }
}
