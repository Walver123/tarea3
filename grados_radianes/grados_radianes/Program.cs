using System;

namespace grados_radianes
{
    class Program
    {
        static void Main(string[] args)
        {
            string p;
            Double n, r;
            Console.WriteLine("su cantidad es grados o radianes?");
            p = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad");
                n = Double.Parse(Console.ReadLine());
            if (p == "grados") 
            {
                r = ((Double)n * 0.0175);
                    Console.WriteLine("Cantidad en grados convertida a radianes: " + r);
            }

            else { 
                r = ((Double)n * 57.296);
                Console.WriteLine("Cantidad radianes conertida a grados: " + r);
            }
        }
    }
}
