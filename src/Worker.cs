using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{

    public int ID = -1; // unassigned


    void Start()
    {
        Data.currentSimID += 1;
        Data.sims.Add(new Sim(Data.currentSimID, "John", 50));

        ID = Data.currentSimID;
    }


}
