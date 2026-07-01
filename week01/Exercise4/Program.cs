using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int entry = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (entry != 0)
        {
            Console.Write("Enter number: ");
            entry = int.Parse(Console.ReadLine());
            if (entry != 0)
            {
                numbers.Add(entry);
            }
        }
        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        numbers.Sort();
        Console.WriteLine("The sorted list is as follows:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}