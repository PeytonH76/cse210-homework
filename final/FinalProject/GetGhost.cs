using System;

public class GetGhost: Game{

    private List<string> randomInputs = new List<string>();
    
    public GetGhost(){

    }

    public override void GetCharacter(){
    }
    public override void GetLoadout(){
        RandomGenerator3 random = new RandomGenerator3();
        string weapon = random.GetRandomWeapon();
        string weapon2 = random.GetRandomWeapon();
        string _class = random.GetRandomClass();
        string pistol = random.GetRandomPistol();
        string ammo = random.GetRandomAmmo();
        string support = random.GetTeamSupport();
        string package = random.GetStrikePackage();
        string equalizer = random.GetEqualizer();
        randomInputs.Add($"{_class}: {weapon}, {weapon2}: {pistol}: {ammo}: {support}: {package}: {equalizer}");
        Console.WriteLine($"{_class}: {weapon}, {weapon2}: {pistol}: {ammo}: {support}: {package}: {equalizer}");

    }
    public override void GetWeapon(){
        RandomGenerator3 random = new RandomGenerator3();
        string weapon = random.GetRandomWeapon();
        string weapon2 = random.GetRandomWeapon();
        randomInputs.Add($"{weapon}, {weapon2}");
        Console.WriteLine($"{weapon}, {weapon2}");
    }
    public override void GetList(){
        foreach (string input in randomInputs){
            Console.WriteLine($"   Ghost- {input}");
        }
    }
    public override string GetData(){
        return string.Join(": ", randomInputs);
    }
}