using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class Build : MonoBehaviour
{

    public float gridSize = 10.0f;

    public GameObject home;
    public GameObject road;

    private GameObject buildSelection;
    GameObject GO;
    GameObject finalGO;

    Ray ray;
    RaycastHit hitInfo;
    Touch touch;
    Vector3 result;

    public Text logText;


    public int roadTileIndex = 0; // tracks consecutive order of road tiles, will need to be stored if the users shuts off the app



    public bool haveWePlacedFirstBuildingStage = false;
    public bool doneBuilding = true; // set to true because normal state is not building (for moving the camera around)

    public bool allowBuild = false;
    public bool allowDrag = false;
    public bool finalized = false;

    public bool startedBuild = false;



    private TrafficSystem trafficSystem;



    void Awake()
    {
        trafficSystem = FindObjectOfType<TrafficSystem>();
    }



    /*
    void OnEnable ()
    {
        EventManager.endBuilding += FinalizeBuilding;
    }

    void OnDisable()
    {
        EventManager.endBuilding -= FinalizeBuilding;
    }
    */



    /*
    public void FinalizeBuilding()
    {
        // doneBuilding = true;
        finalized = true;
    }
    */


    void FinalizeBuilding(GameObject gameObject)
    {
        Vector3 finalizedPosition; // not to be confused with finalPosition
        finalizedPosition = GO.transform.position;
        Destroy(GO);


        if (gameObject.GetComponentInChildren<IsBuildingAllowed>().allowed == true)
        {
            finalGO = (GameObject)Instantiate(gameObject, finalizedPosition, Quaternion.identity, this.transform);
            finalGO.GetComponentInChildren<IsBuildingAllowed>().finalized = true;
            allowBuild = false;
            startedBuild = false;

            // oops, only do the below code for roads not buildings


            if (buildSelection.name == "Road")
            {
                Vector2 tileMapPos = new Vector2(finalizedPosition.x, finalizedPosition.z);

                if (!Data.roadMap.ContainsKey(roadTileIndex))
                {
                    // will need some extra code here to determine if we are adding a building or a road, etc
                    // Data.roadMap.Add(tileMapPos, roadTileIndex); // 1 - road
                    Data.roadMap.Add(roadTileIndex, tileMapPos); // 1 - road
                }

                else Debug.Log("Uh oh, already added this data to the map");

                // only start up the traffic after 3 tiles or so...
                if (roadTileIndex > 2) trafficSystem.UpdateTrafficSystem();

                // placed here, after we update traffic, because if we send +1, that value does not exist yet in the dictionary
                roadTileIndex += 1; // will need to be stored in case user shuts off, or somehow add to last addition in dictionary

            }

            

            

        }
        

        
        // Debug.Log("Calling finalize building");
        // GameObject testGO = Instantiate(gameObject, finalizedPosition, Quaternion.identity, this.transform);
        // isLastObjectInProgress = false; // perhaps a better name for this, we are just resetting the queue

        // gameObject.finalize = true;
        

        

        
    }

    void CancelBuildingNonMobile()
    {
        Destroy(GO);
        allowBuild = false;
        startedBuild = false;
    }


    // a second messy copy of FinalizeBuilding() since we don't have access to the game object in ButtonHandler.cs, might be a cleaner solution here
    
    /*
    public void FinalizeBuildingOnConfirm()
    {

        if (Data.structureSelection == Data.StructureSelection.house)
        {
            buildSelection = home;
        }

        if (Data.structureSelection == Data.StructureSelection.road)
        {
            buildSelection = road;
        }

        Vector3 finalizedPosition; // not to be confused with finalPosition
        finalizedPosition = GO.transform.position;
        Destroy(GO);
        finalGO = (GameObject)Instantiate(buildSelection, finalizedPosition, Quaternion.identity, this.transform);
        // isLastObjectInProgress = false; // perhaps a better name for this, we are just resetting the queue
        allowBuild = false;
        startedBuild = false;


        // for android / mobile

        haveWePlacedFirstBuildingStage = false;
        doneBuilding = false;


        // also reset the selection to none (include this in FinalizeBuilding() also if works)

        //  Data.structureSelection = Data.StructureSelection.none;
    }
    */

    


    void BuildingRoutine() 
    {
        // if (!haveWePlacedFirstBuildingStage) SetStartingPlacement();
        // if (!doneBuilding && GO != null) DragStructureAround(); // hacky solution for destroyed game object but works for now
        

        // checking for object not null in case we finalize the building with the check mark in the desktop version
        // since clicking finalizes building, and afterwards there is nothing to finalize by the checkmark
        // potentially can be fixed by taking away the checkmark confirmation option in both the editor and desktop version


        
        #if UNITY_EDITOR || UNITY_STANDALONE_OSX

        if (allowBuild) 
        {
            if (!startedBuild)
            {
                SetStartingPlacement();
            }

            if (!doneBuilding && GO != null) DragStructureAround();
        }

        // just for non mobile - cancel building with right click

        if (Input.GetMouseButtonDown(1))
        {
            if (GO != null)
            {
                CancelBuildingNonMobile();
            }
        }
        
        
        #endif

        // this was getting double called for some reason... ? need to take this out for now... ? 

        /*
        #if UNITY_ANDROID


        if (!haveWePlacedFirstBuildingStage && allowBuild) SetStartingPlacement();
        if (!doneBuilding && GO != null) DragStructureAround(); // hacky solution for destroyed game object but works for now

        #endif
        */

    }



    void Start()
    {
        buildSelection = home; // we will set to none after the "build right away" bug
    }


    void Update()
    {
        BuildingRoutine();
    }



    void SetStartingPlacement()
    {


        
        doneBuilding = false;

        startedBuild = true;





        if (Data.structureSelection == Data.StructureSelection.house)
        {
            buildSelection = home;
        }

        if (Data.structureSelection == Data.StructureSelection.road)
        {
            buildSelection = road;
        }


        #if UNITY_ANDROID

        // if (GO != null)
        // {
            if (Input.touchCount > 0)
            {
                // reaching this scope
                // logText.text = "reached input touch count scope";
                // Debug.LogError("reached input touch count scope");
                touch = Input.GetTouch(0);
                ray = Camera.main.ScreenPointToRay(touch.position);
                if (touch.phase == TouchPhase.Began)
                {
                    // logText.text = "touch phase began scope";
                    // not reaching this scope
                    if (Physics.Raycast(ray, out hitInfo)) 
                    {
                        // logText.text = "Reached PlaceStructure() scope";
                        // not reaching this scope
                        PlaceStructure(hitInfo.point, buildSelection);
                        startedBuild = true;
                        haveWePlacedFirstBuildingStage = true;
                    }
                }
            }
        // }

        #endif


        #if UNITY_EDITOR


        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            PlaceStructure(hitInfo.point, buildSelection);
            haveWePlacedFirstBuildingStage = true;
        }

        #endif


        #if UNITY_STANDALONE_OSX

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            PlaceStructure(hitInfo.point, buildSelection);
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

        if (Data.structureSelection == Data.StructureSelection.house)
        {
            buildSelection = home;
        }

        if (Data.structureSelection == Data.StructureSelection.road)
        {
            buildSelection = road;
        }



        #if UNITY_ANDROID

        // if (GO != null)
        // {
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
        // }

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
            
            FinalizeBuilding(buildSelection); 
            
            // buildSelection will be replaced with end stage

            // allowBuild = false;
            // DestroyBuilding(); // ? are we destroying a copy?
        }

        // likewise we want to cancel the building with the right click

        // doing this automatically?

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
            // not sure if GO is the parameter
            // FinalizeBuilding(GO); // took this out because might be duplicating
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
