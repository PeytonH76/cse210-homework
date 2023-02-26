using System;

public class Activity{
    protected string _activityName;
    protected string _startmes;
    protected string _endmes;

    public Activity(string activityName, string startmes, string endmes){
        _activityName = activityName;
        _startmes = startmes;
        _endmes = endmes;
    }

    public string GetActivityName(){
        return _activityName;
    }
    public string GetStartMes(){
        _startmes = "Welcome to relaxation!";
        return _startmes;
    }

    public string GetEndMes(){
        _endmes = "Hope you feel relaxed!";
        return _endmes;
    }
    public int GetDuration(){
        Console.WriteLine("What do you want the duration to be? (In Seconds) ");
        string _dur = Console.ReadLine();
        int _duration = int.Parse(_dur);
        return _duration;
    }
}