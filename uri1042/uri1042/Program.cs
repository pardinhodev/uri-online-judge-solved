using System;

namespace uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo, numberThree;
            string[] numbers = Console.ReadLine().Split(' ');

            numberOne = int.Parse(numbers[0]);
            numberTwo = int.Parse(numbers[1]);
            numberThree = int.Parse(numbers[2]);

            if (numberOne > numberTwo && numberOne > numberThree && numberTwo > numberThree)
            {
                Console.WriteLine(numberThree + "\n" + numberTwo + "\n" + numberOne);
            }
            else if (numberOne > numberTwo && numberOne > numberThree && numberThree > numberTwo)
            {
                Console.WriteLine(numberTwo + "\n" + numberThree + "\n" + numberOne);
            }
            else if (numberTwo > numberOne && numberTwo > numberThree && numberOne > numberThree)
            {
                Console.WriteLine(numberThree + "\n" + numberOne + "\n" + numberTwo);
            }
            else if (numberTwo > numberOne && numberTwo > numberThree && numberThree > numberOne)
            {
                Console.WriteLine(numberOne + "\n" + numberThree + "\n" + numberTwo);
            }
            else if (numberThree > numberOne && numberThree > numberTwo && numberOne > numberTwo)
            {
                Console.WriteLine(numberTwo + "\n" + numberOne + "\n" + numberThree);
            }
            else
            {
                Console.WriteLine(numberOne + "\n" + numberTwo + "\n" + numberThree);
            }

            Console.WriteLine("\n" + numberOne);
            Console.WriteLine(numberTwo);
            Console.WriteLine(numberThree);

        }
    }
}
