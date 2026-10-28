using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int numberList = -1;

        while (numberList != 0)
        {
            Console.Write("Enter a number: ");

            string numberAdd = Console.ReadLine();
            numberList = int.Parse(numberAdd);

            if (numberList != 0)
            {
                numbers.Add(numberList);
            }
        }

        int numberSum = 0;
        foreach (int number in numbers)
        {
            numberSum += number;
        }
        Console.WriteLine($"The sum is: {numberSum}");

        float average = ((float)numberSum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The max is: {maxNumber}");
    }
}