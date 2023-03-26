using System;

public abstract class Goal{

    protected int _recordEvent;
    protected int _points;
    protected string _description;
    protected string _name;
    protected bool _isComplete = false;
    protected static List<Goal> goals = new List<Goal>();
    private static int _totalPointsEarned = 0;
    public Goal(int recordEvent, int points, string description, string name){
        _recordEvent = recordEvent;
        _name = name;
        _description = description;
        _points = points;
        _totalPointsEarned = 0;
    }

    //public int GetTotalPoints(){
    //    if (_isComplete) { // check if the goal is complete
    //        int completedGoalPoints = _points;
    //        Console.Write("Total Points:");
    //        return _totalPointsEarned += completedGoalPoints;
    //    }
    //    else{
    //        Console.Write("Total Points");
    //        return 0;
    //    }
    //}
    public abstract void Display();
    public abstract void Record();
    public abstract string SaveData();
}