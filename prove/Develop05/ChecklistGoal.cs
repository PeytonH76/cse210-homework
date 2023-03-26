using System;

public class ChecklistGoal: Goal{

    private int _howManyTimes;
    private int _howManyTimesCompleted = 0;
    
    public ChecklistGoal(int recordEvent, int points, string description, string name, int _howManyTimes, int _howManyTimesCompleted) : 
    base(recordEvent, points, description, name){

    }

    public override void Display(){

    }

    public override void Record(){
        _howManyTimesCompleted ++;
        if (_howManyTimes == _howManyTimesCompleted){
            _isComplete = true; 
        }
    }

    public override string SaveData()
    {
        throw new NotImplementedException();
    }

}