using System;
using journal;
using entry;
using promptgenerator;
using System.IO;

class Program
{

    static Entry Write()
    {
        string answerd;
        Entry newEntry = new Entry();
        PromptGenerator promt = new PromptGenerator();

        newEntry.PutPrompt(promt.GetPrompt());
        answerd = Console.ReadLine();
        newEntry.PutInput(answerd);

        DateTime theCurrentTime = DateTime.Now;
        newEntry.PutDateAndTimer(theCurrentTime.ToShortDateString());

        return newEntry;
    }

    static void SaveFile(string filename, Journal journal)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entries in journal.GetList())
            {
                outputFile.WriteLine($"{entries.GetDateAndTimer()},{entries.GetPrompt()},{entries.GetImput()}");
            }
        }
    }

    static Journal LoadFile(string filename)
    {
        Journal journal = new Journal();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry entry = new Entry();

            string[] parts = line.Split(",");
            entry.PutDateAndTimer(parts[0].Trim());
            entry.PutPrompt(parts[1].Trim());
            entry.PutInput(parts[2].Trim());

            journal.Save(entry);

        }
        return journal;
    }

    static void Main()
    {
        Journal newJournal = new Journal();
        int num = 0;
        string filename;


        do
        {
            Console.WriteLine("Please select one of the following choise:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            Console.WriteLine("");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    newJournal.Save(Write());
                    break;
                case 2:
                    Console.WriteLine();
                    foreach (Entry entries in newJournal.GetList())
                    {
                        Console.WriteLine($"Date: {entries.GetDateAndTimer()} -Prompt: {entries.GetPrompt()}");
                        Console.WriteLine(entries.GetImput());
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("What is the file name?");
                    filename = Console.ReadLine();
                    newJournal = LoadFile(filename);
                    break;
                case 4:
                    Console.WriteLine("What is the file name?");
                    filename = Console.ReadLine();
                    SaveFile(filename, newJournal);
                    break;

            }
        } while (num != 5);

    }
}