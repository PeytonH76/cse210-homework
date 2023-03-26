using System;

public class GetModernWarfare2: Game{
    
    private List<string> randomInputs = new List<string>();
    public GetModernWarfare2(){

    }

    public override void GetLoadout(){
        RandomGenerator2 random = new RandomGenerator2();
        string character = random.GetRandomCharacter();
        string weapon = random.GetRandomWeapon();
        string tactical = random.GetRandomTactical();
        randomInputs.Add($"{character}: {weapon}: {tactical}");
        Console.WriteLine($"{character}: {weapon}: {tactical}");
    }
    public override void GetCharacter(){
        RandomGenerator2 random = new RandomGenerator2();
        string character = random.GetRandomCharacter();
        randomInputs.Add(character);
        Console.WriteLine(character);

    }
    public override void GetWeapon(){
        RandomGenerator2 random = new RandomGenerator2();
        string weapon = random.GetRandomWeapon();
        randomInputs.Add(weapon);
        Console.WriteLine(weapon);
    }
    public override void GetList(){
        foreach (string input in randomInputs){
            Console.WriteLine($"   Modern Warfare 2- {input}");
        }
    }
    public override string GetData(){
        return string.Join(": ", randomInputs);
    }
}