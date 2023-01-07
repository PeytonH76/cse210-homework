using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine();

        Console.Write("What is your grade percentage? ");
        string percentageFromUser = Console.ReadLine();
        int userNumber = int.Parse(percentageFromUser);
        string letter = userNumber.ToString();

        Console.WriteLine();

        if (userNumber >= 90) 
        {
            letter = "A";
        }
        else if (userNumber < 90 && userNumber >= 80) 
        {
            letter = "B";
        }
        else if (userNumber < 80 && userNumber >= 70) 
        {
            letter = "C";
        }
        else if (userNumber < 70 && userNumber >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine();


        int lastDigit = userNumber%10;
        string sign = lastDigit.ToString();

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        string a = userNumber.ToString();

        if (letter == "A")
        {
            a = "an";
        }
        else 
        {
            a = "a";
        }

        Console.WriteLine();

        Console.WriteLine($"You got {a} {letter}{sign}! ");

        if (userNumber >= 70)
        {
            Console.WriteLine("You passed the class! ");
        }
        else
        {
            Console.WriteLine("You failed the class! ");
        }
    }
}