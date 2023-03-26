using System.IO;
using System.Collections.Generic;

public class LoadSave{
    public List<string> LoadedGoals { get; private set; }
    public LoadSave(){
        LoadedGoals = new List<string>();
    }

    public void Save(List<Goal> goals){
        Console.WriteLine("What did you want to call the file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName, true)){
            foreach (var goal in goals) {
                writer.WriteLine(goal.SaveData());
            }
        }
    }


    public void Load(){
        Console.WriteLine("Enter the file name to load: ");
        string fileName = Console.ReadLine();

        List<string> loadedGoals = new List<string>();
        using (StreamReader reader = new StreamReader(fileName)){
            string line;
            while ((line = reader.ReadLine()) != null){
                loadedGoals.Add(line);
            }
        }

        Console.WriteLine("Loaded Goals:");
        foreach (string goal in loadedGoals){
            Console.WriteLine(goal);
        }
    }
}