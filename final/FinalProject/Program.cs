using System.Collections.Generic;

class Program
{
    static void Main(string[] args){

        List<Game> apexRandom = new List<Game>();
        List<Game> modernRandom = new List<Game>();
        List<Game> ghostRandom = new List<Game>();
        List<Game> randoms = new List<Game>();
        Save save = new Save();
        Load load = new Load();

        bool stop = false;
        while (stop != true){

            Console.WriteLine();
            Console.WriteLine("Choose a game to get a random output from. (choose the number)");
            Console.WriteLine();
            Console.WriteLine("1. Apex Legends");
            Console.WriteLine("2. Call of Duty Modern Warfare 2");
            Console.WriteLine("3. Call of Duty Ghost Extinction");
            Console.WriteLine("4. View Randoms");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");

            Console.WriteLine(" ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1" || choice == "one"){
                GetApexLegends apex = new GetApexLegends();
                Console.WriteLine("Did you want to get a random character, weapon, or both? ");
                string choice2 = Console.ReadLine();
                if (choice2 == "character"){
                    apex.GetCharacter();
                    apexRandom.Add(apex);
                    randoms.Add(apex);
                    save.GetSave(randoms, apexRandom, modernRandom, ghostRandom);
                }
                else if (choice2 == "weapon"){
                    apex.GetWeapon();
                    apexRandom.Add(apex);
                    randoms.Add(apex);
                    save.GetSave(randoms, apexRandom, modernRandom, ghostRandom);
                }
                else if (choice2 == "both"){
                    apex.GetLoadout();
                    apexRandom.Add(apex);
                    randoms.Add(apex);
                    save.GetSave(randoms, apexRandom, modernRandom, ghostRandom);
                }
            }
            else if (choice == "2" || choice == "two"){
                GetModernWarfare2 modern = new GetModernWarfare2();
                Console.WriteLine("Did you want to get a random character, weapon, or loadout? ");
                string choice2 = Console.ReadLine();
                if (choice2 == "character"){
                    modern.GetCharacter();
                    modernRandom.Add(modern);
                    randoms.Add(modern);
                    save.GetSave(randoms, apexRandom, modernRandom, ghostRandom);             
                }
                else if (choice2 == "weapon"){
                    modern.GetWeapon();
                    modernRandom.Add(modern);
                    randoms.Add(modern);
                    save.GetSave(randoms, apexRandom, modernRandom, ghostRandom);
                }
                else if (choice2 == "loadout"){
                    modern.GetLoadout();
                    modernRandom.Add(modern);
                    randoms.Add(modern);
                    save.GetSave(randoms, apexRandom, modernRandom, ghostRandom);
                }
            }
            else if (choice == "3" || choice == "three"){

            }
            else if (choice == "4" || choice == "four"){
                Console.WriteLine("Apex Legends:");
                foreach (Game random in apexRandom){
                    random.GetList();
                }

                Console.WriteLine();

                Console.WriteLine("Modern Warfare 2:");
                foreach (Game random in modernRandom){
                    random.GetList();
                }

                Console.WriteLine();

                Console.WriteLine("All");
                foreach (Game random in randoms){
                    random.GetList();
                }
            }
            else if (choice == "5" || choice == "five"){

            }
            else if (choice == "6" || choice == "six"){
                load.GetLoad();
            }
            else{
                stop = true;
            }

        }
        
    }
}