using UnityEngine;
using System.Collections;



/*

Creating selection box:


Create parent, zero out transform
Create child Quad, flat down, with y above the ground to avoid z fighting
Take selection box graphic and drag to albedo box on the left, on the material



*/


public class MouseManager : MonoBehaviour
{

    public GameObject selectedObject;
    Worker2 workerScript;


    public int currentlySelectedWorkerID = -1;


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.transform.gameObject.tag == "Worker")
                {
                    GameObject hitObject = hitInfo.transform.gameObject;
                    Debug.Log(hitInfo.transform.gameObject);
                    SelectObject(hitObject);
                }
            }
            
            else ClearSelection();

        }
        
    }



    void SelectObject(GameObject obj)
    {
        if (selectedObject != null) // if we already have the selected object we don't have to do anything
        {
            if (obj == selectedObject)
                return;
            ClearSelection(); // otherwise clear the previous selection, 12:48 of Quill video
        }
        selectedObject = obj;

        workerScript = selectedObject.GetComponent<Worker2>();
        workerScript.isSelected = true;
        currentlySelectedWorkerID = workerScript.ID;

        // here is where we affect the image of the selected object

        // selectionBox.SetActive(true);


    }



    void ClearSelection()
    {
        workerScript = selectedObject.GetComponent<Worker2>();
        workerScript.isSelected = false;
        currentlySelectedWorkerID = -1;

        selectedObject = null;
        // selectedObject.SetSelectedState();
        // selectionBox.SetActive(false);
    }
    
}


// Quill video: https://www.youtube.com/watch?v=OOkVADKo0IM

