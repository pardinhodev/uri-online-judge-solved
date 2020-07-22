using System;

namespace uri1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, r1, r2, rf;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            r1 = a * b;
            r2 = c * d;
            rf = r1 - r2;

            Console.WriteLine("DIFERENCA = " + rf);
        }
    }
}
