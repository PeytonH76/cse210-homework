using System;

public class EternalGoal: Goal{
    
    public EternalGoal(int recordEvent, int points, string description, string name, List<string> goals) :
    base(recordEvent, points, description, name, goals){

    }

    public override void GetQuestions(){
        SetPropertiesFromInput();
        goals.Add($"Eternal Goal: {_name} ({_description})");
    }
    
}