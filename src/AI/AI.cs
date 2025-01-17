using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class AI : MonoBehaviour
{


    public GameObject workerAIprefab;
    public Vector3 worker1StartPos = new Vector3(50.0f, 0.0f, -20.0f);
    // public Vector3 worker1StartPos = new Vector3(0.0f, 4.0f, 0.0f);

    // WorkerAI worker;


    GameObject worker1;
    GameObject worker2;


    public GameObject employmentOfficePrefab;
    public GameObject lumberMillPrefab;
    public GameObject housePrefab;
    // public GameObject storePrefab;




    // these will be globally recycled for each new structure

    Vector3 lumberMillBuildSpotPos;
    Vector3 employmentOfficeBuildSpotPos;
    Vector3 houseBuildSpotPos;




    public List<string> TaskList = new List<string>();


    AILog aiLog;





    void OnEnable()
    {
        EventManager.StartListening("ReachedLumberMillBuildSpot", ReachedLumberMillBuildSpotEvent);
        EventManager.StartListening("LumberMillBuilt", LumberMillBuiltEvent);

        EventManager.StartListening("ReachedEmploymentOfficeBuildSpot", ReachedEmploymentOfficeBuildSpotEvent);
        // EventManager.StartListening("EmploymentOfficeBuilt", EmploymentOfficeBuiltEvent);

        EventManager.StartListening("ReachedHouseBuildSpot", ReachedHouseBuildSpotEvent);


    }



    void OnDisable()
    {
        EventManager.StopListening("ReachedLumberMillBuildSpot", ReachedLumberMillBuildSpotEvent);
        EventManager.StopListening("LumberMillBuilt", LumberMillBuiltEvent);

        EventManager.StopListening("ReachedEmploymentOfficeBuildSpot", ReachedEmploymentOfficeBuildSpotEvent);
        // EventManager.StopListening("EmploymentOfficeBuilt", EmploymentOfficeBuiltEvent);

        // EventManager.StopListening ("BuildHouse", BuildHouseEvent);

        EventManager.StopListening("ReachedHouseBuildSpot", ReachedHouseBuildSpotEvent);
    }



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

        // Debug.Log("Worked arrived!");
        Vector3 buildLocation = new Vector3(this.transform.position.x + 35, this.transform.position.y, this.transform.position.z + 4);
        // Build(employmentOffice, buildLocation);

        // GoBuild();

    }


    void EmploymentOfficeFinishedBuilding()
    {
        // here we need to get the employment's office position

        // GameObject employmentOfficeForPos = GameObject.FindWithTag("EmploymentOfficeAI");
        // Vector3 spawnPos = employmentOffice.transform.position;
        // spawnPos.x += 10.0f;
        // figure out a way to spawn consistently in front of the employment office, this might just be a constant offset depending on the building's rotation
        // later the AI might want to rotate the building, and then the spawn will rotate also
        // in that case create a spawn point simple cube marker attached to the employment office, do that soon
        // so that way when the building is rotate so is the cube marker
        // and we simply then just spawn the worker at the cube marker, unless something is in front, fine to spawn near sidewalk, but okay to spawn in the middle of traffic
        
        // GenerateWorker(spawnPos); 
    }

    // create an event that when the employment office is built (place into the start method of the AI employment office)
    // then create a new AI worker so they can begin self replicating



    void Awake()
    {
        // workerAIcode = FindObjectOfType<WorkerAI>();

        aiLog = FindObjectOfType<AILog>(); 

    }



    GameObject GenerateWorker(Vector3 startPos)
    {
        GameObject workerGO = (GameObject)Instantiate(workerAIprefab, startPos, Quaternion.identity, this.transform);
        return workerGO;
    }



    // let's simply have the worker simple move to a location and build and employment office

    // so the destination of the worker is decoupled, let's simply move the worker there, and then spawn the employment office next to them
    // let's not worry about building stages for now


    



    public GameObject positionEventCollider; 




    void GenerateTwoStartingWorkers()
    {
        Vector3 worker1StartPos = new Vector3(-247.0f, -0.1f, -40.0f);
        Vector3 worker2StartPos = new Vector3(-227.0f, -0.1f, -58.0f);

        worker1 = GenerateWorker(worker1StartPos);
        worker2 = GenerateWorker(worker2StartPos);

        aiLog.LogText("generating two starting workers");
    }



    void Build(GameObject building, Vector3 pos)
    {
        GameObject buildingGO = Instantiate(building, pos, Quaternion.identity, this.transform);
    }



    void ReachedLumberMillBuildSpotEvent()
    {
        Build(lumberMillPrefab, lumberMillBuildSpotPos);

    }



    void LumberMillBuiltEvent()
    {
        HarvestLumber(worker1);
        aiLog.LogText("built lumber mill"); // might have to move over to event once wait time is introduced
    }



    void BuildLumberMill(GameObject worker)
    {
        WorkerAI Worker1 = worker.GetComponent<WorkerAI>();
        lumberMillBuildSpotPos = new Vector3(-188.0f, -0.1f, -50.0f); // we will need to generate a trigger collider at that position so we can send out an event
        GameObject lumberMillMarker = Instantiate(positionEventCollider, lumberMillBuildSpotPos, Quaternion.identity, this.transform);
        PositionEventCollider pec = lumberMillMarker.GetComponent<PositionEventCollider>();
        pec.eventName = "ReachedLumberMillBuildSpot";
        Worker1.Move(lumberMillBuildSpotPos); // when a worker gets there we will be able to get the event
        // they begin building with the ReachedLumberBillSpotEvent()

        // GameObject lumberMill = Instantiate(lumberMillPrefab, lumberMillBuildSpotPos, Quaternion.identity, this.transform);
    }



    void HarvestLumber(GameObject worker)
    {
        worker.GetComponent<WoodHarvestingAI>().enabled = true;
    }



    void StopHarvestingLumber(GameObject worker)
    {
        worker.GetComponent<WoodHarvestingAI>().enabled = false;
    }



    void BuildEmploymentOffice(GameObject worker)
    {


       // Build(GameObject building, Vector3 pos)

        WorkerAI Worker2 = worker.GetComponent<WorkerAI>();
        employmentOfficeBuildSpotPos = new Vector3(-259.0f, -0.1f, -33.0f); // we will need to generate a trigger collider at that position so we can send out an event
        GameObject employmentOfficeMarker = Instantiate(positionEventCollider, employmentOfficeBuildSpotPos, Quaternion.identity, this.transform);
        PositionEventCollider pec = employmentOfficeMarker.GetComponent<PositionEventCollider>();
        pec.eventName = "ReachedEmploymentOfficeBuildSpot";
        Worker2.Move(employmentOfficeBuildSpotPos); // when a worker gets there we will be able to get the event
        // they begin building with the ReachedLumberBillSpotEvent()
    }



    void ReachedEmploymentOfficeBuildSpotEvent()
    {
        Build(employmentOfficePrefab, employmentOfficeBuildSpotPos);
        aiLog.LogText("built employment office"); // might have to move over to event once wait time is introduced
    }



    void BuildHouse(GameObject worker)
    {


       // Build(GameObject building, Vector3 pos)

        WorkerAI Worker2 = worker.GetComponent<WorkerAI>();
        houseBuildSpotPos = new Vector3(-255.0f, -0.1f, -73.0f); // we will need to generate a trigger collider at that position so we can send out an event
        GameObject houseMarker = Instantiate(positionEventCollider, houseBuildSpotPos, Quaternion.identity, this.transform);
        PositionEventCollider pec = houseMarker.GetComponent<PositionEventCollider>();
        pec.eventName = "ReachedHouseBuildSpot";
        Worker2.Move(houseBuildSpotPos); // when a worker gets there we will be able to get the event
        // they begin building with the ReachedLumberBillSpotEvent()
    }



    void ReachedHouseBuildSpotEvent()
    {
        // Build(housePrefab, houseBuildSpotPos);
    }


    

    void StartBuildingSimulation()
    {

        GenerateTwoStartingWorkers();

        BuildLumberMill(worker1); // calls LumberMillBuiltEvent(), which calls HarvesLumber(worker)

        BuildEmploymentOffice(worker2);

        // BuildHouse(worker2); // interferes with BuildEmploymentOffice(), need to wait or something, maybe the position marker is giving both signals at the same time

        // BuildStore(worker2);

        // build a house at -255, -0.1, -73 - we should wait until a worker is free, perhaps we can toggle a free worker state, after they're done with the employment office

        // so if the worker enters the building area and starts building, we can set the flag as busy, and then set the flag as free when the building is done (in the awake() method for now)

        // build a store at: -243, -0.1, -8




        








        // Build(GameObject building, Vector3 pos)






        // to start harvesting: worker4AIGameObject.GetComponent<WoodHarvestingAI>().enabled = true;


        // to check if collected enough wood to go do something else

        // InvokeRepeating("IfCollected4Wood", 0, 1.0f); // run once per second

        // then use IfCollected4Wood()

    }




    
    void Start()
    {
        StartBuildingSimulation();

        // GameObject workerAIgameObject = GenerateWorker(worker1StartPos);
        // GameObject worker2AIGameObject = GenerateWorker(new Vector3(0.0f, 10.0f, 0.0f));
        // GameObject worker3AIGameObject = GenerateWorker(new Vector3(0.0f, 20.0f, 0.0f));
        
        
        // GameObject worker4AIGameObject = GenerateWorker(new Vector3(-20.0f, 0.0f, 20.0f));
        
        // if we don't want the worker to harvest wood, simply take off the wood script

        // WoodHarvestingAI woodHarvestingScript = worker4AIGameObject.GetComponent<WoodHarvestingAI>();
        // Destroy(woodHarvestingScript);

        // let's add the wood harvesting script back in to test...

        // woodHarvestingScript = worker4AIGameObject.AddComponent<WoodHarvestingAI>();


        
        // similarly if we want to dole out tasks to the AI worker, we should add the appropropriate script component
        // and take off when ready

        // a better way is to enable and disable, and place the start methods in enable

        // worker4AIGameObject.GetComponent<WoodHarvestingAI>().enabled = true;


        // so let's make one worker build something

        // this will build any building game object based on the position
        // all we have to do is send the worker to that position
        // Build(GameObject building, Vector3 pos);

        // we could use Invoke to wait a little while and then send the worker

        // well we want to start with building a lumber mill

        // so what will be the general gameplay structure right now


        // start with two AI workers in idle mode

        // first idle worker position: -247, -0.1, -40
        // second idle worker position: -227, -0.1, -58

        // wait a little with the Invoke method

        // have one worker build a lumber mill -188, -0.1, -50

        // build the lumber mill at: 

        // another worker builds an employment office

        // build employment office at: -259, -0.1, -33

        // the employment office does the invoke function to generate another worker, perhaps there is some timer bar

        // the worker that finishes the employment office then builds a house

        // build a house at -255, -0.1, -73

        // the worker that comes out of the employment office gathers wood

        // the worker that finishes building a house then builds a store, and starts the commerce part,
        // which takes us to the next session

        // build a store at: -243, -0.1, -8





        // also when generating a worker, the better method would be to add the harvesting wood script instead of deleting off every worker








        // we could have the worker instance return an ID to be managed by this central AI script
        // then we can have a state machine to get the status on the worker, so perhaps take the next worker who has a state of "idle" and is closest to desired build location to build there, and then break out of that for loop once we find the first available worker
        // worker = workerAIgameObject.GetComponent<WorkerAI>();
        
        
        // InvokeRepeating("IfCollected4Wood", 0, 1.0f); // run once per second


    }



    void IfCollected4Wood()
    {
        if (TokensAI.wood == 2)
        {
            Debug.Log("Collected 2 wood!");
            CancelInvoke();
        }
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
