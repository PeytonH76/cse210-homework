using System;

public class ListingActivity: Activity{

    private string _description;
    private List<string> prompts = new List<string>();

    public ListingActivity(string description, string activityName, string startMes, string endMes) : base(activityName, startMes, endMes){
        _description = description;
    }

    public string GetPrompts(){
        prompts.Add("Who are people that you appreciate? ");
        prompts.Add("What are personal strengths of yours? ");
        prompts.Add("Who are people that you have helped this week? ");
        prompts.Add("When have you felt the Holy Ghost this month? ");
        prompts.Add("Who are some of your personal heroes? ");
        Random p = new Random();
        int prompt = p.Next(prompts.Count);
        string randPrompt = prompts[prompt];
        return randPrompt;
    }

    public void GetDisplay(){
        string startMes = GetStartMes();
        string endMes = GetEndMes();
        string prompt = GetPrompts();

        Console.WriteLine(startMes);
        Console.WriteLine();
        Console.WriteLine(_activityName);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        int duration = GetDuration();
        int workDuration = duration + 8;

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(workDuration);
        List<string> inputs = new List<string>();

        do{

            TimeSpan timeLeft = futureTime - DateTime.Now;
            int secondsLeft = timeLeft.Seconds + 8;

            Console.WriteLine(prompt);

            Console.WriteLine();

            if (secondsLeft > 8){
                while (secondsLeft > workDuration) {
                    Console.WriteLine($"Time till start: {secondsLeft - workDuration} seconds");
                    Thread.Sleep(1000); // wait for 1 second
                    secondsLeft--;
                }   
            }

            Console.WriteLine();
            Console.WriteLine("Start listing items:");


            while(DateTime.Now <= futureTime){
                string input = Console.ReadLine();
                inputs.Add(input);
            }  
        }
        while (DateTime.Now <= futureTime);
    
        Console.WriteLine();
        Console.WriteLine("Time is up!");
        Console.WriteLine();

        int count = 0;
        Console.WriteLine("Here are the items you listed: ");
        foreach (string input in inputs){
            count += 1;
            Console.WriteLine("- " + input);
        }
        Console.WriteLine();
        Console.WriteLine("Here's your number of entries:");
        Console.WriteLine(count);

        Console.WriteLine();
        Console.WriteLine(endMes);
    }
}