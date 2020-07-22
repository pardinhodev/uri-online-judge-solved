using System;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, media;

            p1 = Convert.ToDouble(Console.ReadLine());
            p2 = Convert.ToDouble(Console.ReadLine());
            media = (p2 * 7.5 + (p1 * 3.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}
