using System;

class Program
{
    static void Main(string[] args)
    {
        int percent;
        string answer, letter, studentSuccess;

        Console.Write("What is your grade percentage? ");
        answer = Console.ReadLine();
        percent = int.Parse(answer);

        if (percent >= 90)
        {
            letter = "A";
            studentSuccess = "You Passed!";
        }
        else if (percent >= 80)
        {
            letter = "B";
            studentSuccess = "You Passed!";
        }
        else if (percent >= 70)
        {
            letter = "C";
            studentSuccess = "You Passed!";
        }
        else if (percent >= 60)
        {
            letter = "D";
            studentSuccess = "Better luck next time!";
        }
        else
        {
            letter = "F";
            studentSuccess = "Better luck next time!";
        }

        Console.WriteLine($"Your grade is: {letter}");
        Console.WriteLine($"{studentSuccess}");

        
    }
}