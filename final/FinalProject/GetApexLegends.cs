using System;

public class GetApexLegends: Game{
    private List<string> randomInputs = new List<string>();
    
    public GetApexLegends(){
        
    }

    public override void GetLoadout(){
        RandomGenerator1 random = new RandomGenerator1();
        string randomWeapon = random.GetRandomWeapon();
        string randomWeapon2 = random.GetRandomWeapon();
        string randomCharacter = random.GetRandomCharacter();
        randomInputs.Add($"{randomCharacter} + {randomWeapon} + {randomWeapon2}");
        Console.WriteLine($"{randomCharacter} + {randomWeapon} + {randomWeapon2}");
    }
    public override void GetCharacter(){
        RandomGenerator1 random = new RandomGenerator1();
        string randomCharacter = random.GetRandomCharacter();
        randomInputs.Add(randomCharacter);
        Console.WriteLine(randomCharacter);

    }
    public override void GetWeapon(){
        RandomGenerator1 random = new RandomGenerator1();
        string randomWeapon = random.GetRandomWeapon();
        randomInputs.Add(randomWeapon);
        Console.WriteLine(randomWeapon);

    }

    public override void GetList(){
        foreach (string input in randomInputs){
            Console.WriteLine($"   Apex Legends- {input}");
        }
    }

    public override string GetData(){
        return string.Join(": ", randomInputs);
    }
}