using System;
using System.IO;

public class SimpleGoal: Goal{

    public SimpleGoal(int recordEvent, int points, string description, string name, List<string> goals) :
    base(recordEvent, points, description, name, goals){
    }

    public override void GetQuestions(){
        SetPropertiesFromInput();
        goals.Add($"Simple Goal: {_name} ({_description})");
    }

}