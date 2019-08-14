using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Add BoxCollider istrigger on the parent object, a little larger than the object




public class LumberMillPlayer : MonoBehaviour
{


    public bool callOnceAIWorker = true;
    public bool callOncePlayerWorker = true;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Worker" && callOncePlayerWorker)
        {
            callOncePlayerWorker = false;
            EventManager.TriggerEvent("PlayerWorkerArrivedAtLumberMill");
        }
    }

}
