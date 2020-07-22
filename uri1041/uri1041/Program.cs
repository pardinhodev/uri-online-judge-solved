using System;
using System.Globalization;

namespace uri1041
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            string[] coordinates = Console.ReadLine().Split(' ');
            x = float.Parse(coordinates[0], CultureInfo.InvariantCulture);
            y = float.Parse(coordinates[1], CultureInfo.InvariantCulture);

            if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x > 0.0 || x < 0.0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else
            {
                Console.WriteLine("Eixo Y");
            }
        }
    }
}
