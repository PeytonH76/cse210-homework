using System;

class Program
{
    static void Main(string[] args)
    {

        bool choices = true;

        while (choices == true){
        
            Console.WriteLine();

            AnimateText("1. Start breathing exercise");
            AnimateText("2. Start reflecting exercise");
            AnimateText("3. Start listing activity");
            AnimateText("4. Quit");

            Console.WriteLine();

            AnimateText("Choose an option: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1"){
                string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                string activityName = "Breathing Activity";
                BreathingActivity breath = new BreathingActivity(description, activityName, "", "");
                breath.Display();
            }
            else if (choice == "2"){
                string description = "This activity will help you relfect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you c an use it in other aspects of your life.";
                string activityName = "Reflecting Activity";
                ReflectingActivity reflect = new ReflectingActivity(description, activityName, "", "");
                reflect.GetDisplay();
            }
            else if (choice == "3"){
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                string activityName = "Listing Activity";
                ListingActivity list = new ListingActivity(description, activityName, "", "");
                list.GetDisplay();
            }
            else if (choice == "4"){
                choices = false;
                AnimateText("Thank you!");
            }
        }
    }

    // I added this animation for the text that have this method. 
    static void AnimateText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(50); // Adjust this value to control the animation speed
            }
            Console.WriteLine();
        }

}