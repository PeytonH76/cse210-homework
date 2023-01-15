using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("");

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        // Creates a list
        List<int> numbers = new List<int>();

        // Adds the numbers inputted by the user to a list 
        int userNumber = -1;
        while (userNumber != 0)
        {

            Console.Write("Enter a number: ");

            Console.Write("");

            string userNumbersStr = Console.ReadLine() ?? "";
            userNumber = int.Parse(userNumbersStr);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Adds the numbers of a list togethor 
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
               
            }

        // Finds the average of the list
        float average = ((float)sum) / numbers.Count;

        // Finds the max number 
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // This is to display the negative numbers of a list.

        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    if (numbers[i] < 0)
        //    {
        //        int negatives = numbers[i];
        //    }
        //}

        // Finds the minimum positive number 
        int minPositiveNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number < minPositiveNumber && number > 0)
            {
                minPositiveNumber = number;
            }
        }

        Console.WriteLine($"Your sum is {sum}.");
        Console.WriteLine($"Your average is {average}.");
        Console.WriteLine($"Your max number is {max}.");
        Console.WriteLine($"Your smallest positive number is {minPositiveNumber}.");
        Console.WriteLine("Your sorted list is:");

        // Sorts the list of numbers 
        numbers.Sort();
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }


    }
}