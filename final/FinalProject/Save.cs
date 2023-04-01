using System;

public class Save{
    //private bool headerWritten1 = false;
    //private bool headerWritten2 = false;

    public Save(){
        
    }

    public void GetSave(string save, List<Game> games, List<Game> apex, List<Game> modern, List<Game> ghost){

        Console.WriteLine();

        if (save == "yes"){
            Console.WriteLine("What did you want to call the file? (No need to add .txt to the end) ");
            string fileName = Console.ReadLine();
            // Concatenate ".txt" to the end of the file name
            fileName += ".txt";

            // Check if the header has already been written
            //if (!headerWritten1 || !File.Exists(fileName)){
            //    using (StreamWriter writer = new StreamWriter(fileName, true)){
            //        writer.WriteLine("All games:");
            //    }
            //    headerWritten1 = true;
            //}

            // Write the data to the file
            //using (StreamWriter writer = new StreamWriter(fileName, true)){ // opens the file in append mode
            //    foreach (var game in games){
            //        writer.WriteLine(game.GetData());
            //    }
            //    games.Clear();
            //}

            // Check if the header has already been written
            //if (!headerWritten2 || !File.Exists(fileName)){
            //    using (StreamWriter writer = new StreamWriter(fileName, true)){
            //        writer.WriteLine("Apex Legends:");
            //    }
            //    headerWritten2 = true;
            //}

            // Write the data to the file
            using (StreamWriter writer = new StreamWriter(fileName, true)){ // opens the file in append mode
                foreach (var a in apex){
                    writer.WriteLine($"Apex Legends - {a.GetData()}");
                }
                apex.Clear();
            }

            using (StreamWriter writer = new StreamWriter(fileName, true)){
                foreach (var m in modern){
                    writer.WriteLine($"Modern Warfare 2 - {m.GetData()}");
                }
                modern.Clear();
            }

            using (StreamWriter writer = new StreamWriter(fileName, true)){
                foreach (var g in ghost){
                    writer.WriteLine($"Ghost - {g.GetData()}");
                }
                ghost.Clear();
            }
            
            
            //    foreach (var game in games){
            //        writer.WriteLine(game.GetData());
            //    }
            //    writer.WriteLine();
//
            //    writer.WriteLine("Apex Legends Randoms:");
            //    foreach (var a in apex){
            //        writer.WriteLine(a.GetData());
            //    }
//
            //    writer.WriteLine();
//
            //    writer.WriteLine("Modern Warfare 2 Randoms:");
            //    foreach (var m in modern){
            //        writer.WriteLine(m.GetData());
            //    }
//
            //    writer.WriteLine();
//
            //    writer.WriteLine("Call of Duty Ghost Extinction Randoms:");
            //    foreach (var g in ghost){
            //        writer.WriteLine(g.GetData());
            //    }
            //}
        }
    }
}