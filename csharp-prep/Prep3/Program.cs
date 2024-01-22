using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int correctNumber = randomGenerator.Next(1, 100);

        int guess = 10000;

        while (guess != correctNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > correctNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < correctNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Correct!!!");
            }
        }

    }
}