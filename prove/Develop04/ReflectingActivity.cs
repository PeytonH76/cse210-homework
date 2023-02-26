using System;

public class ReflectingActivity: Activity{

    private string _description;
    private List<string> prompts = new List<string>();
    private List<string> questions = new List<string>();
    public ReflectingActivity(string description, string activityName, string startMes, string endMes) : base(activityName, startMes, endMes){
        _description = description;
    }

    public string GetQuestion(){
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        Random q = new Random();
        int question = q.Next(questions.Count);
        string randQuestion = questions[question];
        return randQuestion;
    }

    public string GetPrompts(){
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you when you did something truly selfless.");
        Random p = new Random();
        int prompt = p.Next(prompts.Count);
        string randPrompt = prompts[prompt];
        return randPrompt;
    }

    public void GetDisplay(){
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
        DateTime futureTime = startTime.AddSeconds(duration);
        
        DateTime animationStartTime = DateTime.Now;

        while (DateTime.Now < futureTime){
            TimeSpan timeLeft = futureTime - DateTime.Now;
            int secondsLeft = timeLeft.Seconds + 1;

            string prompt = GetPrompts();
            string question = GetQuestion();

            Console.WriteLine();
            Console.WriteLine(prompt);
            Thread.Sleep(6000);
            Console.WriteLine();

            Console.WriteLine(question);
            animationStartTime = DateTime.Now; // Update animation start time
            while (DateTime.Now < animationStartTime.AddSeconds(8)){ // Run the animation for 6 seconds
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Console.Write("-"); // Replace it with the - character
            }
            Console.WriteLine();

            Thread.Sleep(1000);
        }
    
        Console.WriteLine("Time is up!");
        Console.WriteLine();
        Console.WriteLine(endMes);
    }
}