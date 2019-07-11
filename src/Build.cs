using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/*

okay, so we want to place an object, on a grid [ X ]

drag the object around [ X ]

finalize the object [ X ]



So now we want to create a small and simple build process


- every time the user clicks on the build icon (other than in progress build) we want to generate a new cube (build routine)

- once the user presses the finalization check we set the cube

- the checkmark and x will appear at all times when we are dragging the cube around

- once we press x we will destroy the GO cube game object

- once the process is working, the build icon will eventually be a house icon, which will be a child of the build icon





Okay, so two major things:


1) When we click on the build icon, we want to start the build routine cycle
2) If we click on the x, then we want to end the build routine cycle

What happens when the player presses the build routine cycle right after already pressing the build button?

Need a separate state button, so we only generate 1 structure at the beginning of the build routine, and then set a progress state to unfinished build routine,
so we can only create a new building once the build routine is finished

bool buildCycleRoutineFinished = false;

if the button is pressed we will send out an event which ends the current buildCycleRoutineFinished



Nitty Gritty To Do


1) when clicking the build icon intialize the state of the start of the build routine cycle
2) If we click cancel, create a listener in this Build script to destroy the game object, and set the build routine cycle to a fresh start





*/


public class Build : MonoBehaviour
{

    public float gridSize = 10.0f;
    public GameObject particle;
    RaycastHit hitInfo;
    Ray ray;
    GameObject GO;
    Touch touch;
    Vector3 result;

    // the two gatekeepers to starting a new building routine cycle
    public bool haveWePlacedFirstBuildingStage = false;
    public bool doneBuilding = true; // set to true because normal state is not building (for moving the camera around)


    // public bool newBuildCycleRoutine = false;

    // so to keep things simple, let's have the build button spawn a new object, then we will worry about concurrent objects, one thing at time

    // so the two variables to reset are: doneBuilding = false (which might have to be adjusted later for concurrent buildings), and haveWePlaceFirstBuildingStage t0 false also


    // so that works, the last thing we need to do is prevent building another building if we are still not done building





    void OnEnable ()
    {
        EventManager.endBuilding += FinalizeBuilding;
    }

    void OnDisable()
    {
        EventManager.endBuilding -= FinalizeBuilding;
    }



    void FinalizeBuilding()
    {
        doneBuilding = true;
    }


    /*
    void BuildingRoutine()
    {
        if (!doneBuilding)
        {
            if (!haveWePlacedFirstBuildingStage) SetStartingPlacement();
            DragStructureAround();
        }
    }
    */


    // so for the camera drag functionality for now, let's just activate that functionality
    // if we detect that both haveWePlacedFirstBuildingStage, and doneBuilding are both true


    void BuildingRoutine()
    {
        if (!haveWePlacedFirstBuildingStage) SetStartingPlacement();
        if (!doneBuilding && GO != null) DragStructureAround(); // hacky solution for destroyed game object but works for now
    }



    void Update()
    {
        BuildingRoutine();
    }



    void SetStartingPlacement()
    {
        doneBuilding = false;



        #if UNITY_ANDROID

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hitInfo)) 
                {
                    PlaceStructure(hitInfo.point, particle);
                    haveWePlacedFirstBuildingStage = true;
                }
            }
        }

        #endif



        #if UNITY_EDITOR

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            PlaceStructure(hitInfo.point, particle);
            haveWePlacedFirstBuildingStage = true;
        }

        #endif


        #if UNITY_STANDALONE_OSX

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            PlaceStructure(hitInfo.point, particle);
            haveWePlacedFirstBuildingStage = true;
        }

        #endif
    }



    Vector2 PlaceStructure(Vector3 clickPoint, GameObject gameObject)
    {
        var finalPosition = GetNearestPointOnGrid(clickPoint);
        GO = (GameObject)Instantiate(gameObject, finalPosition, Quaternion.identity, this.transform);
        return (Vector2)finalPosition;
    }



    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;
        int xCount = Mathf.RoundToInt(position.x / gridSize);
        int zCount = Mathf.RoundToInt(position.z / gridSize);
        int yCount = 0;
        result = new Vector3((float)xCount * gridSize, (float)yCount, (float)zCount * gridSize);
        result += transform.position;
        return result;
    }



    void DragStructureAround()
    {

        #if UNITY_ANDROID

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);
            if (Physics.Raycast(ray, out hitInfo))
            {
                var gridPos = GetNearestPointOnGrid(hitInfo.point);
                GO.transform.position = gridPos;
            }
        }

        #endif


        #if UNITY_EDITOR

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo))
        {
            var gridPos = GetNearestPointOnGrid(hitInfo.point);
            GO.transform.position = gridPos;
        }

        // for desktop we finalize building by clicking - we could also tap for the mobile version

        if (Input.GetMouseButtonDown(0))
        {
            FinalizeBuilding();
        }

        // likewise we want to cancel the building with the right click

        if (Input.GetMouseButtonDown(1))
        {
            // DestroyBuilding();
        } 

        #endif


        #if UNITY_STANDALONE_OSX

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitInfo))
        {
            var gridPos = GetNearestPointOnGrid(hitInfo.point);
            GO.transform.position = gridPos;
        }

        // for desktop we finalize building by clicking - we could also tap for the mobile version

        if (Input.GetMouseButtonDown(0))
        {
            FinalizeBuilding();
        }

        // likewise we want to cancel the building with the right click

        if (Input.GetMouseButtonDown(1))
        {
            // DestroyBuilding();
        }

        #endif

       
    }


    public void DestroyBuilding()
    {
        Destroy(GO);
    }

}
