using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;






public class Build : MonoBehaviour
{

    public float gridSize = 10.0f;


    // public GameObject lumberMill;
    // public GameObject stoneMill;

    
    // public for now, drag a cube in here
    public GameObject buildSelection; // will use BuildingType switch state
    GameObject GO;
    GameObject finalGO;
    
    
    Ray ray;
    Touch touch;
    Vector3 closestVector;
    RaycastHit hitInfo;


    BitBenderGames.MobileTouchCamera mobileTouchCamera;


    // do we need these
    public bool startedBuild = false;
    public bool doneBuilding = true; // set to true because normal state is not building (for moving the camera around)
    public bool setDownStartingBuilding = false; // for HouseBuilding stages
    public bool haveWePlacedFirstBuildingStage = false;


    // okay so we will definitely need this, this will be what is activate by clicking on the build button
    // 2 parts here
    // 1 - did the user click on a building structure, (after clicking on a worker)
    // 2 - what sort of structure did they click on?
    // so for now let's just build one structure, and then add building types

    public bool allowBuild = false;




    // setting current: buildingType = BuildingType.House;

    enum BuildingType {

        House,
        LumberMill,
        StoneMill

    }

    private BuildingType buildingType;



    void Awake()
    {
        // BitBenderGames
        mobileTouchCamera = FindObjectOfType<BitBenderGames.MobileTouchCamera>();
    }




    void OnEnable()
    {
        EventManager.StartListening ("BuildHouse", BuildHouseEvent);
    }



    void OnDisable()
    {
        EventManager.StopListening ("BuildHouse", BuildHouseEvent);
    }



    // temporary

    bool start = false;

    void BuildHouseEvent()
    {
        Debug.Log ("Build house event called!");
        start = true;
        PlaceStartingBuilding();
    }



    void SetBuilding()
    {
        Debug.Log("Calling Set Building");
        if (Physics.Raycast(ray, out hitInfo)) 
        {
            PlaceBuilding(hitInfo.point, buildSelection);
            // startedBuild = true; // come back to this
            // haveWePlacedFirstBuildingStage = true;
        }
    }



    void PlaceStartingBuilding()
    {


        #if UNITY_ANDROID


        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            Debug.Log("Inside touch");
            Debug.Log("touch position: " + touch.position);


            if (Physics.Raycast(ray, out hitInfo)) 
            {
                mobileTouchCamera.lockCamera = true;

                PlaceBuilding(hitInfo.point, buildSelection);
                // startedBuild = true; // come back to this
                // haveWePlacedFirstBuildingStage = true;
            }



            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("Touch phase began");
                // Debug.Log("Touch position: " + touch2.position);
            }
        }


        #endif



        /*
        #if UNITY_ANDROID
        Debug.Log("Calling PlaceStartingBuilding()");

        // stopping here

        if (Input.touchCount > 0)
        {
            Debug.Log("Reached Input.touchCount > 0");

            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);
            if (touch.phase == TouchPhase.Began) 
            {
                Debug.Log("Reached SetBuilding() Scope!!!");
                // SetBuilding();
                if (Physics.Raycast(ray, out hitInfo)) 
                {
                    PlaceBuilding(hitInfo.point, buildSelection);
                    // startedBuild = true; // come back to this
                    // haveWePlacedFirstBuildingStage = true;
                }
            }
        }

        #endif

        */

        #if UNITY_EDITOR

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        SetBuilding();

        #endif
    }



    void Example()
    {
        switch (buildingType)
        {
            case BuildingType.House:
                
                // commands
                break;

            case BuildingType.LumberMill:
                // commands
                break;
        }
    }



    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;
        int xCount = Mathf.RoundToInt(position.x / gridSize);
        int zCount = Mathf.RoundToInt(position.z / gridSize);
        int yCount = 0;
        closestVector = new Vector3((float)xCount * gridSize, (float)yCount, (float)zCount * gridSize);
        closestVector += transform.position;
        return closestVector;
    }



    Vector2 PlaceBuilding(Vector3 clickPoint, GameObject gameObject)
    {
        Debug.Log("Calling Place Building!!!");
        var finalPosition = GetNearestPointOnGrid(clickPoint);
        GO = Instantiate(gameObject, finalPosition, Quaternion.identity, this.transform);
        Debug.Log("Instantiating GO object");
        return (Vector2)finalPosition;
    }



    void MoveBuildingToDragPoint()
    {
        if (Physics.Raycast(ray, out hitInfo))
        {
            var gridPos = GetNearestPointOnGrid(hitInfo.point);
            GO.transform.position = gridPos;

        }
    }



    void DragBuilding()
    {
        #if UNITY_ANDROID

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);
            // if (touch.phase == TouchPhase.Began) MoveBuildingToDragPoint();
            if (GO != null) MoveBuildingToDragPoint();


            // this will finalize the building no matter where we double tap

            if(Input.touches[0].tapCount == 2)
            {
                Debug.Log("double tapped!");
                FinalizeBuilding(buildSelection);
                mobileTouchCamera.lockCamera = false;
            } 


            // if (double tap) FinalizeBuilding(buildSelection);
        }
  
        #endif

        #if UNITY_EDITOR || UNITY_STANDALONE_OSX

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        MoveBuildingToDragPoint();
        
        if (Input.GetMouseButtonDown(0)) FinalizeBuilding(buildSelection); // for desktop we finalize building by clicking - we could also tap for the mobile version
        if (Input.GetMouseButtonDown(1)) DestroyBuilding(); // cancel

        #endif       
    }



    void FinalizeBuilding(GameObject gameObject)
    {
        Vector3 finalizedPosition; // not to be confused with finalPosition
        finalizedPosition = GO.transform.position;
        Destroy(GO);

        finalGO = (GameObject)Instantiate(gameObject, finalizedPosition, Quaternion.identity, this.transform);
        
        start = false;
    }



    // non mobile?

    void CancelBuildingNonMobile()
    {
        Destroy(GO);
        allowBuild = false;
        startedBuild = false;
    }



    public void DestroyBuilding()
    {
        Destroy(GO);
    }



    void Update()
    {
        if (start) DragBuilding();
    }



}
