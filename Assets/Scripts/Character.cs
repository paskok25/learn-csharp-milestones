using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character{
    public string name;
    public int exp = 0;

    public Character(){
        name = "not assigned";
    }

    public Character(string name){
        this.name = name;
    }

    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", this.name, this.exp);
    }
}

public class Paladin: Character{
    
    public Weapon weapon;

    public Paladin(string name, Weapon weapon): base(name){
        this.weapon = weapon;
    }
}