using System.Collections.Generic;

public class Prompt
{
    List<string> prompts = new List<string>();

    public string GetPrompts()
    {
        prompts.Add("What did you do today? ");
        prompts.Add("What did you eat? ");
        prompts.Add("What was your favorite part of the day? ");
        prompts.Add("Did you have a good day? ");
        prompts.Add("Do you regret anything today? ");
        prompts.Add("Have you seen the Lord's hand in your life today? ");
        prompts.Add("Have you taken time to think about the many blessings you've been given today? ");
        Random p = new Random();
        int prompt = p.Next(prompts.Count);
        string randPrompt = prompts[prompt];
        return randPrompt;
    }

}