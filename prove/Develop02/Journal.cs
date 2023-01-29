using System;
using System.IO;

public class Journal
{
    List<Entry> entries = new List<Entry>();
    public void AddEntry()
    {
        Prompt randPrompt = new Prompt();
        string prompt = randPrompt.GetPrompts();
        Console.Write(prompt);
        string userEntry = Console.ReadLine();

        // Gets the current date
        DateTime _theCurrentTime = DateTime.Now;
        string dateText = _theCurrentTime.ToShortDateString();

        Console.WriteLine("Heres a free write area if you want: ");
        string freeWrite = Console.ReadLine();

        Entry newEntry = new Entry();
        newEntry.date = dateText;
        newEntry.text = userEntry;
        newEntry.prompt = prompt;
        newEntry.freeWrite = freeWrite;
        if(!entries.Any(e => e.text == newEntry.text && e.prompt == newEntry.prompt && e.date == newEntry.date && e.freeWrite == newEntry.freeWrite))
        {
            entries.Add(newEntry);
        }
    }
    public void Load()
    {
        Console.WriteLine("What file did you want to load? ");
        string fileName = Console.ReadLine();

        Console.WriteLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        List<Entry> newEntries = new List<Entry>();

        foreach (string line in lines)
        {
            string[] parts = line.Split(", ");
            string date = parts[0];
            string[] secondPart = parts[1].Split(" ");
            string prompt = secondPart[0];
            string text = secondPart[1];
            string freeWrite = secondPart[2];

            Entry newEntry = new Entry();
            newEntry.date = date;
            newEntry.prompt = prompt;
            newEntry.text = text;
            newEntry.freeWrite = freeWrite;
            entries.Add(newEntry);
        }
        entries.Clear();
        entries = newEntries;

    }

    public void Save()
    {
        Console.WriteLine("What did you want to call the file? ");
        string fileName = Console.ReadLine();

        Console.WriteLine();

        if (File.Exists(fileName))
        {
            // Read the existing file into a list of strings
            List<string> lines = File.ReadAllLines(fileName).ToList();

            // Add the new entries to the list
            foreach (Entry entry in entries)
            {
                lines.Add(entry.date + ", " + entry.prompt + " " + entry.text + ", " + entry.freeWrite);
            }

            // Write the updated list back to the file
            File.WriteAllLines(fileName, lines);
        }

        else 
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in entries)
                {
                    outputFile.WriteLine(entry.date + ", " + entry.prompt + " " + entry.text + ", " + entry.freeWrite);
                }

            }
        }
        entries = new List<Entry>();


    }


    public void Display()
    {
        Console.WriteLine("What file did you want to display? ");
        string fileName = Console.ReadLine();

        Console.WriteLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }


}