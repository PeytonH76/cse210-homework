using System;

public class RandomGenerator4{
    List<string> profiles = new List<string>();
    public RandomGenerator4(){

    }

    public string GetProfiles(){
        profiles.Add("NightPaladin381");
        profiles.Add("Cooli0Starstash");
        profiles.Add("ItsKnuckles76");
        profiles.Add("Haloalo76");
        profiles.Add("STARSDelta");
        Random p = new Random();
        int profile = p.Next(profiles.Count);
        string randProfile = profiles[profile];
        return randProfile;
    }
}