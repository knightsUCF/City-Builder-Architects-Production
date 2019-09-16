using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;





/*
Brackey's Animated Character Navmesh tutorial: https://www.youtube.com/watch?v=blPglabGueM

if the character is in a crouching position, this is most likely because there is no proper contact with the nav mesh surface

1. adjust the ground to 0.1 for y positioning, and 0.01 for y scale of ground.
2. Also try setting the ground check distance to 0.2


// rename this class from SimController to MoveSim

Use:




Move(Vector3 destination) - send an agent to a vector position. make sure the component is level with terrain

MoveToMouseClick() - moves the agent to where the user clicks

StopAgentOnArrival() - stops agent velocity and movement when they reach their destination



*/








public class SimController : MonoBehaviour
{
    public Camera camera;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character; // drag third person character script on the object to the slot

    bool checkForStop = false;



    void Start()
    {
        agent.updateRotation = false; // rotation handled by ThirdPersonCharacter
    }



    void Update()
    {
        if (checkForStop) StopAgentOnArrival(); // continuously get updated position to check when to stop, we can probably turn this off with a flag, so this does not run on every frame. if agentInProgress flag, when we reach zero we stop checking until the next move command
    }



    public void Move(Vector3 destination)
    {
        agent.SetDestination(destination);
    }



    public void MoveToMouseClick()
    {
        checkForStop = true; // turn on the check for stop flag, so we begin to check on everyupdate frame if the agent has arrived, at the end of this action we turn check for stop back to false, so we are not checking every update frame needlessly
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)) agent.SetDestination(hit.point);
        }
    }



    void StopAgentOnArrival()
    {
        if (agent.remainingDistance > agent.stoppingDistance) character.Move(agent.desiredVelocity, false, false); // crouch = false, jump = false
        else
        {
            character.Move(Vector3.zero, false, false); // stop moving
            checkForStop = false;
        }
    }



    

}
