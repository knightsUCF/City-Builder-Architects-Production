using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class WoodHarvesting : MonoBehaviour
{
    // place this on the worker object, AI might also get a copy of this
    // since each worker will have a copy of this, we don't have to worry about worker IDs... not entirely...


    public Vector3 woodPos;
    public Vector3 lumberMillPos;

    public Vector3 workerDestinationPos;

    bool arrived = false;

    public Vector3 destination; // toggled between woodPos and lumberMillPos, start off with woodPos

    bool arriving = false;


    // Worker worker; // will need to get worker by ID in the future like in the MouseManager object script, where we do obj.

    bool toggle = false;



    public GameObject workerGO;
    Worker worker;
    Tokens tokens;


    public float distanceFromDestination;


    public bool carryingWood = false;

    public GameObject wood;

    /*

    we will need to find the nearest lumberMillPos to the woodPos

    For example:


    if the player selects a worker and begins to chop wood closer to another lumber mill,
    then that worker will want to return wood to the new lumber mill that is closer there 
    
    */



    // so once we know the woodPos and the lumberMillPos,
    // we will simply have the worker move between the two positions, and wait a set amount of time
    // at the lumberMillPos to simulate chopping wood
    // we can do this with the invoke function



    // let's just chop wood for now like they are infinite resources



    /*
    
    So for now let's detect if the player taps or clicks on the collider of the main forest

    Then if we touch a collider, let's get that location, that's where we will send the worker to

    The worker will get stopped at the edge of the forest

    Once they stop there, that's there chopping wood spot


    Okay, so now we have the tree location spot that is part of the tree resources



    (the way we did this was set up an is trigger collider and placed around the tree area, with a Tree Resources tag, the Mouse Manager takes care of the rest)

    
    For now let's pretend the lumber mill requirement has already been met

    All we want to do is move the worker between the tree clicked area and the lumber mill
    


    So let's have an event here that waits for a lumber mill to be established

    Then this method will set the vector position of the lumber mill position to this

    Of course, in the future we will want to establish the closest lumber mill

    But let's just do one element each for now to keep things simple

    
    */



    void Awake()
    {
        tokens = FindObjectOfType<Tokens>();
        // worker = workerGO.GetComponent<Worker>();
    }


    void OnEnable()
    {
        EventManager.StartListening ("LumberMillEstablished", LumberMillEstablishedEvent);
        EventManager.StartListening ("SetTreeResourcePos", SetTreeResourcePosEvent);
        EventManager.StartListening ("WoodDeposited", WoodDepositedEvent);
    }



    void OnDisable()
    {
        EventManager.StopListening ("LumberMillEstablished", LumberMillEstablishedEvent);
        EventManager.StopListening ("SetTreeResourcePos", SetTreeResourcePosEvent);
        EventManager.StopListening ("WoodDeposited", WoodDepositedEvent);
    }



    void LumberMillEstablishedEvent()
    {
        GameObject lumberMill = GameObject.FindWithTag("Lumber Mill");
        lumberMillPos = lumberMill.transform.position; // get array of lumber mills, and return nearest position in the future
    
        StartWorkerHarvest();
    }


    void SetTreeResourcePosEvent()
    {
        // will need something to prevent toggling the destination back to the wood position, when the worker is already in route
        destination = woodPos;
    }


    // so now we need something to activate once both of these values are not zero

    // how about instead of waiting to find these values, we simply wait for 
    // the confirmation that the lumber mill exists when the player clicks on the trees

    // so now before the lumber mill is built, just have the worker cycle between 0,0,0
    // and some other default values as place holders


    void StartWorkerHarvest()
    {
        // we need to now somehow interact with the worker script
        // give them two cycling positions
        // so this will actually be one destination position

        // worker.MoveToVector(woodPos)
        // once arrived at woodPos, wait a moment with the invoke method

        // then turn back to lumberMillPos
    }



    // to get this.transform.position will need to place this script on the worker

    float GetDistanceFromDestination()
    {
        // Debug.Log("worker pos: " + this.transform.position);
        // Debug.Log("destination pos: " + destination);
        return Vector3.Distance(this.transform.position, destination);
    }


    bool runOnce = false;

    void CheckIfArrived()
    {
        distanceFromDestination = GetDistanceFromDestination();


        if (distanceFromDestination < 3.0 && !runOnce) // need a larger number, since we are taking the tall y into consideration of the trees
        {
            
            // Debug.Log("ARRIVED!");

            // need to Invote() wait, and chop some wood before returning

            ToggleDestinations();

            

            // destination = new Vector3(20.0f, -0.1f, 10.0f);

            // wait and then move
            worker.MoveWorker2(destination);

            if (getWood) wood.SetActive(false); // show carrying wood
            if (!getWood) wood.SetActive(true);
            
            runOnce = true;

        }
    }


    void WoodDepositedEvent()
    {
        runOnce = false; // different ways of doing this
        
        if (!getWood) Data.wood += 1;

        tokens.UpdateWood(); // change to just tokens


        wood.SetActive(false); // turn off wood since deposited
        getWood = false;
    }


    bool getWood = false;

    void ToggleDestinations()
    {
        if (toggle)
        {
            destination = woodPos;
            getWood = true;
        }

        if (!toggle) destination = lumberMillPos;
        toggle = !toggle;
    }


    // public Vector3 workerStartPos = new Vector3(0.0f, 4.0f, 0.0f);

    void Start()
    {
        destination = woodPos;

        worker = workerGO.GetComponent<Worker>();

        // workerGO.transform.position = new Vector3(0.0f, 4.0f, 0.0f);

        // Vector3 destination = new Vector3(20.0f, 0.0f, 10.0f);

        // worker.Move(destination);
    }



    void Update()
    {
        // any faster way than doing this in update?
        if (woodPos != null && lumberMillPos != null) CheckIfArrived();

        // can't we just wait to get the collider info

    }




}
