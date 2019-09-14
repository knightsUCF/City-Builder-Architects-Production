using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;



// Brackey's Animated Character Navmesh tutorial: https://www.youtube.com/watch?v=blPglabGueM


/*

if the character is in a crouching position, this is most likely because there is no proper contact with the nav mesh surface


1. adjust the ground to 0.1 for y positioning, and 0.01 for y scale of ground.

2. Also try setting the ground check distance to 0.2

*/



public class SimController : MonoBehaviour
{
    public Camera camera;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character; // drag third person character script on the object to the slot


    void Start()
    {
        agent.updateRotation = false; // rotation handled by ThirdPersonCharacter
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false); // crouch = false, jump = false
        }
        
        else
        {
            character.Move(Vector3.zero, false, false); // stop moving
        }
    }
}
