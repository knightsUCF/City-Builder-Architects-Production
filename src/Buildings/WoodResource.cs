using System.Collections;
using System.Collections.Generic;
using UnityEngine;





// Add BoxCollider istrigger on the parent object, a little larger than the object



public class WoodResource : MonoBehaviour
{

    public bool callOnceAIWorker = true;
    public bool callOncePlayerWorker = true;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AIWorker" && callOnceAIWorker)
        {
            Debug.Log("AI worker picking up wood");
            callOnceAIWorker = false;

            EventManager.TriggerEvent("AIWorkerArrivedAtWoodResource");

            // reset callOnce in the WoodHarvest script
        }

        if (other.tag == "Worker" && callOncePlayerWorker)
        {
            Debug.Log("Player worker picking up wood");
            callOncePlayerWorker = false;

            EventManager.TriggerEvent("PlayerWorkerArrivedAtWoodResource");

            // reset callOnce in the WoodHarvest script
        }
    }

}
