using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// set collider and rigid body on object to detect click



public class BuildingWorkerPlacement : MonoBehaviour
{

    public GameObject[] sims;

    public int placedSimID = -1;



    // drag in a cube, and then turn off mesh, this is the door position the sim will go to

    public GameObject doorPos;
    private Vector3 destination;



    void OnEnable()
    {
        destination = doorPos.transform.position;
    }



    void OnMouseDown()
    {
        foreach (GameObject sim in sims)
        {
            if (sim.GetComponent<SimData>().selected)
            {
                placedSimID = sim.GetComponent<SimData>().ID;
                sim.GetComponent<SimController>().WalkToBuilding(destination);
            }
        }

    }



    
}
