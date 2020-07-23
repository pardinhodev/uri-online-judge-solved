using System;
using System.Globalization;

namespace uri1043
{
    class Program
    {
        static void Main(string[] args)
        {

            float a, b, c, perimeter, area;

            String[] vet = Console.ReadLine().Split(' ');

            a = float.Parse(vet[0], CultureInfo.InvariantCulture);
            b = float.Parse(vet[1], CultureInfo.InvariantCulture);
            c = float.Parse(vet[2], CultureInfo.InvariantCulture);

            if (a < b + c && b < a + c && c < a + b)
            {
                perimeter = a + b + c;
                Console.WriteLine("Perimetro = " + perimeter.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = 0.5f * (a + b) * c;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
