using System;

public class Entry
{
    public string date;
    public string prompt;
    public string text; 
    public string freeWrite;
    public bool saved = false;
    public void Display()
    {
        Console.WriteLine(date);
        Console.WriteLine(prompt);
        Console.WriteLine(text);
        Console.WriteLine(freeWrite);
        
    }
}