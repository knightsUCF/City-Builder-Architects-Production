 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// We will also need some contingency checking if the lumber mill is too close to the wood, and the < 3 proximity movement gets confused



public class WoodHarvestingAI : MonoBehaviour
{

    public bool woodHarvestState = true; // eventually managed by a task list, if we have a master task list, we can simply switch on / off the wood harvesting by accessing this bool variable

    public GameObject wood;

    // dummy values

    public GameObject woodResource;
    public GameObject lumberMill;

    GameObject woodResourceGO;
    GameObject lumberMillGO;

    public Vector3 woodPos;
    public Vector3 lumberMillPos;
    public Vector3 destination; // toggled between woodPos and lumberMillPos, start off with woodPos

    WorkerAI workerAI;

    WoodResource woodResourceCode; // these will need to pick the "active" wood resource the worker is mining
    LumberMill lumberMillCode; // this will need to pick up the closest resource

    bool carryingWood = false;
    float distance;



    void Awake()
    {
        woodResourceGO = GameObject.FindGameObjectWithTag("AI Wood Resource");
        lumberMillGO = GameObject.FindGameObjectWithTag("AI Lumber Mill");
        woodResourceCode = woodResourceGO.GetComponent<WoodResource>(); // FindObjectOfType<WoodResource>();
        lumberMillCode = lumberMillGO.GetComponent<LumberMill>(); // FindObjectOfType<LumberMill>();
    }



    void OnEnable()
    {
        EventManager.StartListening ("AIWorkerArrivedAtWoodResource", AIWorkerArrivedAtWoodResourceEvent);
        EventManager.StartListening ("AIWorkerArrivedAtLumberMill", AIWorkerArrivedAtLumberMillEvent);
    }



    void OnDisable()
    {
        EventManager.StopListening ("AIWorkerWorkerArrivedAtWoodResource", AIWorkerArrivedAtWoodResourceEvent);
        EventManager.StopListening ("AIWorkerArrivedArrivedAtLumberMill", AIWorkerArrivedAtLumberMillEvent);
    }



    void AIWorkerArrivedAtWoodResourceEvent()
    {
        if (woodHarvestState)
        {
            carryingWood = true;
            destination = lumberMillPos;
            wood.SetActive(true);
            workerAI.Move(destination);
            lumberMillCode.callOnceAIWorker = true; // be kind rewind, reset the opposite destination -- any problems when they are too close?
        }
    }



    void AIWorkerArrivedAtLumberMillEvent()
    {
        if (woodHarvestState)
        {
            TokensAI.wood += 1;
            carryingWood = false;
            destination = woodPos;
            wood.SetActive(false);
            workerAI.Move(destination);
            woodResourceCode.callOnceAIWorker = true; // be kind rewind
        }
    }

    

    void Start()
    {
        workerAI = this.GetComponent<WorkerAI>();
        woodPos = woodResource.transform.position;
        lumberMillPos = lumberMill.transform.position;
        workerAI.Move(woodPos);
    }

}
