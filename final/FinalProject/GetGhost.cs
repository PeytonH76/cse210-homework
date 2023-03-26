using System;

public class GetGhost: Game{

    private List<string> randomInputs = new List<string>();
    
    public GetGhost(){

    }

    public override void GetCharacter(){

    }
    public override void GetLoadout(){

    }
    public override void GetWeapon(){
        
    }
    public override void GetList()
    {
        throw new NotImplementedException();
    }
    public override string GetData(){
        return string.Join(": ", randomInputs);
    }
}