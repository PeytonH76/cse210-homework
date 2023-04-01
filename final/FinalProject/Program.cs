using System.Collections.Generic;

class Program
{
    static void Main(string[] args){

        List<Game> apexRandom = new List<Game>();
        List<Game> listApex = new List<Game>();
        List<Game> modernRandom = new List<Game>();
        List<Game> listModern = new List<Game>();
        List<Game> ghostRandom = new List<Game>();
        List<Game> listGhost = new List<Game>();
        List<Game> randoms = new List<Game>();
        List<Game> listRandoms = new List<Game>();
        Save save = new Save();
        Load load = new Load();
        string[] loadedFileContent = null;

        bool stop = false;
        while (stop != true){

            Console.WriteLine();
            Console.WriteLine("Choose a game to get a random output from, or view and load your list. (choose the number)");
            Console.WriteLine();
            Console.WriteLine("1. Apex Legends");
            Console.WriteLine("2. Call of Duty Modern Warfare 2");
            Console.WriteLine("3. Call of Duty Ghost Extinction");
            Console.WriteLine("4. View Randoms (Shows all saved and not saved until a file is loaded)");
            Console.WriteLine("5. Loaded Randoms");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");

            Console.WriteLine(" ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1" || choice == "one"){
                GetApexLegends apex = new GetApexLegends();
                Console.WriteLine("Did you want to get a random character, weapon, or both? ");
                Console.WriteLine();
                string choice2 = Console.ReadLine();
                if (choice2 == "character"){
                    apex.GetCharacter();
                    apexRandom.Add(apex);
                    randoms.Add(apex);
                    listRandoms.Add(apex);
                    listApex.Add(apex);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to save? (yes/no)");
                    string choice3 = Console.ReadLine();
                    save.GetSave(choice3, randoms, apexRandom, modernRandom, ghostRandom);
                }
                else if (choice2 == "weapon"){
                    apex.GetWeapon();
                    apexRandom.Add(apex);
                    randoms.Add(apex);
                    listRandoms.Add(apex);
                    listApex.Add(apex);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to save? (yes/no)");
                    string choice3 = Console.ReadLine();
                    save.GetSave(choice3, randoms, apexRandom, modernRandom, ghostRandom);
                }
                else if (choice2 == "both"){
                    apex.GetLoadout();
                    apexRandom.Add(apex);
                    randoms.Add(apex);
                    listRandoms.Add(apex);
                    listApex.Add(apex);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to save? (yes/no)");
                    string choice3 = Console.ReadLine();
                    save.GetSave(choice3, randoms, apexRandom, modernRandom, ghostRandom);                
                }
            }
            else if (choice == "2" || choice == "two"){
                GetModernWarfare2 modern = new GetModernWarfare2();
                Console.WriteLine("Did you want to get a random character, weapon, or loadout? ");
                Console.WriteLine();
                string choice2 = Console.ReadLine();
                if (choice2 == "character"){
                    modern.GetCharacter();
                    modernRandom.Add(modern);
                    randoms.Add(modern);
                    listRandoms.Add(modern);
                    listModern.Add(modern);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to save? (yes/no)");
                    string choice3 = Console.ReadLine();
                    save.GetSave(choice3, randoms, apexRandom, modernRandom, ghostRandom);                
                }
                else if (choice2 == "weapon"){
                    modern.GetWeapon();
                    modernRandom.Add(modern);
                    randoms.Add(modern);
                    listRandoms.Add(modern);
                    listModern.Add(modern);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to save? (yes/no)");
                    string choice3 = Console.ReadLine();
                    save.GetSave(choice3, randoms, apexRandom, modernRandom, ghostRandom);               
                }
                else if (choice2 == "loadout"){
                    modern.GetLoadout();
                    modernRandom.Add(modern);
                    randoms.Add(modern);
                    listRandoms.Add(modern);
                    listModern.Add(modern);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to save? (yes/no)");
                    string choice3 = Console.ReadLine();
                    save.GetSave(choice3, randoms, apexRandom, modernRandom, ghostRandom);                
                }
            }
            else if (choice == "3" || choice == "three"){
                GetGhost ghost = new GetGhost();
                Console.WriteLine("Do you want to get a random weapon or loadout?");
                Console.WriteLine();
                string choice2 = Console.ReadLine();
                if (choice2 == "weapon"){
                    ghost.GetWeapon();
                    ghostRandom.Add(ghost);
                    randoms.Add(ghost);
                    listRandoms.Add(ghost);
                    listGhost.Add(ghost);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to save? (yes/no)");
                    string choice3 = Console.ReadLine();
                    save.GetSave(choice3, randoms, apexRandom, modernRandom, ghostRandom);                
                }
                else if (choice2 == "loadout"){
                    ghost.GetLoadout();
                    ghostRandom.Add(ghost);
                    randoms.Add(ghost);
                    listRandoms.Add(ghost);
                    listGhost.Add(ghost);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to save? (yes/no)");
                    string choice3 = Console.ReadLine();
                    save.GetSave(choice3, randoms, apexRandom, modernRandom, ghostRandom);     
                }
            }
            // View Randoms
            else if (choice == "4" || choice == "four"){
                Console.WriteLine("Apex Legends:");
                foreach (Game random in listApex){
                    random.GetList();
                }
                Console.WriteLine();
                Console.WriteLine("Modern Warfare 2:");
                foreach (Game random in listModern){
                    random.GetList();
                }
                Console.WriteLine();
                Console.WriteLine("Ghost:");
                foreach (Game random in listGhost){
                    random.GetList();
                }
                Console.WriteLine();
                Console.WriteLine("All:");
                foreach (Game random in listRandoms){
                    random.GetList();
                }
                Console.WriteLine();
            }
            else if (choice == "5" || choice == "five"){
                if (loadedFileContent != null) {
                    Console.WriteLine();
                    Console.WriteLine("Loaded File Content:");
                    Console.WriteLine();
                    foreach (string line in loadedFileContent) {
                        Console.WriteLine(line);
                    }
                }
                else{
                    Console.WriteLine();
                    Console.WriteLine("You haven't loaded any files yet.");
                }
                Console.WriteLine();
            }
            else if (choice == "6" || choice == "six"){
                loadedFileContent = load.GetLoad();
                listApex.Clear();
                listGhost.Clear();
                listModern.Clear();
                listRandoms.Clear();
            }
            else{
                stop = true;
            }

        }
        
    }
}