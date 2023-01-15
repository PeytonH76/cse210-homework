using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;
        int counter = 0;

        /* Another option:
        
        bool keepPlaying = true;
        while(keepPlaying) {
            int userGuess = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine(userGuess);
            Console.WriteLine(magicNumber);
        
            if (magicNumber == userGuess) {
              Console.WriteLine("You Got it");
              keepPlaying = false;
            }
        }
        */

        while (guess != magicNumber)
        {       
                Console.Write("What is your number? ");
                guess = int.Parse(Console.ReadLine());

                counter = counter + 1;
                if (guess > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You got it!");
                    Console.WriteLine("");
                    Console.WriteLine($"You got this in {counter} tries!");
                }


            }
    }
}

