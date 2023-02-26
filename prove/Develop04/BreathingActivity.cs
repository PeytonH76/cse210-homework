using System;
 
public class BreathingActivity: Activity{

    private string _description;
    public BreathingActivity(string description, string activityName, string startmes, string endmes) : base(activityName, startmes, endmes){
        _description = description;
    }


    public void GetExercise(){
        
    }
    public void Display(){
        string startMes = GetStartMes();
        string endMes = GetEndMes();

        Console.WriteLine(startMes);
        Console.WriteLine();
        Console.WriteLine(_activityName);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration + 2);

        bool isTimeGoing = true; // start with breath in message
        bool hasDisplayedMessage = false; // keep track of whether message has been displayed
        while (DateTime.Now < futureTime)
        {
            TimeSpan timeLeft = futureTime - DateTime.Now;
            int secondsLeft = timeLeft.Seconds + 1;

            if (!hasDisplayedMessage) {
                if (isTimeGoing){
                    Console.WriteLine("Breath in...");
                }
                else{
                    Console.WriteLine("Breath out...");
                }
                hasDisplayedMessage = true;
            }

            if (secondsLeft > 2){
                Console.WriteLine($"Time remaining: {secondsLeft - 2} seconds");
                Thread.Sleep(2000); // wait for 2 seconds
                hasDisplayedMessage = false; // reset flag to display message again
            }

            isTimeGoing = !isTimeGoing; // alternate between breath in and breath out

            Thread.Sleep(1000);
        }
    
        Console.WriteLine("Time is up!");
        Console.WriteLine();
        Console.WriteLine(endMes);
    }
}