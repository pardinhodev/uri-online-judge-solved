using System;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, h;
            double s, r;

            n = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            s = double.Parse(Console.ReadLine());
            r = h * s;

            Console.WriteLine("NUMBER = " + n);
            Console.WriteLine("SALARY = U$ " + r.ToString("F2"));
        }
    }
}
