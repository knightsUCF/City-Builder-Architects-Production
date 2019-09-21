using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// set collider and rigid body on object to detect click



public class BuildingWorkerPlacement : MonoBehaviour
{

    public GameObject[] sims;

    public int placedSimID = -1;



    void OnMouseDown()
    {
        foreach (GameObject sim in sims)
        {
            if (sim.GetComponent<SimData>().selected)
            {
                placedSimID = sim.GetComponent<SimData>().ID;
            }
        }

    }



    
}
