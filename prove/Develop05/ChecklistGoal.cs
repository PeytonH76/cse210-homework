using System;

public class ChecklistGoal: Goal{
    
    public ChecklistGoal(int recordEvent, int points, string description, string name, List<string> goals) : 
    base(recordEvent, points, description, name, goals){

    }

    public override void GetQuestions(){
        SetPropertiesFromInput();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        int times = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());
        goals.Add($"Check List Goal: {_name} ({_description}) -- Currently completed ");
    }

}