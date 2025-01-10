using System;

public class RandomGenerator5{
    List<string> amibos = new List<string>();
    public RandomGenerator5(){

    }

    public string GetAmibos(){
        amibos.Add("Chris Prat");
        amibos.Add("Lugi");
        amibos.Add("Byleth");
        amibos.Add("Sean");
        amibos.Add("The Mascot");
        amibos.Add("Ms. Lady");
        amibos.Add("Athena");
        amibos.Add("Super");
        amibos.Add("Manly");
        amibos.Add("Mr. Grunt");
        amibos.Add("Hera");
        amibos.Add("Twilight");
        amibos.Add("Polution");
        amibos.Add("Dadoo");
        amibos.Add("Jeff");
        amibos.Add("Gandalf");
        amibos.Add("Moist");
        amibos.Add("Youngly");
        amibos.Add("Captain");
        amibos.Add("Yuli");
        amibos.Add("Bookguy");
        amibos.Add("Dynamite");
        amibos.Add("Parasite");
        amibos.Add("Lombardi");
        amibos.Add("Dry Bowser");
        amibos.Add("Arms");
        amibos.Add("Zero");
        amibos.Add("Mister");
        amibos.Add("Bolt");
        amibos.Add("Sprite");
        amibos.Add("Tornado");
        amibos.Add("Teeth");
        amibos.Add("Shadow");
        amibos.Add("Ball");
        amibos.Add("Poke");
        amibos.Add("OP");
        amibos.Add("Muscle");
        amibos.Add("Steve");
        amibos.Add("Batman");
        amibos.Add("Princess");
        amibos.Add("Tongue");
        amibos.Add("Sanic");
        amibos.Add("Yoda");
        amibos.Add("Sally");
        amibos.Add("Omega");
        amibos.Add("Nova");
        amibos.Add("Paige");
        amibos.Add("Big Boy");
        amibos.Add("Peanut");
        amibos.Add("Goku");
        amibos.Add("Yuki");
        amibos.Add("Metal");
        amibos.Add("Silver");
        Random a = new Random();
        int amibo = a.Next(amibos.Count);
        string randAmibo = amibos[amibo];
        return randAmibo;
    }
}