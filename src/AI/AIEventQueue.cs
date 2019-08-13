using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/* 

- can keep the tree resources as cubes, since we can place them anywhere, and just turn the mesh off

- instead of the heavy resource driven approach of each tree having a box collider, we can move the single mesh around, 
or generate the cube object at the place of the tree mining


so what do we want the AI to do?

1) well first mine some wood

2) then build a structure, an employment office

3) generate more workers at the employment office

4) have some of those workers harvest wood, and some harvest stone

5) 



The way this will work, is that we won't procede to the next event until the last event is done,

We should also clean up the events

So let's say we want to mine four tree resources, add this to list, keep track of that

And then when done erase the mine four resources from list, so we can move on to the next added event

What if we want to do concurrent events?

Hmmm, well another worker would handle that, but how will they know which worker does what?

Perhaps we can have a few dictionary lists per worker

so we could have a mechanism which generates dictionaries per worker

tasksWorker1

tasks1 belongs to worker 1
tasks2 belongs to worker 2

and so on up to the max number of workers

that is better


so we can manage tasks1 separate for worker1, we can have him keep chopping wood until we want to stop

worker 2 can do the tasks in tasks2 list, and when he's done he can just go into idle mode

we can have a seperate "master controller", which looks at all the tasks to be done, and also
delegates to idle workers

we could then also have a "master tasks list" from which we loop through pulling out tasks for workers,
which are idle,

the only thing is we would not want to pull away a worker who is working in an office
so perhaps we can set a "busy" flag on the worker, which will prevent him being assigned a task

the check if "busy" flag would happen right before we pull out from the associated tasks, list

so that could work



*/



public class AIEventQueue : MonoBehaviour
{
    
    // int - priority level, string - task

    public Dictionary<int, string> masterTasksList = new Dictionary<int, string>();
    
    public Dictionary<int, string> tasks1 = new Dictionary<int, string>();
    public Dictionary<int, string> tasks2 = new Dictionary<int, string>();
    public Dictionary<int, string> tasks3 = new Dictionary<int, string>();
    public Dictionary<int, string> tasks4 = new Dictionary<int, string>();
    public Dictionary<int, string> tasks5 = new Dictionary<int, string>();

    // add: tasks.Add(priority, task);
    // remove: tasks.Remove(priority);
    // clear: tasks.Clear();
}
