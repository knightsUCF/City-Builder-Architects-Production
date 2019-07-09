using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class BuildMobile : MonoBehaviour
{
    
    // settings

    public float size = 10.0f;


    // variables

    bool isLastObjectInProgress = false;


    // prefabs

    public GameObject roadStartStage;
    public GameObject roadEndStage;

    GameObject GO;


    // structure type

    enum StructureSelection
    {
        none,
        skyscraper1,
        road,
        tree,
        house
    }

    StructureSelection structureSelection;



    void Start()
    {
        structureSelection = StructureSelection.road;
    }



    void LateUpdate()
    {
        if (structureSelection == StructureSelection.road) BuildSelection(roadStartStage, roadEndStage);
    }

    

    bool CanBuild()
    {
        // later need to separate conditions just for building cost to warn user we are out of funds
        if (Data.tokens >= Settings.BuildingCost && !isLastObjectInProgress) return true;
        else
        {
            return false;
        }
    }



    Vector2 PlaceStructure(Vector3 clickPoint, GameObject gameObject)
    {
        Debug.Log("attempting to place structure");
        var finalPosition = GetNearestPointOnGrid(clickPoint);
        GO = (GameObject)Instantiate(gameObject, finalPosition, Quaternion.identity, this.transform);
        isLastObjectInProgress = true;
        return (Vector2)finalPosition;
    }



    void FollowMouseAround(GameObject gameObject)
    {
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            var gridPos = GetNearestPointOnGrid(hitInfo.point);
            gameObject.transform.position = gridPos;
            IsBuildingAreaFree();
        }
    }



    void FinalizeBuilding(GameObject gameObject)
    {
        Vector3 finalizedPosition; // not to be confused with finalPosition
        finalizedPosition = GO.transform.position;
        Destroy(GO);
        GO = (GameObject)Instantiate(gameObject, finalizedPosition, Quaternion.identity, this.transform);
        isLastObjectInProgress = false; // perhaps a better name for this, we are just resetting the queue
    }



    void BuildSelection(GameObject startStage, GameObject endStage)
    {
        if (!isLastObjectInProgress)
        {
            if (CanBuild()) // only check if we can build once we press the mouse instead of every frame rate
            {
                // Debug.Log("Can build"); // reaching here
                RaycastHit hitInfo;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Debug.Log(Input.mousePosition);
                if (Physics.Raycast(ray, out hitInfo))
                {
                    // not reaching here
                    Debug.Log("Reached place structure scope");
                    PlaceStructure(hitInfo.point, startStage);
                }
            }
        }
        
        if (isLastObjectInProgress) // we still want to move the last object around, even if we run out of money so don't place inside CanBuild() scope
        {
            FollowMouseAround(GO);
            if (Input.GetMouseButtonDown(0)) // wait for finalization on click
            {
                FinalizeBuilding(endStage);
                Data.tokens -= Settings.BuildingCost; // subtract money after we build -- later we will need to subtract funds based on the type of building
                // structureSelection = StructureSelection.none; // if we want to keep building we will not reset to none, not sure how to handle this yet
            }
            // we will need to reset isLastObjectInProgress since we will only be able to build one building
        }
        if (Input.GetMouseButtonDown(1))
        {
            structureSelection = StructureSelection.none;
            Destroy(GO);
            isLastObjectInProgress = false;
        }
    }



    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        // perhaps we can set the y position to ground level - zero or something - if we have elevation later, we can pass the y coordinate

        int xCount = Mathf.RoundToInt(position.x / size);
        // int yCount = Mathf.RoundToInt(position.y / size);
        int zCount = Mathf.RoundToInt(position.z / size);

        // this could have worked... ?

        int yCount = 0;

        // the only problem now is we're getting flashing when the camera is too close to the ground
        // simple solution - move the camera way a little

        // current building dimensions are x 10, y 50, x 10

        // let's keep things in multiples of 10,
        // so if we want to make the building larger later on, let's set to 100
        // or alternatively make the trees and other stuff smaller,
        // in any case need for the camera to be zoomed away some threshold distance to prevent flashing

        Vector3 result = new Vector3(
            (float)xCount * size,
            // can we just fix the y position?

            (float)yCount,
            // (float)yCount * size, // possibly flashing -- trying to get height -- unwanted
            (float)zCount * size);

        result += transform.position;

        return result;
    }



    void IsBuildingAreaFree()
    {
        // so we will be checking on collisions when we are following the mouse around
    }





}
