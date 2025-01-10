using System;

public class GetAmibos: Game{
    private List<string> randomInputs = new List<string>();
    public GetAmibos(){

    }

    public override void GetList(){
    }
    public override void GetLoadout(){
    }
    public override void GetCharacter(){
        RandomGenerator5 random = new RandomGenerator5();
        string amibo = random.GetAmibos();
        randomInputs.Add(amibo);
        Console.WriteLine(amibo);
    }
    public override void GetWeapon(){
    }
    public override string GetData(){
        return string.Join(": ", randomInputs);
    }
}