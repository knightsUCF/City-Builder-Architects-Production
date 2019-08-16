using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



// Setting up a NavMesh

// https://www.youtube.com/watch?v=vK6DlWkG4po

// 1. Click on all the objects, preferrably under a parent object
// 2. Next to static, drop down and click on "navigation static" and check yes for all children
// 3. Then go to Window -> AI -> Navigation and Bake
// 4. Add component to the agents, "Nav Mesh Agent"

// For dynamic objects
// 1. Add "Nav Mesh Obstacle" component to object, will be added on prefab of buildings, and other objects that will be dynamic on the nav mesh
// 2. Check "carve"



public class Worker : MonoBehaviour
{

    
    GameObject buildMenu;

    Ray ray;
    RaycastHit hitInfo;
    RaycastHit hitInfoForThisWorker;
    Vector3 velocityVector;
    Touch touch;
    NavMeshAgent agent;
    Animator anim;

    MouseManager mm;
    WoodHarvesting woodHarvesting; // probably have to get the one for the selected worker

    
    public int ID = -1;
    bool clickedOnWorker = false;
    float timer;
    float durationOfLerp = 0.1f;
    float distance;
    bool buildMenuSelect = true;
    public bool isSelected = false;
    bool InRoute = false;
    bool Arrived = false; // for auto pilot to know when arrived
    bool autopilot = false;



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
        anim = this.GetComponent<Animator>();
        woodHarvesting = this.GetComponent<WoodHarvesting>();

        state = State.Idle;

        CreateWorker(); // ?
    }



    void Start()
    {
        buildMenu = GameObject.Find("UI/HUD/Canvas/Build Menu"); // better to do a find by tag or name
    }



    void CreateWorker()
    {
        Data.currentSimID += 1;
        Data.sims.Add(new Sim(Data.currentSimID, "John", 50));
        ID = Data.currentSimID;
    }



    void OnMouseDown() // perhaps replace with mouse manager raycast
    {
        clickedOnWorker = true;
        ToggleBuildMenu();
        clickedOnWorker = false;
    }



    void ToggleBuildMenu()
    {
        buildMenu.SetActive(buildMenuSelect);
        buildMenuSelect = !buildMenuSelect;
    }



    float GetDistanceFromDestination()
    {
        return Vector3.Distance(this.transform.position, hitInfoForThisWorker.point);
    }



    public float GetDistanceFromAutopilotDestination()
    {
        return Vector3.Distance(this.transform.position, woodHarvesting.destination);
    }



    void CheckIfArrived()
    {
        if (InRoute && !autopilot)
        {
            if (GetDistanceFromDestination() < 3.0)
            {
                agent.destination = this.transform.position; // break agent navigation if we arrive within perimeter of destination
                state = State.Idle;
                InRoute = false;
            }
        }
    }



    public void CheckIfAutoPilotArrived()
    {
        if (InRoute && autopilot)
        {
            if (GetDistanceFromAutopilotDestination() < 3.0)
            {
                agent.destination = this.transform.position; // break agent navigation if we arrive within perimeter of destination
                state = State.Idle;
                InRoute = false;

                EventManager.TriggerEvent("WoodDeposited"); // will need more complex functionality for stone, and other cases of autopilot
            }
        }
    }



    public void MoveAutopilot(Vector3 destination)
    {
        autopilot = true;
        state = State.Walk;
        InRoute = true;
        agent.destination = destination;
    }



    void MoveWorker()
    {
        #if UNITY_EDITOR || UNITY_STANDALONE
        
        if (Input.GetMouseButtonDown(0) && mm.currentlySelectedWorkerID == ID)
        {
            state = State.Walk;
            InRoute = true;
            SetDestination();
        }

        #endif

        #if UNITY_ANDROID

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hitInfo)) 
                {
                    if (mm.currentlySelectedWorkerID == ID)
                    {
                        state = State.Walk;
                        InRoute = true;
                        SetDestination();
                    }
                }
            }
        }

        #endif
    }



    void SetDestination()
    {

        #if UNITY_EDITOR || UNITY_STANDALONE

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.transform.gameObject.tag != "Worker" && hitInfo.transform.gameObject.tag != "Building") // prevent still moving to another worker spot, when the user is actually trying to switch workers
            {
                autopilot = false;

                agent.destination = hitInfo.point;
                hitInfoForThisWorker.point = hitInfo.point;
                // Debug.Log("moving worker to: " + hitInfo.point);
            }
        }

        #endif


        #if UNITY_ANDROID

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hitInfo)) 
                {
                    if (hitInfo.transform.gameObject.tag != "Worker" && hitInfo.transform.gameObject.tag != "Building") // prevent still moving to another worker spot, when the user is actually trying to switch workers
                    {
                        autopilot = false;

                        agent.destination = hitInfo.point;
                        hitInfoForThisWorker.point = hitInfo.point;
                    }
                }
            }
        }

        #endif
    }



    void ManageState()
    {
        switch (state)
        {
            case State.ReachedDestination:
                agent.velocity = Vector3.zero;
                anim.Play("idle");
                state = State.Idle;
                break;

            case State.Idle:
                anim.Play("idle");
                break;

            case State.StartMoveToDestination:
                state = State.MovingTowardDestination;
                break;

            case State.MovingTowardDestination:
                anim.Play("walk");
                state = State.InProgress;
                break;

            case State.Walk:
                anim.Play("walk");
                break;

            case State.Build:
                anim.Play("build");
                break;

            case State.InProgress:
                break;

            case State.RevealBuildMenu:
                break;
        }

        MoveWorker();
        CheckIfArrived(); // only runs when bool is set to InRoute
        CheckIfAutoPilotArrived();
    }



    void Update()
    {
        ManageState();
    }

}

