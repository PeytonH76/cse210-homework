using System;

public class RandomGenerator1{

    private List<string> _weapons = new List<string>();
    private List<string> _character = new List<string>();

    public RandomGenerator1(){

    }



    public string GetRandomWeapon(){
        _weapons.Add("R-301 Carbine");
        _weapons.Add("HAVOC Rifle");
        _weapons.Add("Alternator SMG");
        Random w = new Random();
        int weapon = w.Next(_weapons.Count);
        string randWeapon = _weapons[weapon];
        return randWeapon;
    }

    public string GetRandomCharacter(){
        _character.Add("Wattson");
        _character.Add("Bloodhound");
        _character.Add("Wraith");
        Random c = new Random();
        int character = c.Next(_character.Count);
        string randCharacter = _character[character];
        return randCharacter; 
    }
}