using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*


1. we will want to automatically get positions of the wood and lumbermill
2. we will want to send out some sort of event when the wood is ready to be harvested
3. we will also need to connect events to the worker AI "event queue"
4. we will also need some contingency checking if the lumber mill is too close to the wood, and the < 3 proximity movement gets confused


*/



public class WoodHarvestingAI : MonoBehaviour
{

    public bool woodHarvestState = false; // eventually managed by a task list, if we have a master task list, we can simply switch on / off the wood harvesting by accessing this bool variable

    public GameObject wood;

    // dummy values for

    public GameObject woodResource;
    public GameObject lumberMill;

    public Vector3 woodPos;
    public Vector3 lumberMillPos;
    public Vector3 destination; // toggled between woodPos and lumberMillPos, start off with woodPos

    WorkerAI workerAI;

    bool carryingWood = false;
    float distance;

    


    void Start()
    {
        workerAI = this.GetComponent<WorkerAI>();

        woodPos = woodResource.transform.position;
        lumberMillPos = lumberMill.transform.position;
    }



    float GetDistanceFromDestination(Vector3 vDestination)
    {
        return Vector3.Distance(this.transform.position, vDestination);
    }


    bool sendMoveCommandOnce = true;


    void HarvestWood()
    {
        if (!carryingWood)
        {
            destination = woodPos;
        }

        if (carryingWood)
        {
            destination = lumberMillPos;
        }

        if (sendMoveCommandOnce) workerAI.Move(destination);
        sendMoveCommandOnce = false; // we should only send the pathfinding command once


        distance = GetDistanceFromDestination(destination);


        if (distance < 3.0)
        {
            if (carryingWood)
            {
                Debug.Log("Depositing wood!");
                // deposit wood
                wood.SetActive(false);
                // increment wood token data
                carryingWood = false;

                // workerAI.Move(destination);

                sendMoveCommandOnce = true; // be kind rewind
                return; // prevent going below to (!carryingWood) since we just set the state to false
            }

            if (!carryingWood)
            {
                // harvest wood
                wood.SetActive(true);
                carryingWood = true;

                //workerAI.Move(destination);

                sendMoveCommandOnce = true; // be kind rewind
            }
        }
    }



    void Update()
    {
    
        // if (woodHarvestState && woodPos != null && lumberMillPos != null) HarvestWood(); // only start once we have positions for both
    
        if (woodHarvestState) HarvestWood();
    }


}
