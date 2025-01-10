using System;

public class GetBaseballTeams: Game{
    private List<string> randomInputs = new List<string>();
    public GetBaseballTeams(){

    }

    public override void GetList(){
        foreach (string input in randomInputs){
            Console.WriteLine($"   -Baseball Team {input}");
        }
    }
    public override void GetLoadout(){
    }
    public override void GetCharacter(){
        RandomGenerator6 random = new RandomGenerator6();
        string team = random.GetBaseballTeams();
        randomInputs.Add($"{team}");
        Console.WriteLine($"{team}");
    }
    public override void GetWeapon(){
    }
    public override string GetData(){
        return string.Join(": ", randomInputs);
    }
}