using System;

public abstract class Goal{

    protected int _recordEvent;
    protected int _points;
    protected string _description;
    protected string _name;
    protected bool _isComplete = false;
    protected bool _isLoaded = false;
    protected static List<string> goals = new List<string>();
    private static int _totalPointsEarned = 0;
    public Goal(int recordEvent, int points, string description, string name, List<string> goals){
        _recordEvent = recordEvent;
        _name = name;
        _description = description;
        _points = points;
        _totalPointsEarned = 0;
    }

    public (string _name, string _description, int _points) SetPropertiesFromInput(){
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());

        return (_name, _description, _points);
    }

    public void DisplayList(){
        if (!_isLoaded){
            int counter = 1;
            foreach (var goal in goals) {
                Console.WriteLine("{0}. {1}", counter, goal);
                counter++;
            }
        }
        else{
            Console.WriteLine("Enter the file name to load: ");
            string fileName = Console.ReadLine();

            List<string> loadedGoals = new List<string>();
            using (StreamReader reader = new StreamReader(fileName)){
                string line;
                while ((line = reader.ReadLine()) != null){
                    loadedGoals.Add(line);
                }
            }

            Console.WriteLine();
    
            foreach (string goal in loadedGoals){
                Console.WriteLine(goal);
            }
        }
    }
    public void SaveList(){
        LoadSave fileManager = new LoadSave();
        fileManager.Save(goals);
    }

    public void LoadList(){
        LoadSave fileManager = new LoadSave();
        fileManager.Load();
        _isLoaded =  true;
    
        // Save the loaded goals to a separate list
        List<string> loadedGoals = fileManager.LoadedGoals;
    
        // Add the loaded goals to the existing goals list
        goals.AddRange(loadedGoals);
    }

    public void IsComplete() {
        if (!_isLoaded){
            Console.Write("Which goal did you complete? (enter the number) ");
            int completedGoalIndex = int.Parse(Console.ReadLine()) - 1;
            goals[completedGoalIndex] = $"✓ {goals[completedGoalIndex]}";
        int completedGoalPoints = _points; // add points to the total
        Console.WriteLine($"Congratulations! You have been awarded {completedGoalPoints} points.");            
        _isComplete = true;
        }
        else{
            LoadSave fileManager = new LoadSave();
            List<string> loadedGoals = fileManager.LoadedGoals;
            
        }
    }

    public int GetTotalPoints(){
        if (_isComplete) { // check if the goal is complete
            int completedGoalPoints = _points;
            Console.Write("Total Points:");
            return _totalPointsEarned += completedGoalPoints;
        }
        else{
            Console.Write("Total Points");
            return 0;
        }
    }

    public abstract void GetQuestions();
}