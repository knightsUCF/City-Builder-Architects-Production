using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

Great this works, but need to wait to start building
until the worker gets there

We instantiate the first stage, and we should make that semi
transparant until the worker gets there

In LOTR there is a percentage

so somehow we need to tie this in to the specific worker


So we basically have to get the currently selected worker

MouseManager will have the currently selected worker ID

MouseManager.currentlySelectedWorkerID

when cleared the ID will be -1

So now we have the currently selected worker ID

we could check in update if the worker arrives but this might be slow

using events might be better


so basically if the worker arrives at the building, with the matching ID
then we want to send out an event to start building

and also use that event for the worker to stop and start building (they are already building when they stop,
but we want them to take out their hammer when they are building)

needs a rigid body for on collision enter to work!



*/


public class HouseBuilding : MonoBehaviour
{

    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;

    GameObject go;

    bool startedStageGrowth = false;

    private Build build;
    private MouseManager mm;
    private Worker2 workerScript;

    private EventManager events;
    // events.EventEndBuilding();


    public int workerIDWhoStartedThisBuilding = -1;

    bool workerEnteredBuildingPerimeter = false;

    



    void HasWorkerArrivedAtDestination()
    {

    }


    void Awake()
    {
        build = FindObjectOfType<Build>();
        mm = FindObjectOfType<MouseManager>();
        events = FindObjectOfType<EventManager>();
    }


    


    void Start()
    {
    

        workerIDWhoStartedThisBuilding = mm.currentlySelectedWorkerID;

        // Debug.Log("Worker ID: " + workerIDWhoStartedThisBuilding);
        // gameObject.transform.position
        // Vector3 startPos = gameObject.transform.position;
        // startPos.y = startPos.y + 1.0f;
        go = Instantiate(Stage1, gameObject.transform.position, Quaternion.identity, this.transform);
        // StartCoroutine(GrowToStage2());
    }



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Worker")
        {
            Debug.Log("detecting collision");
            Debug.Log("col.gameObject.GetComponent<Worker2>().ID: " + col.gameObject.GetComponent<Worker2>().ID);
            Debug.Log("workerIDWhoStartedThisBuilding: " + workerIDWhoStartedThisBuilding);

            if (col.gameObject.GetComponent<Worker2>().ID == workerIDWhoStartedThisBuilding)
            {
                Debug.Log("Worker with tagged ID entered building perimeter");
                workerEnteredBuildingPerimeter = true;
            }
        }
    }


    // From a script write this to add the "listener" of the event:

    /*
    void OnEnable ()
    {
        EventManager.workerArrivedAtBuilding += WorkerArrived;
    }

    void OnDisable()
    {
        EventManager.workerArrivedAtBuilding -= WorkerArrived;
    }
    */



    void Update()
    {
        if (build.setDownStartingBuilding == true && startedStageGrowth == false)
        {
            startedStageGrowth = true;
            build.setDownStartingBuilding = false; // be kind, rewind
        }

        if (startedStageGrowth == true && workerEnteredBuildingPerimeter == true)
        {
            Debug.Log("worker entered building perimeter");
            StartCoroutine(GrowToStage2());

            // also send out an event to the worker to start the building animation

            // EventManager.workerArrivedAtBuilding();
            // EventManager.EventWorkerArrivedAtBuilding();

            events.EventWorkerArrivedAtBuilding();
   

            


            // also will need to at the end send out an event to the worker to stop building when done
        }
        Debug.Log("started stage growth: " + startedStageGrowth);
        Debug.Log("worker entered building perimeter: " + workerEnteredBuildingPerimeter); 
    }



    IEnumerator GrowToStage2()
    {
        yield return new WaitForSeconds(Settings.buildTime);

        Destroy(go);
        go = Instantiate(Stage2, gameObject.transform.position, Quaternion.identity, this.transform);
        StartCoroutine(GrowToStage3());
    }



    IEnumerator GrowToStage3()
    {
        yield return new WaitForSeconds(Settings.buildTime);

        Destroy(go);
        go = Instantiate(Stage3, gameObject.transform.position, Quaternion.identity, this.transform);
        StartCoroutine(GrowToStage4());
    }



    IEnumerator GrowToStage4()
    {
        yield return new WaitForSeconds(Settings.buildTime);
        
        Destroy(go);
        go = Instantiate(Stage4, gameObject.transform.position, Quaternion.identity, this.transform);
    }

    
}
