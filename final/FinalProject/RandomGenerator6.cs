using System;

public class RandomGenerator6{
    List<string> teams = new List<string>();

    public RandomGenerator6(){

    }

    public string GetBaseballTeams(){
        teams.Add("Air Nation");
        teams.Add("Amoeba");
        teams.Add("Ancestors");
        teams.Add("Animals");
        teams.Add("Animaniacs");
        teams.Add("Apex Legends");
        teams.Add("Arenas");
        teams.Add("Armys");
        teams.Add("Army Guys");
        teams.Add("Auroras");
        teams.Add("Autobots");
        teams.Add("Banished");
        teams.Add("Banner Lords");
        teams.Add("Barbarians");
        teams.Add("Basketball");
        teams.Add("Battle Masters");
        teams.Add("Black Eagle");
        teams.Add("Block Fortress");
        teams.Add("Bloons TD");
        teams.Add("Blue Lions");
        teams.Add("Bowsers Army");
        teams.Add("Brawlhalla");
        teams.Add("Builders");
        teams.Add("Call of Duty");
        teams.Add("Call of Mini");
        teams.Add("Call to Arms");
        teams.Add("Clankers");
        teams.Add("Clash Royale");
        teams.Add("Clash of Clans");
        teams.Add("Clones");
        teams.Add("Collages");
        teams.Add("Creepers");
        teams.Add("Cycles");
        teams.Add("D C Universe");
        teams.Add("Dark Elves");
        teams.Add("Darkest Dungeon");
        teams.Add("Darks");
        teams.Add("Decepticons");
        teams.Add("Demonspawn");
        teams.Add("Doctor Who");
        teams.Add("Dragons");
        teams.Add("Dreams");
        teams.Add("Dungeon Defenders");
        teams.Add("Earth Nation");
        teams.Add("Egyptians");
        teams.Add("Empire");
        teams.Add("Enlisted");
        teams.Add("Falcons");
        teams.Add("Females");
        teams.Add("Female Watchers");
        teams.Add("Ferbots");
        teams.Add("Fielders");
        teams.Add("Finders");
        teams.Add("Fire Emblem");
        teams.Add("Fire Nation");
        teams.Add("Floods");
        teams.Add("FNAF");
        teams.Add("Fortnite");
        teams.Add("Galaxies");
        teams.Add("Garrisons");
        teams.Add("Gatherers");
        teams.Add("Golden Deer");
        teams.Add("Greeks");
        teams.Add("Greys");
        teams.Add("Guardians");
        teams.Add("Gubs");
        teams.Add("Hallownest");
        teams.Add("Hedgehogs");
        teams.Add("High Elves");
        teams.Add("Huhs");
        teams.Add("Hunters");
        teams.Add("Hunts");
        teams.Add("Hyrule Warriors");
        teams.Add("Ices");
        teams.Add("Identity V");
        teams.Add("Inquisitors");
        teams.Add("Jackals");
        teams.Add("Jokers");
        teams.Add("K.L.G");
        teams.Add("Killers");
        teams.Add("Knight Revenants");
        teams.Add("Knights");
        teams.Add("Lancers");
        teams.Add("Legends");
        teams.Add("Lima Bears");
        teams.Add("Lizardmen");
        teams.Add("Males");
        teams.Add("Male Watchers");
        teams.Add("Marauders");
        teams.Add("Marines");
        teams.Add("Martyr");
        teams.Add("Mass Effect");
        teams.Add("Masterminds");
        teams.Add("Military");
        teams.Add("Military Police");
        teams.Add("Minecraft");
        teams.Add("Miners");
        teams.Add("Mixtures");
        teams.Add("Modeners");
        teams.Add("Mysterios");
        teams.Add("Namers");
        teams.Add("New Sieges");
        teams.Add("ODST's");
        teams.Add("Orcs");
        teams.Add("Overwatchers");
        teams.Add("Partakers");
        teams.Add("Plumbers");
        teams.Add("Police");
        teams.Add("Primarchs");
        teams.Add("Princesses");
        teams.Add("Questionable");
        teams.Add("Raccoon City Police Department");
        teams.Add("Radomenoes");
        teams.Add("Randoms");
        teams.Add("Randos");
        teams.Add("Rands");
        teams.Add("Ravens");
        teams.Add("Resident Evil");
        teams.Add("Sabers");
        teams.Add("Samauri");
        teams.Add("Scouts");
        teams.Add("Seekers");
        teams.Add("Selectors");
        teams.Add("Sentinels");
        teams.Add("Shadowkin");
        teams.Add("Shovel Knight");
        teams.Add("Shy Guys");
        teams.Add("Sieges");
        teams.Add("Skyrim");
        teams.Add("Smashers");
        teams.Add("Sovereigns");
        teams.Add("Spacers");
        teams.Add("Spartans");
        teams.Add("Star Wars");
        teams.Add("STARS");
        teams.Add("Stellaris");
        teams.Add("Summoners");
        teams.Add("Survivors");
        teams.Add("Sylvan Watchers");
        teams.Add("Team Canon");
        teams.Add("Team Rory");
        teams.Add("The Avengers");
        teams.Add("The Covenant");
        teams.Add("The Order");
        teams.Add("The Sacreds");
        teams.Add("The Sacred Order");
        teams.Add("Tundras");
        teams.Add("U.A.F");
        teams.Add("Unkowns");
        teams.Add("Valorants");
        teams.Add("Valors");
        teams.Add("Vikings");
        teams.Add("Voids");
        teams.Add("Warfares");
        teams.Add("Waters");
        teams.Add("Water Nation");
        teams.Add("Wests");
        teams.Add("Whats");
        teams.Add("Wulanders");
        teams.Add("XCOM");
        teams.Add("X Rays");
        teams.Add("X Sieges");
        teams.Add("Yarndolls");
        teams.Add("Zimmers");
        teams.Add("Zinkies");
        Random t = new Random();
        int team = t.Next(teams.Count);
        string randteam = teams[team];
        return randteam;
    }
}