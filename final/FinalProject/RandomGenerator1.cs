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
        _weapons.Add("VK-47 Flatline");
        _weapons.Add("Hemlok Burst AR");
        _weapons.Add("Prowler Burst PDW");
        _weapons.Add("Nemesis Burst AR");
        _weapons.Add("R-99 SMG");
        _weapons.Add("Volt SMG");
        _weapons.Add("C.A.R SMG");
        _weapons.Add("Devotion LMG");
        _weapons.Add("L-STAR EMG");
        _weapons.Add("M600 Spitfire");
        _weapons.Add("Rampage LMG");
        _weapons.Add("G7 Scout");
        _weapons.Add("Triple Take");
        _weapons.Add("30-30 Repeater");
        _weapons.Add("Bocek Compound Bow");
        _weapons.Add("Charge Rifle");
        _weapons.Add("Longbow DMR");
        _weapons.Add("Kraber .50-Cal Sniper");
        _weapons.Add("Sentinel");
        _weapons.Add("EVA-8 Auto");
        _weapons.Add("Mastiff Shotgun");
        _weapons.Add("Mozambique Shotgun");
        _weapons.Add("Peacekeeper");
        _weapons.Add("RE-45 Auto");
        _weapons.Add("P2020");
        _weapons.Add("Wingman");
        _weapons.Add("Fists");
        Random w = new Random();
        int weapon = w.Next(_weapons.Count);
        string randWeapon = _weapons[weapon];
        return randWeapon;
    }

    public string GetRandomCharacter(){
        _character.Add("Wattson");
        _character.Add("Bloodhound");
        _character.Add("Wraith");
        _character.Add("Ash");
        _character.Add("Bangalore");
        _character.Add("Catalyst");
        _character.Add("Caustic");
        _character.Add("Crypto");
        _character.Add("Fuse");
        _character.Add("Gibraltar");
        _character.Add("Horizon");
        _character.Add("Lifeline");
        _character.Add("Loba");
        _character.Add("Mad Maggie");
        _character.Add("Mirage");
        _character.Add("Newcastle");
        _character.Add("Octane");
        _character.Add("Pathfinder");
        _character.Add("Rampart");
        _character.Add("Revenant");
        _character.Add("Seer");
        _character.Add("Valkyrie");
        _character.Add("Vantage");
        _character.Add("Ballistic");
        Random c = new Random();
        int character = c.Next(_character.Count);
        string randCharacter = _character[character];
        return randCharacter; 
    }
}