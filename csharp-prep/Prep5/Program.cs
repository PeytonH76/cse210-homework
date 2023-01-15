using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine("");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the prgram");
    }

    static string PromptUserName()
    {
       Console.Write("Enter your name: ");
       string user = Console.ReadLine();
       return user;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string user, int square)
    {
        Console.WriteLine($"{user}, the square of your number is {square}");
    }
}