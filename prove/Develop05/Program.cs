using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> goals = new List<string>();
        SimpleGoal simple = new SimpleGoal(0, 0, "", "", goals);
        EternalGoal eternal = new EternalGoal(0, 0, "", "", goals);
        ChecklistGoal check = new ChecklistGoal(0, 0, "", "", goals);
        LoadSave save = new LoadSave();
        

        bool stop = true;
        while (stop){

            Console.WriteLine();

            int points1 = simple.GetTotalPoints();
            int points2 = eternal.GetTotalPoints();
            int points3 = check.GetTotalPoints();

            Console.WriteLine();

            Console.WriteLine("Welcome to the Quest!");
            Console.WriteLine();
            Console.WriteLine("Please, choose an option:");

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");


            Console.WriteLine(" ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1" || choice == "one"){
                Console.WriteLine("Choose a goal?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                Console.WriteLine(" ");
                string goal = Console.ReadLine();
                Console.WriteLine();

                if (goal == "1"){
                    simple.GetQuestions();
                }
                else if (goal == "2"){
                    eternal.GetQuestions();
                }
                else if (goal == "3"){
                    check.GetQuestions();
                }
                
            }
            else if (choice == "2" || choice == "two"){
               simple.DisplayList();
            }
            else if (choice == "3" || choice == "three"){
                simple.SaveList();
            }
            else if (choice == "4" || choice == "four"){
                simple.LoadList(); 
            }
            else if (choice == "5" || choice == "five"){
                simple.DisplayList();
                simple.IsComplete();
            }
            else if (choice == "6" || choice == "six"){
                Console.WriteLine("");
                stop = false;
            }
        }
    }
}