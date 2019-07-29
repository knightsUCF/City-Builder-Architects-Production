using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// https://www.youtube.com/watch?v=vK6DlWkG4po

// 1. Click on all the objects, preferrably under a parent object
// 2. Next to static, drop down and click on "navigation static" and check yes for all children
// 3. Then go to Window -> AI -> Navigation and Bake
// 4. Add component to the agents, "Nav Mesh Agent"

// For dynamic objects
// 1. Add "Nav Mesh Obstacle" component to object, will be added on prefab of buildings, and other objects that will be dynamic on the nav mesh
// 2. Check "carve"




/*
    public Transform home;
    NavMeshAgent agent;


    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(home.position);
    }


*/


public class Worker : MonoBehaviour
{

    // UnityEngine.AI.NavMeshAgent agent;

    NavMeshAgent agent;

    public int ID = -1; // unassigned
    bool workerSelect = false;
    public GameObject workerSelection;

    Ray ray;
    RaycastHit hitInfo;


    void Start()
    {
        // agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();

        agent = this.GetComponent<NavMeshAgent>();

        Data.currentSimID += 1;
        Data.sims.Add(new Sim(Data.currentSimID, "John", 50));

        ID = Data.currentSimID;
    }


    void OnMouseDown()
    {
        Debug.Log("Clicked on worker!");
        ToggleWorkerSelection();
    }


    void ToggleWorkerSelection()
    {
        workerSelection.SetActive(workerSelect);
        workerSelect = !workerSelect;
    }


    void MoveWorker()
    {
        /*
        if (Input.GetMouseButtonDown(0)) {
                RaycastHit hit;
                
                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
                    agent.destination = hit.point;
                }
            }
        */

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
            if (Physics.Raycast(ray, out hitInfo))
            {
                agent.destination = hitInfo.point;
            }
        }

    }


    void Update()
    {
        MoveWorker();
    }


    // Next up, animating and moving agent: https://docs.unity3d.com/Manual/nav-CouplingAnimationAndNavigation.html






}
