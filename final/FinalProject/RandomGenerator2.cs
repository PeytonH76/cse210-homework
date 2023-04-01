using System;

public class RandomGenerator2{

    private List<string> _weapons = new List<string>();
    private List<string> _character = new List<string>();
    private List<string> _tacticals = new List<string>();
    private List<string> _lethals = new List<string>();

    public RandomGenerator2(){

    }

    public string GetRandomWeapon(){
        _weapons.Add("M4");
        _weapons.Add("M16");
        _weapons.Add("TAQ-56");
        _weapons.Add("Lachmann-556");
        _weapons.Add("Kastov-74U");
        _weapons.Add("STB 556");
        _weapons.Add("Kastov 762");
        _weapons.Add("Kastov 545");
        _weapons.Add("Kastov 545");
        _weapons.Add("M13B");
        _weapons.Add("Chimera");
        _weapons.Add("FTAC Recon");
        _weapons.Add("Lachmann-762");
        _weapons.Add("TAQ-V");
        _weapons.Add("SO-14");
        _weapons.Add("Lachmann Sub");
        _weapons.Add("FSS Hurricane");
        _weapons.Add("Fennec 45");
        _weapons.Add("BAS-P");
        _weapons.Add("MX9");
        _weapons.Add("MINIBAK");
        _weapons.Add("VEL 46");
        _weapons.Add("PDSW-528");
        _weapons.Add("Vasnev-9K");
        _weapons.Add("BAS-P");
        _weapons.Add("Expedite 12");
        _weapons.Add("Bryson 800");
        _weapons.Add("Bryson 890");
        _weapons.Add("Lockwood 300");
        _weapons.Add("556 Icarus");
        _weapons.Add("RAPP H");
        _weapons.Add("Sakin MG38");
        _weapons.Add("RAAL MG");
        _weapons.Add("HCR 56");
        _weapons.Add("RPK");
        _weapons.Add("LM-S");
        _weapons.Add("Lockwood MK2");
        _weapons.Add("SP-R 208");
        _weapons.Add("EBR-14");
        _weapons.Add("SA-B 50");
        _weapons.Add("TAQ-M");
        _weapons.Add("Signal 50");
        _weapons.Add("LA-B 330");
        _weapons.Add("MCPR-300");
        _weapons.Add("SP-X 80");
        _weapons.Add("Victus XMR");
        _weapons.Add("Combat Knife");
        _weapons.Add("Riot Shield");
        Random w = new Random();
        int weapon = w.Next(_weapons.Count);
        string randWeapon = _weapons[weapon];
        return randWeapon;
    }

    public string GetRandomTactical(){
        _tacticals.Add("Decoy Grenade");
        _tacticals.Add("Flash Grenade");
        _tacticals.Add("Gas Grenade");
        _tacticals.Add("Heartbeat Sensor");
        _tacticals.Add("Shock Stick");
        _tacticals.Add("Smoke Grenade");
        _tacticals.Add("Snapshot Grenade");
        _tacticals.Add("Spotter Scope");
        _tacticals.Add("Stim");
        _tacticals.Add("Stun Grenade");
        Random t = new Random();
        int tactical = t.Next(_tacticals.Count);
        string randTact = _tacticals[tactical];
        return randTact;
    }

    public string GetRandomLethal(){
        _lethals.Add("Frag Grenade");
        _lethals.Add("Proximity Mine");
        _lethals.Add("Thermite");
        _lethals.Add("Semtex");
        _lethals.Add("Drill Charge");
        _lethals.Add("C4");
        _lethals.Add("Throwing Knife");
        _lethals.Add("Molotov Cocktail");
        _lethals.Add("Claymore");
        Random l = new Random();
        int lethal = l.Next(_lethals.Count);
        string randLeth = _lethals[lethal];
        return randLeth;
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