using System;

public class Load{

    public Load(){

    }

    public void GetLoad(){
        string directoryPath = "/Users/peytonhaws/Documents/Programming with Classes/cse210-homework/final/FinalProject";
        string filePattern = "*.txt";

        // Get all the file names in the directory that match the pattern
        string[] fileNames = Directory.GetFiles(directoryPath, filePattern);

        // Print each file name (without the directory path) to the console
        for (int i = 0; i < fileNames.Length; i++)
        {
            string fileName = Path.GetFileName(fileNames[i]);
            Console.WriteLine($"{i + 1}: {fileName}");
        }

        // Ask the user to choose a file
        int choice = 0;
        while (choice < 1 || choice > fileNames.Length)
        {
            Console.Write($"Choose a file (1 - {fileNames.Length}): ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }
            if (choice < 1 || choice > fileNames.Length)
            {
                Console.WriteLine($"Invalid input. Please enter a number between 1 and {fileNames.Length}.");
            }
        }

        // Load the chosen file
        string chosenFileName = fileNames[choice - 1];
        string[] lines = File.ReadAllLines(chosenFileName);

        // Print the lines to the console
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}