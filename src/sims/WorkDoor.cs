using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*


1. Place on the cube, which symbolizes the entry point to the building. The cube is dragged into the workplace spot.

2. Make sure there is a box collider with is trigger checked3

3. Drag script on the cube



*/


public class WorkDoor : MonoBehaviour
{
    
    
    
    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Sim")
        {
            c.gameObject.GetComponent<SimData>().working = true;  // check later to see how many times we are calling this, probably want to call just once
            c.gameObject.SetActive(false);
        }

    }




    void OnTriggerExit(Collider c)
    {
        Debug.Log(c.tag);


        if (c.tag == "Sim")
        {
            c.gameObject.SetActive(true);
        }


        /*
        if (sim.GetComponent<SimData>().selected)
        {
        
        }
         */
    }
        



}
