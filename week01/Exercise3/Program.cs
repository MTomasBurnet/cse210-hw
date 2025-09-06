using System;
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine(number);

        int guess;
        string sguess;

        do
        {

            Console.Write("What is the magic number? ");
            sguess = Console.ReadLine();
            guess = int.Parse(sguess);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }


        } while (guess != number);

    }
}