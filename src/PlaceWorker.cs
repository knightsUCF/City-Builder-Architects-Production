using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*

so a simple way would be to select the worker, and then select the structure

so from the perspective of the structure, if the structure is clicked, then search for the selected worker if not null

then if that worker comes in contact with the structure's collider, then make the woker disappeared, and add them to the structures inventory

also start producing energy in the case of the power plant

and also begin leveling up the worker



*/


public class PlaceWorker : MonoBehaviour
{


    public bool callOnce = true;

    public int workerID = -1; // will need more of these for multiple workers


    



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Worker" && callOnce)
        {
            callOnce = false;

            Worker worker = other.gameObject.GetComponent<Worker>();
            workerID = worker.ID;
            other.gameObject.SetActive(false);

            GetComponent<Factory>().producingEnergy = true;
        }
    }
}




