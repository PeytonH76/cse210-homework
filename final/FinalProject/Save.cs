using System;

public class Save{

    public Save(){
        
    }

    public void GetSave(List<Game> games, List<Game> apex, List<Game> modern, List<Game> ghost){
        Console.WriteLine("Do you want to save? (yes/no)");
        string choice = Console.ReadLine();

        Console.WriteLine();

        if (choice == "yes"){
            Console.WriteLine("What did you want to call the file? (No need to add .txt to the end) ");
            string fileName = Console.ReadLine();
            // Concatenate ".txt" to the end of the file name
            fileName += ".txt";
            using (StreamWriter writer = new StreamWriter(fileName, true)){ // opens the file in append mode
                writer.WriteLine("All games:");
                foreach (var game in games){
                    writer.WriteLine(game.GetData());
                }
                writer.WriteLine();

                writer.WriteLine("Apex Legends Randoms:");
                foreach (var a in apex){
                    writer.WriteLine(a.GetData());
                }

                writer.WriteLine();

                writer.WriteLine("Modern Warfare 2 Randoms:");
                foreach (var m in modern){
                    writer.WriteLine(m.GetData());
                }

                writer.WriteLine();

                writer.WriteLine("Call of Duty Ghost Extinction Randoms:");
                foreach (var g in ghost){
                    writer.WriteLine(g.GetData());
                }


            }
        }
        else{

        }
    }
}