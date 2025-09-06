using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num, sum = 0, quantity = 0, largest;
        double average;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {

            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
                sum = sum + num;
                quantity += 1;
            }


        } while (num != 0);

        average = (float) sum / quantity;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is :{average.ToString("R")}");

        largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

    }
}