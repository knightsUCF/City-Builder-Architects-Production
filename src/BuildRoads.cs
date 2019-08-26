using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;






public class BuildRoads : MonoBehaviour
{

    public float gridSize = 10.0f;

    
    GameObject GO;
    GameObject finalGO;
    GameObject buildingSelection;

    public GameObject roadShort;
    public GameObject roadLong;
    public GameObject roadIntersection;
    public GameObject roadCurve;
    public GameObject road3Way;


    
    Ray ray;
    Touch touch;
    Vector3 closestVector;
    Vector3 startPos; // for positioning the starting position of a building so the structure is not "under the menu"
    RaycastHit hitInfo;

    Costs costs;
    Tutorial tutorial;
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

    bool start = false;


    bool wasFirstRoadBuilt = false; // for tutorial mode




    void Awake()
    {
        mobileTouchCamera = FindObjectOfType<BitBenderGames.MobileTouchCamera>();
        costs = FindObjectOfType<Costs>();
        tutorial = FindObjectOfType<Tutorial>();
    }



    void OnEnable()
    {
        EventManager.StartListening("BuildRoadShort", BuildRoadShortEvent);
        EventManager.StartListening("BuildRoadLong", BuildRoadLongEvent);
        EventManager.StartListening("BuildRoadIntersection", BuildRoadIntersectionEvent);
        EventManager.StartListening("BuildRoadCurve", BuildRoadCurveEvent);
        EventManager.StartListening("BuildRoad3Way", BuildRoad3WayEvent);
    }



    void OnDisable()
    {
        EventManager.StopListening("BuildRoadShort", BuildRoadShortEvent);
        EventManager.StopListening("BuildRoadLong", BuildRoadLongEvent);
        EventManager.StopListening("BuildRoadIntersection", BuildRoadIntersectionEvent);
        EventManager.StopListening("BuildRoadCurve", BuildRoadCurveEvent);
        EventManager.StopListening("BuildRoad3Way", BuildRoad3WayEvent);
    }



    void BuildRoadShortEvent()
    {
        if (costs.Purchasable(costs.roadShort)) // have this return a build to check if we can build, if this returns false, have the buildCosts do the alerting that we don't have enough funds
        {
            start = true;
            buildingSelection = roadShort; 
            PlaceStartingBuilding(roadShort);
        }        
    }



    void BuildRoadLongEvent()
    {
        if (costs.Purchasable(costs.roadLong))
        {
            start = true;
            buildingSelection = roadLong;
            PlaceStartingBuilding(roadLong);
        }
    }



    void BuildRoadIntersectionEvent()
    {
        if (costs.Purchasable(costs.roadIntersection))
        {
            start = true;
            buildingSelection = roadIntersection;
            PlaceStartingBuilding(roadIntersection); 
        }   
    }



    void BuildRoadCurveEvent()
    {   
        if (costs.Purchasable(costs.roadCurve))
        {     
            start = true;
            buildingSelection = roadCurve;
            PlaceStartingBuilding(roadCurve); 
        }       
    }



    void BuildRoad3WayEvent()
    {
        if (costs.Purchasable(costs.road3Way))
        {          
            start = true;
            buildingSelection = road3Way;
            PlaceStartingBuilding(road3Way);
        }        
    }





    void SetBuilding(GameObject structure)
    {
        if (Physics.Raycast(ray, out hitInfo)) 
        {
            PlaceBuilding(hitInfo.point, structure);
            // startedBuild = true; // come back to this
            // haveWePlacedFirstBuildingStage = true;
        }
    }



    void SetBuildingInView(GameObject structure, Vector3 pos)
    {
        PlaceBuilding(pos, structure);
    }





    void PlaceStartingBuilding(GameObject structure)
    {


        #if UNITY_ANDROID


        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (Physics.Raycast(ray, out hitInfo)) 
            {
                mobileTouchCamera.lockCamera = true;
                PlaceBuilding(hitInfo.point, structure);
            }

            // touch phase began doesn't work here?
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

        #if UNITY_EDITOR || UNITY_STANDALONE

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        SetBuilding(structure); // old way

        /* come back to this, not sure why not working, work on this along with the DragBuildling(<parameters>)
        startPos = Input.mousePosition;
        startPos.z += 400; // offset for placing the building in view position
        Debug.Log(startPos);
        SetBuildingInView(structure, startPos);
        */

        #endif
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
        var finalPosition = GetNearestPointOnGrid(clickPoint);
        GO = Instantiate(gameObject, finalPosition, Quaternion.identity, this.transform);
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
                EventManager.TriggerEvent("LumberMillEstablished");
                FinalizeBuilding(buildingSelection);
                mobileTouchCamera.lockCamera = false;
            } 


            // if (double tap) FinalizeBuilding(buildSelection);
        }
  
        #endif

        #if UNITY_EDITOR || UNITY_STANDALONE

        bool startedDragging = false;
        

        // not working for now
        // if (Input.mousePosition.y > startPos.y && !startedDragging) // to not hide the building behind the menu when starting to build
        // {

            startedDragging = true;

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            MoveBuildingToDragPoint();

            
            if (Input.GetMouseButtonDown(0))
            {
                EventManager.TriggerEvent("LumberMillEstablished");
                FinalizeBuilding(buildingSelection); // for desktop we finalize building by clicking - we could also tap for the mobile version
            }
            
            if (Input.GetMouseButtonDown(1)) DestroyBuilding(); // cancel
        // }

        #endif       
    }



    void RotateBuilding()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            mobileTouchCamera.lockCamera = true;
            // GO.transform.Rotate(Vector3.up * 3.0f, Space.Self);
            GO.transform.Rotate(0, 90, 0);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            mobileTouchCamera.lockCamera = true;
            // GO.transform.Rotate(Vector3.up * 3.0f, Space.Self);
            GO.transform.Rotate(0, -90, 0);
        }
    }



    void FinalizeBuilding(GameObject gameObject)
    {
        Vector3 finalizedPosition; // not to be confused with finalPosition
        finalizedPosition = GO.transform.position;
        Quaternion finalizedRotation = GO.transform.rotation;

        Destroy(GO);

        finalGO = (GameObject)Instantiate(gameObject, finalizedPosition, finalizedRotation, this.transform);
        
        start = false;

        mobileTouchCamera.lockCamera = false;

        /*
        if (tutorial.tutorialModeOn && !wasFirstRoadBuilt)
        {
            tutorial.BuiltFirstRoad();
            wasFirstRoadBuilt = true;
        }
        */
    }



    // non mobile?

    void CancelBuildingNonMobile()
    {
        mobileTouchCamera.lockCamera = false;
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
        if (start && GO != null)
        {
            DragBuilding();
            RotateBuilding();
        }
    }



}
