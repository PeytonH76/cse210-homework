using System;

public class RandomGenerator2{
    
    private List<string> _weapons = new List<string>();
    private List<string> _character = new List<string>();
    private List<string> _tacticals = new List<string>();

    public RandomGenerator2(){

    }

    public string GetRandomWeapon(){
        _weapons.Add("M4");
        _weapons.Add("M16");
        _weapons.Add("TAQ-56");
        Random w = new Random();
        int weapon = w.Next(_weapons.Count);
        string randWeapon = _weapons[weapon];
        return randWeapon;
    }

    public string GetRandomTactical(){
        _tacticals.Add("Decoy Grenade");
        _tacticals.Add("Flash Grenade");
        _tacticals.Add("Gas Grenade");
        Random t = new Random();
        int tactical = t.Next(_tacticals.Count);
        string randTact = _tacticals[tactical];
        return randTact;
    }

    public string GetRandomCharacter(){
        _character.Add("Aksel");
        _character.Add("Calisto");
        _character.Add("Captain Price");
        Random c = new Random();
        int character = c.Next(_character.Count);
        string randCharacter = _character[character];
        return randCharacter; 
    }

}