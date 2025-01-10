using System;

public class GetProfiles: Game{
    private List<string> randomInputs = new List<string>();
    public GetProfiles(){

    }

    public override void GetList(){
    }
    public override void GetLoadout(){
    }
    public override void GetCharacter(){
        RandomGenerator4 random = new RandomGenerator4();
        string profile = random.GetProfiles();
        randomInputs.Add(profile);
        Console.WriteLine(profile);
    }
    public override void GetWeapon(){
    }
    public override string GetData(){
        return string.Join(": ", randomInputs);
    }
}