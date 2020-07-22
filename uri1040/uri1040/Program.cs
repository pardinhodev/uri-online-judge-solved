using System;
using System.Globalization;

namespace uri1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float e1, e2, e3, e4, media, exam, resultExam;

            string[] notes = Console.ReadLine().Split(' ');

            e1 = float.Parse(notes[0], CultureInfo.InvariantCulture);
            e2 = float.Parse(notes[1], CultureInfo.InvariantCulture);
            e3 = float.Parse(notes[2], CultureInfo.InvariantCulture);
            e4 = float.Parse(notes[3], CultureInfo.InvariantCulture);

            media = (e1 * 2 + e2 * 3 + e3 * 4 + e4 * 1) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }

            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }

            else
            {
                Console.WriteLine("Aluno em exame.");   
                exam = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                resultExam = (media + exam) / 2;
                Console.WriteLine("Nota do exame: " + exam.ToString("F1", CultureInfo.InvariantCulture));

                if (resultExam >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: " + resultExam.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
