using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class SimMovementControls : MonoBehaviour
{


    UnityEngine.AI.NavMeshAgent agent;
    Animator anim;

    BuildingRequirements buildingRequirements;

    public GameObject sim;

    // public ThirdPersonCharacter thirdPersonCharacter;
    

    
    void Awake()
    {
        agent = this.GetComponent<NavMeshAgent>();
        anim = this.GetComponent<Animator>();

        // thirdPersonCharacter = GetComponent<PathController>();
        buildingRequirements = GetComponent<BuildingRequirements>();


        // sim.SetActive(false); // let's just turn off the rigid body for now
    }


    void OnEnable()
    {
        EventManager.StartListening("PlacedHouse", PlacedHouseEvent);
    }


    void OnDisable()
    {
        EventManager.StopListening("PlacedHouse", PlacedHouseEvent);
    }



    void Start()
    {
        // anim.Play("Walk");
        // Vector3 destination;
        
        // destination = agent.transform.position;


        // destination.x += 2.00f;


        // agent.destination = destination;

        Vector3 pos = agent.transform.position;
        pos.y = 2.5f;

        agent.destination = pos;
       
    }


    // this should probably be in a different sim controller, this one is just for movement
    // maybe a sim initalization type one

    void PlacedHouseEvent()
    {
        // sim.SetActive(true); // so the sim doesn't fall over when we are moving the house before finalizing building
        // what if we just turn off the rigid body for now
    }





}
