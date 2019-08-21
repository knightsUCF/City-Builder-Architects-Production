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
    UIManager uiManager;
    WoodHarvesting woodHarvesting; // this will need to move to worker ID instance call, like the below obj.getcurrentworker.script, once we have more workers

    Ray ray;
    RaycastHit hitInfo;


    public int currentlySelectedWorkerID = -1;

    GameObject previouslySelected;

    Touch touch;



    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        woodHarvesting = FindObjectOfType<WoodHarvesting>();
    }




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



    void CheckObjectByTag()
    {
        
        if (selectedObject == null) return; 

        if (selectedObject != null)
        {
            previouslySelected = selectedObject;
        }

        if (hitInfo.transform.gameObject.tag == "Worker")
        {

            // so here if we click on a worker we will want to reveal the build menu, any worker can build even office workers

            uiManager.RevealHouseIcon();

            // find game object by tag and set to active, if workers are deselect (later since we can't deselect now, then get hide)
            selectedObject = hitInfo.transform.gameObject;
            SelectWorker(selectedObject);
            if (previouslySelected != null) DeselectWorker(previouslySelected);
        }

        if (hitInfo.transform.gameObject.tag == "Tree Resources")
        {
            // Debug.Log("Clicked on tree resources!");
            // Debug.Log("Tree location: " + hitInfo.point);

            // here we will only want to update the position if the worker is selected TODO

            woodHarvesting.woodPos = hitInfo.point;
            EventManager.TriggerEvent ("SetTreeResourcePos");
            
        }
    }




    void CheckSelection()
    {
        #if UNITY_EDITOR || UNITY_STANDALONE

        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                // Debug.Log(hitInfo.point); // to get mouse coordinates
                
                CheckObjectByTag(); // same method for any type of interface
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            // deselect all, for now we are just going to deselect the current worker
            // DeselectWorker(selectedObject);
            // DeselectWorker(previouslySelected);
        }

        #endif
        

        #if UNITY_ANDROID


        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hitInfo)) 
                {
                    CheckObjectByTag(); // same method for any type of interface
                }
            }
        }


        #endif
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
