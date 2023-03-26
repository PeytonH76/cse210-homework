using System;

public class EternalGoal: Goal{
    
    public EternalGoal(int recordEvent, int points, string description, string name) :
    base(recordEvent, points, description, name){

    }

    public override void Display(){
        Console.WriteLine("");
    }

    public override void Record(){
        _isComplete = false;
    }

    public override string SaveData(){
        return "";
    }
    
}