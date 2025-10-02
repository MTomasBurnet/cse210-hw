using System;

class Program
{
    static void Main(string[] args)
    {
        Assignament assignament = new Assignament("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignament.GetSummary());

        Console.WriteLine("");

        MathAssignament mathAssignament = new MathAssignament("Roberto Rodriguez", "Frictions", "7.3", "8-19");
        Console.WriteLine($"{mathAssignament.GetSummary()} \n{mathAssignament.GetHomeWorkList()}");

        Console.WriteLine("");

        WritingAssignaments writingAssignaments = new WritingAssignaments("Mary Waters", "European History", "The Cause of World War II by Mary Waters");
        Console.WriteLine($"{writingAssignaments.GetSummary()} \n{writingAssignaments.GetWritingInformation()}");
    }
}