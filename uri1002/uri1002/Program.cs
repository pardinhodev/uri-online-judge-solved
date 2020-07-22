using System;

namespace uri1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, r, a;

            n = 3.14159;
            r = Convert.ToDouble(Console.ReadLine());
            a = n * Math.Pow(r, 2);

            Console.WriteLine("A=" + a.ToString("F4"));
        }
    }
}
