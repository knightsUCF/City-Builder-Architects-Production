using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*

Attach this to a quad or any other selection

Make sure quad is parented to a zeroed out game object, which will actually hold this script

*/


public class SelectionIndicator : MonoBehaviour
{
    MouseManager mm; 

    void Start()
    {
        mm = GameObject.FindObjectOfType<MouseManager>();
    }

 
    void Update()
    {
        if (mm.selectedObject != null)
        {
            this.transform.position = mm.selectedObject.transform.position;
            // Debug.Log(this.transform.position);
        }
        
    }
}
