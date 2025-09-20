using System;
using scripture;
using reference;
using word;
using System.Diagnostics.Tracing;





class Program
{

    static int ReturnRandomNumber(string phrase)
    {
        Random number = new Random();
        List<string> quantityOfWords = phrase.Split(" ").ToList();


        return number.Next(0, quantityOfWords.Count);
    }

    static void SaveScriptures(List<Scripture> scriptureList)
    {
        using (StreamWriter outputFile = new StreamWriter("Scriptures.txt"))
        {
            foreach (Scripture sct in scriptureList)
            {
                outputFile.WriteLine($"{sct.GetReference().GetBook()};{sct.GetReference().GetChapter()};{sct.GetReference().GetVerse()};{sct.GetReference().GetEndVerse()};{sct.GetDisplayText()}");
            }
        }
    }

    static List<Scripture> LoadScriptures()
    {
        List<Scripture> newList = new List<Scripture>();
        string[] lines = System.IO.File.ReadAllLines("Scriptures.txt");
        foreach (string line in lines)
        {
            string book, text;
            int chapter, verse, endVerse;
            string[] parts = line.Split(";");
            book = parts[0];
            chapter = int.Parse(parts[1]);
            verse = int.Parse(parts[2]);
            endVerse = int.Parse(parts[3]);
            text = parts[4];
            Reference refe = new Reference(book, chapter, verse, endVerse);

            Scripture scr = new Scripture(refe, text);
            newList.Add(scr);

        }

        return newList;
    }

    static void RunProgram(Scripture newScripture)
    {
        string choise;

        string scripturephrase = newScripture.GetDisplayText();

        Console.Clear();
        do
        {

            Console.WriteLine($"{newScripture.GetReference().GetDisplayText()} {newScripture.GetDisplayText()}\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choise = Console.ReadLine();

            if (string.IsNullOrEmpty(choise))
            {
                int randomNumber = ReturnRandomNumber(scripturephrase);
                newScripture.HideRandomWords(randomNumber);
                Console.Clear();
            }

        } while (!newScripture.IsCompletyHidden() && choise != "quit");

        Console.WriteLine($"{newScripture.GetReference().GetDisplayText()} {newScripture.GetDisplayText()}");
    }


    static void Main(string[] args)
    {

        int choise;
        List<Scripture> listOfScriptures = new List<Scripture>();

        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scriptures memorizer Program");
            Console.WriteLine("What do you want to do?");

            Console.WriteLine("(1) Introduce an Scripture to memorized");
            Console.WriteLine("(2) Choise a Scripture to Memorized");
            Console.WriteLine("(3) Load Scriptures");
            Console.WriteLine("(4) Save the new scriptures");
            Console.WriteLine("(5) Quit");

            choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    {
                        Reference newReference;
                        Console.Clear();
                        Console.WriteLine("Name of the book");
                        String book = Console.ReadLine();
                        Console.WriteLine("Number of chapter");
                        int chapter = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many verse?");
                        int numberOfVerses = int.Parse(Console.ReadLine());
                        if (numberOfVerses != 1)
                        {
                            Console.WriteLine("Enter the number of the first verse");
                            int verse = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the number of the last verse");
                            int lastVerse = int.Parse(Console.ReadLine());
                            newReference = new Reference(book, chapter, verse, lastVerse);
                        }
                        else
                        {
                            Console.WriteLine("Enter the number of the verse");
                            int verse = int.Parse(Console.ReadLine());
                            newReference = new Reference(book, chapter, verse);
                        }
                        Console.WriteLine("Introduce the text of the verses");
                        string text = Console.ReadLine();

                        Scripture newScripture = new Scripture(newReference, text);
                        listOfScriptures.Add(newScripture);
                        break;
                    }
                case 2:
                    {
                        Console.Clear();
                        int ind = 1;
                        if (listOfScriptures.Count() > 0)
                        {
                            Console.WriteLine("Choise a Scripture: \n");
                            foreach (Scripture sct in listOfScriptures)
                            {
                                Console.WriteLine($"({ind}). {sct.GetReference().GetDisplayText()}");
                                ind += 1;
                            }
                            int choise2 = int.Parse(Console.ReadLine());
                            choise2 -= 1;

                            RunProgram(listOfScriptures[choise2]);
                        }
                        else
                        {
                            Console.WriteLine("First you need to upload scriptures to the program");
                        }
                        break;
                    }
                case 3:
                    {
                        List<Scripture> loadScripture = new List<Scripture>();
                        loadScripture = LoadScriptures();

                        foreach (Scripture s in loadScripture)
                        {
                            listOfScriptures.Add(s);
                        }

                        break;
                    }
                case 4:
                    {
                        SaveScriptures(listOfScriptures);
                        break;
                    }
            }

        } while (choise != 5);
        Console.WriteLine("\nThank You, have a good Day!");
 
    }

}
