using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices.");

        //Entry randPrompt = new Entry();
        //Console.WriteLine(randPrompt.CreateEntry());

        Journal journal = new Journal();

        bool choices = true;

        while (choices == true)
        {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");            
        Console.WriteLine("5. Quit");


        Console.WriteLine("");
        
        // Extra Credit
        // I added an option to right a free write area after the question
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine();
        Console.WriteLine("");

            if (choice == "1")    
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                journal.Load();
            }
            else if (choice == "4")
            {
                journal.Save();
            }
            else if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
            {
                Console.WriteLine();
                Console.WriteLine("Not an option. Please enter a valid number.");
            }
            else
            {
                choices = false;
                Console.WriteLine();
                Console.WriteLine("Thank you. Please return tomorrow. ");
            }
        }
    }
}