using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;








public class Worker : MonoBehaviour
{

    
    NavMeshAgent agent;
    Ray ray;
    RaycastHit hitInfo;
    RaycastHit hitInfoForThisWorker;
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
    bool InRoute = false;



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
        RevealBuildMenu,
        Walk
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


    /*
    void DistanceGreaterThanCurrentLocation()
    {
        if (distanceOfClickedPoint > Location)
        {
            MoveWorker()
        }
    }
    */

    // last hitInfo.point

    float GetDistanceFromDestination()
    {
        // if (mm.currentlySelectedWorkerID == ID)
        // {

        // }
        // return Vector3.Distance(this.transform.position, hitInfo.point);
        return Vector3.Distance(this.transform.position, hitInfoForThisWorker.point);
    }


    // bool weirdFirstTimeDistanceReturn = true;

    /*
    void MoveWorker()
    {
        // will need something to toggle mouse movement off and on based on some conditions, such as clicking on the game menu

        // if (Input.GetMouseButtonDown(0) && clickedOnWorker == false && isSelected == true && mm.currentlySelectedWorkerID == ID) // not sure why we need both isSelected and to compare worker IDs, // state build prevents moving worker when building && state != State.Build) // state != State.RevealBuildMenu)
        if (Input.GetMouseButtonDown(0) && mm.currentlySelectedWorkerID == ID) // not sure why we need both isSelected and to compare worker IDs, // state build prevents moving worker when building && state != State.Build) // state != State.RevealBuildMenu)
        {
            // Debug.Log(GetDistanceFromDestination()); // why does this return 0.08 the first time?!
            // Debug.Log(this.transform.position);
            // if (weirdFirstTimeDistanceReturn || GetDistanceFromDestination() > 3.0) // no clue
            // {
                Debug.Log(GetDistanceFromDestination());
                state = State.Walk;
                InRoute = true;
                SetDestination();
                // weirdFirstTimeDistanceReturn = false;
            // }
        }
    }
    */



    void MoveWorker()
    {
        if (Input.GetMouseButtonDown(0) && mm.currentlySelectedWorkerID == ID)
        {
            state = State.Walk;
            InRoute = true;
            SetDestination();
        }
    }



    void SetDestination()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.transform.gameObject.tag != "Worker" && hitInfo.transform.gameObject.tag != "Building") // prevent still moving to another worker spot, when the user is actually trying to switch workers
            {
                agent.destination = hitInfo.point;
                hitInfoForThisWorker.point = hitInfo.point;
            }
        }
    }

    // Vector3 maxVelocity = new Vector3(1.0f, 1.0f, 1.0f);


    /*
    void HackyFixForMovement()
    {
        // Debug.Log(agent.velocity);
        
        if (agent.velocity.x < 1.0f &&
            agent.velocity.y < 1.0f &&
            agent.velocity.z < 1.0f &&
            InRoute)
        {
            state = State.Idle;
        }
    }
    */


    /*
    Vector3 previousVelocity = Vector3.zero;
    Vector3 currentVelocity = Vector3.zero;

    
    void HackyFixForMovement()
    {
        if (state == State.Walk)
        {
            currentVelocity = agent.velocity;

            if (currentVelocity.Distance < previousVelocity.Distance && currentVelocity == Vector3.zero)
            {
                state = State.Idle;
            }

            if (currentVelocity != previousVelocity)
            {
                previousVelocity = currentVelocity;
            }
        }
        */
        

        /*
        if (state == State.Walk && speed < 0.01)
        {
            state = State.Idle;
        }

        if (state == State.Walk) //  && agent.velocity == Vector3.zero)
        {
            // state = State.Idle;
            // Debug.Log(agent.velocity);
            Debug.Log(this.transform.position);
        }
        */
    // }


    void CheckIfArrived()
    {
        if (InRoute)
        {
            // Debug.Log(GetDistanceFromDestination());

            if (GetDistanceFromDestination() < 3.0)
            {
                // arrived
                agent.destination = this.transform.position; // break agent navigation if we arrive within perimeter of destination
                state = State.Idle;
                InRoute = false;
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
                // agent.velocity = Vector3.zero;
                anim.Play("idle");

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

            case State.Walk:
                anim.Play("walk");
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

        CheckIfArrived(); // only runs when bool is set to InRoute

        // HackyFixForMovement();

        // CheckWhetherWorkerArrived();

        // GetCurrentPos();

        // GetDistanceFromDestination();
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



    



    void GetDistanceFromDestination2()
    {
        distance = Vector3.Distance(this.transform.position, hitInfo.point);
        // Debug.Log(distance);

        // the stopping distance should also be affected if there are other agents nearby, so we don't keep walking just to take
        // their spot when many are selected

        if (distance < 1) // && state == State.InProgress) // && runOnce == false) 
        {
            // Debug.Log("REACHED DESTINATION!");
            // agent.velocity = Vector3.zero;

            // velocityVector = Vector3.Lerp(agent.velocity, Vector3.zero, timer);
            // timer -= Time.deltaTime*durationOfLerp;

            // agent.velocity = velocityVector;

            

            // anim.Play("idle");

            // state = State.ReachedDestination; // previous one, now we are going to go straight to build, which will need an intermediate check
            // ... to determine whether we are building, or just arriving at a positional destination

            // state = State.Build;

            state = State.Idle;

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
