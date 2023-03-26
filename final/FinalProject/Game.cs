using System;

public abstract class Game{
    
    public Game(){

    }

    public abstract void GetLoadout();  
    public abstract void GetCharacter();
    public abstract void GetWeapon();
    public abstract void GetList();
    public abstract string GetData();
}