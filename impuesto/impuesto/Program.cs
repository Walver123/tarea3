using System;

namespace impuesto
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod,med;
            float pre,r;
            Console.WriteLine("El producto es medicina (si, no)");
            med = Console.ReadLine();
            if (med == "si")
            {
                Console.WriteLine("usted no debe pagar impuesto");
            }
            else
            {
                Console.WriteLine("Ingrese nombre del producto");
                prod = Console.ReadLine();
                Console.WriteLine("Ingrese Precio del Producto");
                pre = float.Parse(Console.ReadLine());
                r = (float)( pre * 0.12);
                Console.WriteLine("Nombre del Producto: " + prod);
                Console.WriteLine("impuesto: " + r);
            }
        }
    }
}
