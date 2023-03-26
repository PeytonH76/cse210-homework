using System;
using System.IO;

public class SimpleGoal: Goal{

    public SimpleGoal(int recordEvent, int points, string description, string name) :
    base(recordEvent, points, description, name){
    }

    public override void Display(){
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public override void Record(){
        _isComplete = true;
    }

    public override string SaveData(){
        var complete = "false";
        if (_isComplete == true){
            complete = "true";
        }
        return $"simple; {complete}";
    }

}