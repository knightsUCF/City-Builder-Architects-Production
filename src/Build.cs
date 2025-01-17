using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



/*
float volume = 1.0F;
    
    public AudioClip select;
    AudioSource audio;

audio.PlayOneShot(select, volume);


void Start()
    {
        audio = GetComponent<AudioSource>();
    }


*/



public class Build : MonoBehaviour
{

    public float gridSize = 10.0f;


    float volume = 1.0F;
    public AudioClip select;
    public AudioClip finalizedBuilding;
    public AudioClip cantBuild;
    public AudioClip cancelBuilding;


    
    GameObject GO;
    GameObject finalGO;
    GameObject buildingSelection;

    public GameObject house1;
    public GameObject house2;
    public GameObject house3;

    public GameObject tenament1;
    public GameObject tenament2;
    public GameObject tenament3;

    public GameObject store;
    public GameObject facility1;
    public GameObject facility2;
    public GameObject factory;

    public GameObject employmentOffice;
    public GameObject office1;
    public GameObject office2;
    public GameObject office3;
    public GameObject office4;
    
    public GameObject waterPlant;
    public GameObject waterPipe;

    public GameObject land;


    public GameObject skyscraper1;
    public GameObject skyscraper2;
    public GameObject skyscraper3;
    public GameObject skyscraper4;
    public GameObject skyscraper5;
    public GameObject skyscraper6;


    int currentlySelectedBuildingCost = 0; // so that we can give back the money if the player cancels the building


    
    
    Ray ray;
    Touch touch;
    Vector3 closestVector;
    RaycastHit hitInfo;

    Costs costs;
    BuildingRequirements buildingRequirements;
    BitBenderGames.MobileTouchCamera mobileTouchCamera;
    SoundInterface soundInterface;


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


    // temporary ?

    public bool start = false;




    // setting current: buildingType = BuildingType.House;

    enum BuildingType {

        House,
        LumberMill,
        StoneMill

    }

    private BuildingType buildingType;




    bool hideMouse = false;



    void Awake()
    {
        // BitBenderGames
        mobileTouchCamera = FindObjectOfType<BitBenderGames.MobileTouchCamera>();
        costs = FindObjectOfType<Costs>();
        soundInterface = FindObjectOfType<SoundInterface>();
    }




    void OnEnable()
    {
        EventManager.StartListening("BuildHouse1", BuildHouse1Event);
        EventManager.StartListening("BuildHouse2", BuildHouse2Event);
        EventManager.StartListening("BuildHouse3", BuildHouse3Event);

        EventManager.StartListening("BuildTenament1", BuildTenament1Event);
        EventManager.StartListening("BuildTenament2", BuildTenament2Event);
        EventManager.StartListening("BuildTenament3", BuildTenament3Event);

        EventManager.StartListening("BuildStore", BuildStoreEvent);
        EventManager.StartListening("BuildProductionFacility1", BuildProductionFacility1Event);
        EventManager.StartListening("BuildProductionFacility2", BuildProductionFacility2Event);
        EventManager.StartListening("BuildFactory", BuildFactoryEvent);

        EventManager.StartListening("BuildEmploymentOffice", BuildEmploymentOfficeEvent);
        EventManager.StartListening("BuildOffice1", BuildOffice1Event);
        EventManager.StartListening("BuildOffice2", BuildOffice2Event);
        EventManager.StartListening("BuildOffice3", BuildOffice3Event);
        EventManager.StartListening("BuildOffice4", BuildOffice4Event);

        EventManager.StartListening("BuildWaterPlant", BuildWaterPlantEvent);
        EventManager.StartListening("BuildWaterPipe", BuildWaterPipeEvent);

        // EventManager.StartListening("BuildLand", BuildLandEvent);

        EventManager.StartListening ("BuyLand", BuyLandEvent);
    }



    void OnDisable()
    {
        EventManager.StopListening("BuildHouse1", BuildHouse1Event);
        EventManager.StopListening("BuildHouse2", BuildHouse2Event);
        EventManager.StopListening("BuildHouse3", BuildHouse3Event);

        EventManager.StopListening("BuildTenament1", BuildTenament1Event);
        EventManager.StopListening("BuildTenament2", BuildTenament2Event);
        EventManager.StopListening("BuildTenament3", BuildTenament3Event);

        EventManager.StopListening("BuildStore", BuildStoreEvent);
        EventManager.StopListening("BuildProductionFacility1", BuildProductionFacility1Event);
        EventManager.StopListening("BuildProductionFacility2", BuildProductionFacility2Event);
        EventManager.StopListening("BuildFactory", BuildFactoryEvent);

        EventManager.StopListening("BuildEmploymentOffice", BuildEmploymentOfficeEvent);
        EventManager.StopListening("BuildOffice1", BuildOffice1Event);
        EventManager.StopListening("BuildOffice2", BuildOffice2Event);
        EventManager.StopListening("BuildOffice3", BuildOffice3Event);
        EventManager.StopListening("BuildOffice4", BuildOffice4Event);

        EventManager.StopListening("BuildWaterPlant", BuildWaterPlantEvent);
        EventManager.StopListening("BuildWaterPipe", BuildWaterPipeEvent);

        // EventManager.StopListening("BuildLand", BuildLandEvent);

        EventManager.StopListening ("BuyLand", BuyLandEvent);
    }


    

