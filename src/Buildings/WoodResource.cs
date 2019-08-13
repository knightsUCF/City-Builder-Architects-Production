using System.Collections;
using System.Collections.Generic;
using UnityEngine;





// Add BoxCollider istrigger on the parent object, a little larger than the object



public class WoodResource : MonoBehaviour
{

    public bool callOnce = true;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AIWorker" && callOnce)
        {
            Debug.Log("AI worker picking up wood");
            callOnce = false;

            EventManager.TriggerEvent("ArrivedAtWoodResource");

            // reset callOnce in the WoodHarvest script
        }
    }

}
