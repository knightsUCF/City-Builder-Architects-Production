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



public class AgentControl : MonoBehaviour
{
    public Transform home;
    NavMeshAgent agent;


    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(home.position);
    }
}
