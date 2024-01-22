using System;

class Program
{
    static void Main(string[] args)
    {
        int numberToAdd = 100000;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numberToAdd != 0)
        {
            Console.Write("Enter number: ");
            numberToAdd = int.Parse(Console.ReadLine());
            if (numberToAdd != 0)
            {
                numbers.Add(numberToAdd);
            }

        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");



    }
}