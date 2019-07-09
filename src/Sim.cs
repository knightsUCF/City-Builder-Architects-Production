using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


/*
Use

1. Data.cs: public static List<Sim> sims = new List<Sim>();

2. TestClass.cs: Data.sims.Add(new Sim(1, "John", 50));

3. TestClass.cs: foreach(Sim sim in Data.sims) print(sim.name + " " + sim.level);

4. Enums extra step, TestClass.cs:

Sim.Workplace workplace = Sim.Workplace.None;
Data.sims.Add(new Sim(1, "John", 50, workplace));

*/



public class Sim
{

    public int ID;
    public int avatarID;
    public int residentialID;
    public string name;
    public int level;


    public enum Workplace
    {
        None,
        PowerPlant
    }

    public Workplace workplace;



    public Sim(int newID, int newAvatarID, int newResidentialID, string newName, int newLevel, Workplace newWorkplace)
    {
        ID = newID;
        avatarID = newAvatarID;
        residentialID = newResidentialID;
        name = newName;
        level = newLevel;
        workplace = newWorkplace;
    }

}









