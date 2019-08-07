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
    Worker workerScript;
    Ray ray;
    RaycastHit hitInfo;


    public int currentlySelectedWorkerID = -1;

    GameObject previouslySelected;




    void Update()
    {
        CheckSelection(); 
    }



    void SelectWorker(GameObject obj)
    {
        workerScript = obj.GetComponent<Worker>();
        workerScript.isSelected = true;
        currentlySelectedWorkerID = workerScript.ID;
    }



    void DeselectWorker(GameObject obj)
    {
        workerScript = obj.GetComponent<Worker>();
        workerScript.isSelected = false;
    }



    void CheckSelection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                // store reference to previously selected object so we can clear out
                if (selectedObject != null)
                {
                    previouslySelected = selectedObject;
                }

                if (hitInfo.transform.gameObject.tag == "Worker")
                {
                    selectedObject = hitInfo.transform.gameObject;
                    SelectWorker(selectedObject);
                    if (previouslySelected != null) DeselectWorker(previouslySelected);
                }
            }
        }
    }




    /*
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.transform.gameObject.tag == "Worker")
                {
                    hitObject = hitInfo.transform.gameObject;
                    Debug.Log(hitInfo.transform.gameObject);
                    SelectObject(hitObject);
                }
            }
            else ClearSelection(hitObject);
        }
    }



    void SelectObject(GameObject obj)
    {
        if (selectedObject != null) // if we already have the selected object we don't have to do anything
        {
            if (obj == selectedObject)
                return;
            ClearSelection(obj); // otherwise clear the previous selection, 12:48 of Quill video
        }
        selectedObject = obj;

        // workerScript = selectedObject.GetComponent<Worker>();
        // workerScript.isSelected = true;

        workerScript = obj.GetComponent<Worker>();
        workerScript.isSelected = true;

        currentlySelectedWorkerID = workerScript.ID;

        // here is where we affect the image of the selected object

        // selectionBox.SetActive(true);


    }



    void ClearSelection(GameObject obj)
    {
        // workerScript = selectedObject.GetComponent<Worker>();
        // workerScript.isSelected = false;

        workerScript = obj.GetComponent<Worker>();
        workerScript.isSelected = false;

        currentlySelectedWorkerID = -1;

        selectedObject = null;
        // selectedObject.SetSelectedState();
        // selectionBox.SetActive(false);
    }

    */
    
}


// Quill video: https://www.youtube.com/watch?v=OOkVADKo0IM
