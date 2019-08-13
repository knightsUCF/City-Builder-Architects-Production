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


*/



public class AIEventQueue : MonoBehaviour
{
    
    // int - priority level, string - task
    
    Dictionary<int, string> tasks = new Dictionary<int, string>();



    public void Add(int priority, string task)
    {
        tasks.Add(priority, task);
    }



    public void Delete(int priority)
    {
        tasks.Remove(priority);
    }



    public void Clear()
    {
        tasks.Clear();
    }

}
