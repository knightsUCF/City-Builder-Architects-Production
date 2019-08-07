using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;








public class Worker : MonoBehaviour
{

    
    NavMeshAgent agent;
    Ray ray;
    RaycastHit hitInfo;
    private Animator anim;
    float timer;
    Vector3 velocityVector;
    float durationOfLerp = 0.1f;
    public int ID = -1;
    float distance;
    GameObject buildMenu; 
    bool buildMenuSelect = true;
    public bool isSelected = false;
    MouseManager mm;



    enum State {
        Idle,
        Build,
        MovingToResourceNode,
        GatheringResources,
        MovingToStorage,
        ReachedDestination,
        StartMoveToDestination,
        MovingTowardDestination,
        InProgress,
        RevealBuildMenu
    }

    private State state;



    void Awake()
    {
        mm = FindObjectOfType<MouseManager>();
        agent = this.GetComponent<NavMeshAgent>();
        CreateWorker();
        anim = this.GetComponent<Animator>();
        state = State.Idle;
    }


    // From a script write this to add the "listener" of the event:

    void OnEnable ()
    {
        EventManager.workerArrivedAtBuilding += WorkerArrived;
        EventManager.workerCanStartBuilding += StartBuilding;
    }

    void OnDisable()
    {
        EventManager.workerArrivedAtBuilding -= WorkerArrived;
        EventManager.workerCanStartBuilding -= StartBuilding;
    }



    void Start()
    {
        buildMenu = GameObject.Find("UI/HUD/Canvas/Build Menu");
    }

    
    public void SetSelectedState()
    {

    }


    void WorkerArrived()
    {
        state = State.ReachedDestination;
        // state = State.Build;
    }


    void StartBuilding()
    {
        state = State.Build;
    }




    bool clickedOnWorker = false;

    void OnMouseDown()
    {
 

        clickedOnWorker = true;
        // state = State.RevealBuildMenu;
        // Debug.Log("Clicking worker");
        ToggleBuildMenu();
        // state = State.InProgress;
        clickedOnWorker = false;
    }



    void CreateWorker()
    {
        Data.currentSimID += 1;
        Data.sims.Add(new Sim(Data.currentSimID, "John", 50));
        ID = Data.currentSimID;
    }



    void MoveWorker()
    {
        // will need something to toggle mouse movement off and on based on some conditions, such as clicking on the game menu

        if (Input.GetMouseButtonDown(0) && clickedOnWorker == false 
            && isSelected == true 
            && mm.currentlySelectedWorkerID == ID) // not sure why we need both isSelected and to compare worker IDs, // state build prevents moving worker when building && state != State.Build) // state != State.RevealBuildMenu)
        {
            state = State.StartMoveToDestination;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.transform.gameObject.tag != "Worker" &&
                    hitInfo.transform.gameObject.tag != "Building") // prevent still moving to another worker spot, when the user is actually trying to switch workers
                {
                    agent.destination = hitInfo.point;
                }
            }
        }

    }




    bool IsIdle()
    {
        return false;
    }


    /*
    void MoveTo(Vector3 position, float stopDistance, Action onArrivedAtPosition)
    {
        // take transform position of: woodNodeTransform
        // also set action once get to wood Transform: play the animation
        // once gold is mined move to the storageTransform.position
    }



    void PlayAnimationMine(Vector3 lookAtPosition, Action onAnimationCompleted)
    {

    }
    */


    /*
    Transform GetResourceNode()
    {
        return woodNodeTransform;
    }
    */




    


    void ManageState()
    {
        /*
        switch (state)
        {
            case State.Idle:
                woodPos = GetResourceNode();
                state = State.MovingToResourceNode;
                break;
            
            case State.MovingToResourceNode:
                if (unit.IsIdle())
                {
                    unit.MoveTo(resourceNodeTransform.position, 10f);
                    state = State.GatheringResources;
                }
                break;

            case State.GatheringResources:
                if (unit.IsIdle())
                {
                    // play animation
                }
        }
        */


        switch (state)
        {
            case State.ReachedDestination:
                
                agent.velocity = Vector3.zero;
                anim.Play("idle");
                // Debug.Log("idling");
                state = State.Idle;
                
                break;

            case State.Idle:
                agent.velocity = Vector3.zero;

                break;

            case State.StartMoveToDestination:
                state = State.MovingTowardDestination;
                break;

            case State.MovingTowardDestination:
                anim.Play("walk");
                // Debug.Log("walking");
                // so that we only play the animation once
                state = State.InProgress;
                break;

            case State.Build:
                anim.Play("build");
                // Debug.Log("building");
                // so that we only play the animation once
                // state = State.InProgress; 
                // state = State.InProgress;
                
                break;

            case State.InProgress:
                break;

            case State.RevealBuildMenu:
                break;
        }

        // currently will drop everything and move

        MoveWorker();

        // CheckWhetherWorkerArrived();

        // GetCurrentPos();

        GetDistanceFromDestination();
    }


    void CheckWhetherWorkerArrived()
    {
        if (agent.destination == hitInfo.point)
        {
            // Debug.Log("ARRIVED!");
            // set the destination here to idle

            // although when the worker arrives at a resource or building thing, their state will not be idle but building
        }
    }


    void GetCurrentPos()
    {
        Debug.Log(this.transform.position);
    }


    bool runOnce = false;

    void GetDistanceFromDestination()
    {
        distance = Vector3.Distance(this.transform.position, hitInfo.point);
        // Debug.Log(distance);

        // the stopping distance should also be affected if there are other agents nearby, so we don't keep walking just to take
        // their spot when many are selected

        if (distance < 1 && state == State.InProgress) // && runOnce == false) 
        {
            // Debug.Log("REACHED DESTINATION!");
            // agent.velocity = Vector3.zero;

            // velocityVector = Vector3.Lerp(agent.velocity, Vector3.zero, timer);
            // timer -= Time.deltaTime*durationOfLerp;

            // agent.velocity = velocityVector;

            

            // anim.Play("idle");

            // state = State.ReachedDestination; // previous one, now we are going to go straight to build, which will need an intermediate check
            // ... to determine whether we are building, or just arriving at a positional destination

            state = State.Build;
            runOnce = true;
        }
    }


    void ToggleBuildMenu()
    {
        buildMenu.SetActive(buildMenuSelect);
        buildMenuSelect = !buildMenuSelect;
    }



    void Update()
    {
        ManageState();
    }









}




// Setting up NavMesh

// https://www.youtube.com/watch?v=vK6DlWkG4po

// 1. Click on all the objects, preferrably under a parent object
// 2. Next to static, drop down and click on "navigation static" and check yes for all children
// 3. Then go to Window -> AI -> Navigation and Bake
// 4. Add component to the agents, "Nav Mesh Agent"

// For dynamic objects
// 1. Add "Nav Mesh Obstacle" component to object, will be added on prefab of buildings, and other objects that will be dynamic on the nav mesh
// 2. Check "carve"
