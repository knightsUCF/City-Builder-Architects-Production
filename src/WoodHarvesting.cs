using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class WoodHarvesting : MonoBehaviour
{
    // place this on the worker object, AI might also get a copy of this
    // since each worker will have a copy of this, we don't have to worry about worker IDs... not entirely...


    public GameObject workerGO;

    public Vector3 woodPos;
    public Vector3 lumberMillPos;
    public Vector3 workerDestinationPos;
    public Vector3 destination; // toggled between woodPos and lumberMillPos, start off with woodPos


    // Worker worker; // will need to get worker by ID in the future like in the MouseManager object script, where we do obj.

    bool toggle = false;

    
    Worker worker;
    Tokens tokens;


    GameObject woodResourceGO;
    GameObject lumberMillGO;


    WoodResource woodResourceCode; // these will need to pick the "active" wood resource the worker is mining
    LumberMillPlayer lumberMillCode; // this will need to pick up the closest resource


    public float distanceFromDestination;


    public bool carryingWood = false;

    public GameObject wood;




    void Awake()
    {
        tokens = FindObjectOfType<Tokens>();

        woodResourceGO = GameObject.FindGameObjectWithTag("Player Wood Resource");
        woodResourceCode = woodResourceGO.GetComponent<WoodResource>(); // FindObjectOfType<WoodResource>();

        lumberMillGO = GameObject.FindGameObjectWithTag("Player Lumber Mill");
        lumberMillCode = lumberMillGO.GetComponent<LumberMillPlayer>(); // FindObjectOfType<LumberMill>();

        worker = workerGO.GetComponent<Worker>();

        lumberMillPos = lumberMillGO.transform.position;
        woodPos = woodResourceGO.transform.position;
    }



    void OnEnable()
    {
        EventManager.StartListening ("PlayerWorkerArrivedAtWoodResource", PlayerWorkerArrivedAtWoodResourceEvent);
        EventManager.StartListening ("PlayerWorkerArrivedAtLumberMill", PlayerWorkerArrivedAtLumberMillEvent);
    }



    void OnDisable()
    {
        EventManager.StopListening ("PlayerWorkerArrivedAtWoodResource", PlayerWorkerArrivedAtWoodResourceEvent);
        EventManager.StopListening ("PlayerWorkerArrivedAtLumberMill", PlayerWorkerArrivedAtLumberMillEvent);
    }



    void PlayerWorkerArrivedAtWoodResourceEvent()
    {
        carryingWood = true;
        destination = lumberMillPos;
        wood.SetActive(true);
        worker.MoveAutopilot(destination);
        lumberMillCode.callOncePlayerWorker = true; // be kind rewind
    }



    void PlayerWorkerArrivedAtLumberMillEvent()
    {
        // increment data wood tokens
        carryingWood = false;
        destination = woodPos;
        wood.SetActive(false);
        worker.MoveAutopilot(destination);
        woodResourceCode.callOncePlayerWorker = true; // be kind rewind
    }



 

}
