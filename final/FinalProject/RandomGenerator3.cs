using System;

public class RandomGenerator3{

    private List<string> _possibleweapons = new List<string>();
    private List<string> _classes = new List<string>();
    private List<string> _pistols = new List<string>();
    private List<string> _ammo = new List<string>();
    private List<string> _strikePackages = new List<string>();
    private List<string> _teamSupport = new List<string>();
    private List<string> _equalizers = new List<string>();

    public RandomGenerator3(){

    }

    public string GetRandomWeapon(){
        _possibleweapons.Add("SC-2010");
        _possibleweapons.Add("AK-12");
        _possibleweapons.Add("SA-805");
        _possibleweapons.Add("Bizon");
        _possibleweapons.Add("CBJ-MS");
        _possibleweapons.Add("Vector CRB");
        _possibleweapons.Add("K7");
        _possibleweapons.Add("M27-IAR");
        _possibleweapons.Add("Chain Saw");
        _possibleweapons.Add("MR-28");
        _possibleweapons.Add("IA-2");
        _possibleweapons.Add("VKS");
        _possibleweapons.Add("L115");
        _possibleweapons.Add("Panzerfaust");
        _possibleweapons.Add("Kastet");
        _possibleweapons.Add("FP6");
        _possibleweapons.Add("Bulldog");
        _possibleweapons.Add("Vepr");
        _possibleweapons.Add("MTS-255");
        _possibleweapons.Add("MTAR-X");
        Random w = new Random();
        int weapon = w.Next(_possibleweapons.Count);
        string randWeapon = _possibleweapons[weapon];
        return randWeapon;
    }

    public string GetRandomClass(){
        _classes.Add("Weapon Specialist");
        _classes.Add("Tank");
        _classes.Add("Engineers");
        _classes.Add("Medic");
        Random c = new Random();
        int clas = c.Next(_classes.Count);
        string randClass = _classes[clas];
        return randClass;
    }

    public string GetRandomPistol(){
        _pistols.Add("P226 Pistol");
        _pistols.Add(".44 Magnum Pistol");
        _pistols.Add("M9A1 Pistol");
        _pistols.Add("MP-443 Grach Pistol");
        Random p = new Random();
        int pistol = p.Next(_pistols.Count);
        string randPistol = _pistols[pistol];
        return randPistol;
    }

    public string GetRandomAmmo(){
        _ammo.Add("Ammo");
        _ammo.Add("Stun Ammo");
        _ammo.Add("Incendiary Ammo");
        _ammo.Add("Explosive Ammo");
        _ammo.Add("Armor Piercing Ammo");
        Random a = new Random();
        int ammo = a.Next(_ammo.Count);
        string randAmmo = _ammo[ammo];
        return randAmmo;
    }

    public string GetTeamSupport(){
        _teamSupport.Add("Team Explosives");
        _teamSupport.Add("Feral Instincts");
        _teamSupport.Add("Armor");
        _teamSupport.Add("Team Booster");
        _teamSupport.Add("Random Supplies");
        Random t = new Random();
        int team = t.Next(_teamSupport.Count);
        string randTeam = _teamSupport[team];
        return randTeam;
    }

    public string GetStrikePackage(){
        _strikePackages.Add("I.M.S");
        _strikePackages.Add("Mortar Strike");
        _strikePackages.Add("Trinity Rocket(MAAWS Rocket)");
        _strikePackages.Add("Sentry Gun");
        _strikePackages.Add("Vulture");
        Random s = new Random();
        int strike = s.Next(_strikePackages.Count);
        string randStrike = _strikePackages[strike];
        return randStrike;
    }

    public string GetEqualizer(){
        _equalizers.Add("Portable Turrent");
        _equalizers.Add("Grenade Turrent");
        _equalizers.Add("Crowd Control");
        _equalizers.Add("MK32 Launcher");
        _equalizers.Add("Death Machine");
        Random e = new Random();
        int equal = e.Next(_equalizers.Count);
        string randEqual = _equalizers[equal];
        return randEqual;
    }
}