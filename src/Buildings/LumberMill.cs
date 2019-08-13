using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Add BoxCollider istrigger on the parent object, a little larger than the object




public class LumberMill : MonoBehaviour
{


    public bool callOnceAIWorker = true;
    public bool callOncePlayerWorker = true;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AIWorker" && callOnceAIWorker)
        {
            Debug.Log("AI worker entering lumber mill!");
            callOnceAIWorker = false;

            EventManager.TriggerEvent("AIWorkerArrivedAtLumberMill");

            // reset callOnce in the WoodHarvest script
        }

        if (other.tag == "Worker" && callOncePlayerWorker)
        {
            Debug.Log("Player worker entering lumber mill!");
            callOncePlayerWorker = false;

            EventManager.TriggerEvent("PlayerWorkerArrivedAtLumberMill");

            // reset callOnce in the WoodHarvest script
        }
    }

}
