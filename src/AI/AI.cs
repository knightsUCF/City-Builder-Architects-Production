using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class AI : MonoBehaviour
{


    public GameObject workerAIprefab;
    public Vector3 workerStartPos = new Vector3(0.0f, 4.0f, 0.0f);
    WorkerAI worker;

    public GameObject employmentOffice;

    public List<string> TaskList = new List<string>();



    /*
    void OnEnable ()
    {
        EventManager.workerArrivedAtBuilding += WorkerArrived;
        EventManager.employmentOfficeFinishedBuilding += EmploymentOfficeFinishedBuilding;
    }

    void OnDisable()
    {
        EventManager.workerArrivedAtBuilding -= WorkerArrived;
        EventManager.employmentOfficeFinishedBuilding -= EmploymentOfficeFinishedBuilding;
    }
    */



    void WorkerArrived()
    {
        // this will be called when the workerArrivedAtBuilding event is sent out
        // we will want some more cordination with what is our task on arrival, but this will be the location arrival
        // also have to make a case when the worker gets blocked and starts building, or becomes idle at some block
        // well we will always check if we can build there, by checking if there are any objects present
        // if there is some unknown problem we can simply randomize another location and try building there

        Debug.Log("Worked arrived!");
        Vector3 buildLocation = new Vector3(this.transform.position.x + 35, this.transform.position.y, this.transform.position.z + 4);
        Build(employmentOffice, buildLocation);

        // GoBuild();

    }


    void EmploymentOfficeFinishedBuilding()
    {
        // here we need to get the employment's office position

        GameObject employmentOfficeForPos = GameObject.FindWithTag("EmploymentOfficeAI");
        Vector3 spawnPos = employmentOffice.transform.position;
        spawnPos.x += 10.0f;
        // figure out a way to spawn consistently in front of the employment office, this might just be a constant offset depending on the building's rotation
        // later the AI might want to rotate the building, and then the spawn will rotate also
        // in that case create a spawn point simple cube marker attached to the employment office, do that soon
        // so that way when the building is rotate so is the cube marker
        // and we simply then just spawn the worker at the cube marker, unless something is in front, fine to spawn near sidewalk, but okay to spawn in the middle of traffic
        
        GenerateWorker(spawnPos); 
    }

    // create an event that when the employment office is built (place into the start method of the AI employment office)
    // then create a new AI worker so they can begin self replicating








    void Awake()
    {
        // workerAIcode = FindObjectOfType<WorkerAI>();

    }



    public void MoveWorker(Vector3 destination)
    {
        // we will want to call the WorkerAI class and move a worker

        // we will need two things for this, worker ID, and also the destination

        // we should use a different starting ID point for the AI, so something past the max workers, perhaps starting after 1000
    
        // so in the scene we will have a number of workers generated under the AI

        // let's generate a few



    }



    

    

    GameObject GenerateWorker(Vector3 startPos)
    {
        GameObject workerGO = (GameObject)Instantiate(workerAIprefab, startPos, Quaternion.identity, this.transform);
        return workerGO;
    }



    // let's simply have the worker simple move to a location and build and employment office

    // so the destination of the worker is decoupled, let's simply move the worker there, and then spawn the employment office next to them
    // let's not worry about building stages for now


    void Build(GameObject building, Vector3 pos)
    {
        GameObject employmentOfficeGO = (GameObject)Instantiate(building, pos, Quaternion.identity, this.transform);
    }


    
    void Start()
    {
        GameObject workerAIgameObject = GenerateWorker(workerStartPos);
        
        // we could have the worker instance return an ID to be managed by this central AI script

        // then we can have a state machine to get the status on the worker, so perhaps take the next worker who has a state of "idle" and is closest to desired build location to build there, and then break out of that for loop once we find the first available worker


        worker = workerAIgameObject.GetComponent<WorkerAI>();

        Vector3 destination = new Vector3(20.0f, 0.0f, 10.0f);

        worker.Move(destination);
    }



    void GoBuild()
    {
        Vector3 destination = new Vector3(-5.0f, 0.0f, 10.0f);
        // moves and builds employment office
        // probably need a task list
        worker.Move(destination);
    }



    void IfStuck()
    {
        // need something to detect if we are stuck, then we should turn around and navigate elsewhere
        // if stuck we can detect this by being in one position for too long
        // in this case use the navmesh functionality to pick another spot to navigate to
    }




   



    void GoThroughTaskList()
    {
        // List TaskList
    }














    /*
    public int money = 0;
    public float timeBeforeFirstBuild = 3.0f;
    public List<int> aiWorkerIDs = new List<int>();

    public void Build(int structureID, Vector3 pos)
    {

    }


    */


    



}



/*

- change "Arrived" state bool in WorkerAI to event



*/
