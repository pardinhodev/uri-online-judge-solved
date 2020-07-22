using System;

namespace uri1006
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, media;

            a = Convert.ToSingle(Console.ReadLine());
            b = Convert.ToSingle(Console.ReadLine());
            c = Convert.ToSingle(Console.ReadLine());
            media = (c * 5 + (b * 3 + (a * 2))) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1"));
        }
    }
}
