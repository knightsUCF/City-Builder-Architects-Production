using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Add BoxCollider istrigger on the parent object, a little larger than the object




public class LumberMillAI : MonoBehaviour
{


    public bool callOnceAIWorker = true;
    public bool callOncePlayerWorker = true;


    void Awake()
    {
        Debug.Log("LumberMillAI Awake() called");
        // perhaps will need some way later to know which lumber mill was built
        EventManager.TriggerEvent("LumberMillBuilt");
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AIWorker" && callOnceAIWorker)
        {
            callOnceAIWorker = false;
            EventManager.TriggerEvent("AIWorkerArrivedAtLumberMill");
        }
    }

}
