using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string q;
            float b, a,r;
            Console.WriteLine("que desea calcular (triangulo, cuadrado, rectangulo)");
            q = Console.ReadLine();
            if(q== "triangulo")
            {
                Console.WriteLine("Ingrese base");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese altura");
                a = float.Parse(Console.ReadLine());
                r = (float)(b * a / 2);
                Console.WriteLine("Area es igual a: " + r);
            }

            if (q == "cuadrado")
            {
                Console.WriteLine("Ingrese base");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese altura");
                a = float.Parse(Console.ReadLine());
                r = (float)(b * a);
                Console.WriteLine("Area es igual a: " + r);
            }

            if (q == "rectangulo")
            {
                Console.WriteLine("Ingrese base");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese altura");
                a = float.Parse(Console.ReadLine());
                r =(float) (b * a);
                Console.WriteLine("Area es igual a: " + r);
            }
        }
    }
}
