using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        LoadSave save = new LoadSave();
        

        bool stop = true;
        while (stop){

            Console.WriteLine();

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
                    var input = GetPropertiesFromInput();
                    SimpleGoal simple = new SimpleGoal(0, 0, input._name, input._description);
                    goals.Add(simple);
                }
                else if (goal == "2"){
                    var input = GetPropertiesFromInput();
                    EternalGoal eternal = new EternalGoal(0, 0, input._name, input._description);
                    goals.Add(eternal);
                }
                else if (goal == "3"){
                    var input = GetPropertiesFromInput();
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    int times = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());  
                    ChecklistGoal check = new ChecklistGoal(0, 0, input._name, input._description, times, bonus);
                    goals.Add(check);
                }
                
            }
            else if (choice == "2" || choice == "two"){
               foreach(Goal goal in goals){
                    goal.Display();
               }
            }
            else if (choice == "3" || choice == "three"){
                save.Save(goals);
            }
            else if (choice == "4" || choice == "four"){
                save.Load();
            }
            else if (choice == "5" || choice == "five"){
                Console.Write("Which goal did you complete? (enter the number) ");
                int completedGoalIndex = int.Parse(Console.ReadLine()) - 1;
                var goal = goals[completedGoalIndex];
                goal.Record();
            }
            else if (choice == "6" || choice == "six"){
                Console.WriteLine("");
                stop = false;
            }
        }
    }
    public static (string _name, string _description, int _points) GetPropertiesFromInput(){
        Console.Write("What is the name of your goal? ");
        var _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        var _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        var _points = int.Parse(Console.ReadLine());

        return (_name, _description, _points);
    }
}