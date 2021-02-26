using System;

namespace edad_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int ed1, ed2, ed3;
            Console.WriteLine("ingrese primera edad");
            ed1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segunda edad");
            ed2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tercera edad");
            ed3 = int.Parse(Console.ReadLine());

            if (ed1 > ed2)
            {
                if (ed1 > ed3)
                {

                    Console.WriteLine("primera edad es mayor: " + ed1);
                }
            }

            else
            {
                if (ed2 > ed3)
                {
                    Console.WriteLine("segunda edad es mayor: " + ed2);
                }


                else
                {
                    Console.WriteLine("tercera edad es mayor: " + ed3);
                }
            }
       
        }
    }
}
