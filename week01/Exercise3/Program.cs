using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int number = -1;

        while (number != magicNumber)
        {
            Console.Write("What is your guess? ");
            number = int.Parse(Console.ReadLine());

            if (magicNumber > number)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < number)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.Write("You guessed it right!");
            }

        }
    }
}