    // rewrite the rest of the methods like this with Purchasable()


    // not really events for the skycraper buttons, interfering with audio sounds

    public void BuildSkyscraper1()
    {
        gridSize = 16.0f;
        start = true;
        buildingSelection = skyscraper1;
        PlaceStartingBuilding(skyscraper1);
    }



    public void BuildSkyscraper2()
    {
        gridSize = 16.0f;
        start = true;
        buildingSelection = skyscraper2;
        PlaceStartingBuilding(skyscraper2);
    }



    public void BuildSkyscraper3()
    {
        gridSize = 16.0f;
        start = true;
        buildingSelection = skyscraper3;
        PlaceStartingBuilding(skyscraper3);
    }



    public void BuildSkyscraper4()
    {
        gridSize = 16.0f;
        start = true;
        buildingSelection = skyscraper4;
        PlaceStartingBuilding(skyscraper4);
    }



    public void BuildSkyscraper5()
    {
        gridSize = 16.0f;
        start = true;
        buildingSelection = skyscraper5;
        PlaceStartingBuilding(skyscraper5);
    }



    public void BuildSkyscraper6()
    {
        gridSize = 16.0f;
        start = true;
        buildingSelection = skyscraper6;
        PlaceStartingBuilding(skyscraper6);
    }






    public void BuildHouse1Event()
    {
        // if (costs.Purchasable(costs.house1))
        // {
            gridSize = 8.0f;
            start = true;
            buildingSelection = house1; 
            PlaceStartingBuilding(house1);
        // }        
    }



    public void BuildHouse2Event()
    {
        
        // if (costs.House2())
        // {
            gridSize = 16.0f;
            start = true;
            buildingSelection = house2;
            PlaceStartingBuilding(house2);
        // }
        
    }



    void BuildHouse3Event()
    {
        /*
        if (costs.House3())
        {
            start = true;
            buildingSelection = house3;
            PlaceStartingBuilding(house3); 
        }
        */   
    }



    void BuildTenament1Event()
    {        
        start = true;
        buildingSelection = tenament1;
        PlaceStartingBuilding(tenament1);        
    }



    void BuildTenament2Event()
    {        
        start = true;
        buildingSelection = tenament2;
        PlaceStartingBuilding(tenament2);        
    }



    void BuildTenament3Event()
    {        
        start = true;
        buildingSelection = tenament3;
        PlaceStartingBuilding(tenament3);        
    }



    void BuildStoreEvent()
    {        
        start = true;
        buildingSelection = store;
        PlaceStartingBuilding(store);        
    }



    void BuildProductionFacility1Event()
    {        
        start = true;
        buildingSelection = facility1;
        PlaceStartingBuilding(facility1);        
    }



    void BuildProductionFacility2Event()
    {        
        start = true;
        buildingSelection = facility2;
        PlaceStartingBuilding(facility2);        
    }



    void BuildFactoryEvent()
    {        
        start = true;
        buildingSelection = factory;
        PlaceStartingBuilding(factory);        
    }



    void BuildEmploymentOfficeEvent()
    {        
        start = true;
        buildingSelection = employmentOffice;
        PlaceStartingBuilding(employmentOffice);        
    }



    void BuildOffice1Event()
    {        
        start = true;
        buildingSelection = office1;
        PlaceStartingBuilding(office1);        
    }



    void BuildOffice2Event()
    {        
        start = true;
        buildingSelection = office2;
        PlaceStartingBuilding(office2);        
    }



    void BuildOffice3Event()
    {        
        start = true;
        buildingSelection = office3;
        PlaceStartingBuilding(office3);        
    }
    


    void BuildOffice4Event()
    {        
        start = true;
        buildingSelection = office4;
        PlaceStartingBuilding(office4);        
    }



    void BuildWaterPlantEvent()
    {
        start = true;
        buildingSelection = waterPlant;
        PlaceStartingBuilding(waterPlant);
    }



    void BuildWaterPipeEvent()
    {
        start = true;
        buildingSelection = waterPipe;
        PlaceStartingBuilding(waterPipe);
    }



    public void BuyLandEvent()
    {
        if (costs.Purchasable(costs.land))
        {
            // set the snap to grid level, but keep in mind, will need to declare the snap to grid level for each build method
            gridSize = 64.0f;
            Debug.Log("Buying land!");
            start = true;
            buildingSelection = land;
            PlaceStartingBuilding(land);
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


        /*
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
        */



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

        

        #if UNITY_EDITOR || UNITY_STANDALONE

        */

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // SetBuilding(structure); // old way -- placing building in starting position of mouse, but this is covered under the menu, so let's move the building up a little


        Vector3 startPos = Input.mousePosition;

        startPos.z += 100; // offset for placing the building in view position


        Cursor.visible = false;

        SetBuildingInView(structure, startPos);

        // #endif
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
        var finalPosition = GetNearestPointOnGrid(clickPoint);
        GO = Instantiate(gameObject, finalPosition, Quaternion.identity, this.transform);
        buildingRequirements = GO.GetComponent<BuildingRequirements>(); 
        return (Vector2)finalPosition;
    }



    Vector3 lastGridPos = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 newGridPos = new Vector3(0.0f, 0.0f, 0.0f);


    void MoveBuildingToDragPoint()
    {
        if (Physics.Raycast(ray, out hitInfo))
        {
            var gridPos = GetNearestPointOnGrid(hitInfo.point);
            GO.transform.position = gridPos;

            newGridPos = gridPos;

            if (lastGridPos != newGridPos)
            {
                // SoundManager.instance.PlaySingle(select, 0.3f);
                soundInterface.PlayDragStructureSound();
                lastGridPos = newGridPos;
            }
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

        // #if UNITY_EDITOR || UNITY_STANDALONE

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        MoveBuildingToDragPoint();

        /*
        Debug.Log("buildingRequirements.canBuild: " + buildingRequirements.canBuild);
        Debug.Log("buildingRequirements.ownZonedLand: " + buildingRequirements.ownZonedLand);
        Debug.Log("buildingRequirements.waterAvailable: " + buildingRequirements.waterAvailable);
        Debug.Log("buildingRequirements.extraRequirementFlag: " + buildingRequirements.extraRequirementFlag);
        */
    
        if (Input.GetMouseButtonDown(0) &&
            buildingRequirements.canBuild && 
            buildingRequirements.ownZonedLand &&
            buildingRequirements.waterAvailable &&
            buildingRequirements.powerAvailable &&
            buildingRequirements.extraRequirementFlag)
        {
            FinalizeBuilding(buildingSelection); // for desktop we finalize building by clicking - we could also tap for the mobile version
        }

        // if we can't build play the appropriate sound effect

        if (Input.GetMouseButtonDown(0) && !buildingRequirements.canBuild) soundInterface.PlayCantBuildHereSound();
        

        // cancel building

        if (Input.GetMouseButtonDown(1)) DestroyBuilding();

        // #endif       
    }



    void RotateBuilding()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            mobileTouchCamera.lockCamera = true;
            // GO.transform.Rotate(Vector3.up * 3.0f, Space.Self);
            GO.transform.Rotate(0, 90, 0);
            SoundManager.instance.PlaySingle(select, 0.3f);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            mobileTouchCamera.lockCamera = true;
            // GO.transform.Rotate(Vector3.up * 3.0f, Space.Self);
            GO.transform.Rotate(0, -90, 0);
            SoundManager.instance.PlaySingle(select, 0.3f);
        }
    }



    void FinalizeBuilding(GameObject gameObject)
    {
        soundInterface.PlayFinalizeStructureSound();


        Cursor.visible = true;



        Vector3 finalizedPosition; // not to be confused with finalPosition
        finalizedPosition = GO.transform.position;
        Quaternion finalizedRotation = GO.transform.rotation;

        Destroy(GO);

        

        finalGO = (GameObject)Instantiate(gameObject, finalizedPosition, finalizedRotation, this.transform);



        // for preventing the structure changing colors on collider event when we have already set down the building
        buildingRequirements = finalGO.GetComponent<BuildingRequirements>();
        buildingRequirements.structureFinalized = true;


        start = false;

        mobileTouchCamera.lockCamera = false;

        GetComponent<AudioSource>().PlayOneShot(finalizedBuilding, volume);


        // here we will need some way to trigger build events based on building type, we could use the previous events but those are triggered when we first set the building
        // and the purpose here is that we don't want to replace the first build stage right away when the player is still dragging the building, but only when they set the building down
        // which will be another event, so here we will need to trigger an event, and we already have the current build selection type state set above to go by

        // EventManager.TriggerEvent("House1Finalized");
        
        // what if instead we just simply grab the build component on the object

        // this way the whole building stages component will contain the different model stages attached to each building object, so we simply drag in the appropriate stages for each game object

        BuildingStages buildingStages;

        buildingStages = finalGO.GetComponent<BuildingStages>();
        buildingStages.OnFinalizeBuildingEvent(finalizedRotation);


        EventManager.TriggerEvent("PlacedHouse"); // for sending notification to SimMovementControls


        

    }

    



    // non mobile?

    // currently not being used ?
    void CancelBuildingNonMobile()
    {
        // not sure why the above CancelBuildingNonMobile is not being called on right click at line 469, for now we will put the functions here that should really go in CancelBuildingNonMobile
        // if there are any bad state resets, that's because we are not calling CancelBuildingNonMobile

        mobileTouchCamera.lockCamera = false;
        allowBuild = false;
        startedBuild = false;
        Destroy(GO);
    }



    public void DestroyBuilding()
    {
        Cursor.visible = true;
        SoundManager.instance.PlaySingle(cancelBuilding, 0.3f);
        costs.Refund(costs.currentlySelectedBuildingCost); // give back the money on canceling building
        mobileTouchCamera.lockCamera = false;
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
