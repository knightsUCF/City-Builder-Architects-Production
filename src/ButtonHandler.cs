using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ButtonHandler : MonoBehaviour
{

    float volume = 1.0F;
    
    public AudioClip select;
    

    AudioSource audio;

    // private EventManager events;
    private Build build;

    // drag in deactivated buttons
    public GameObject confirmButton;
    public GameObject cancelButton;

    public GameObject homeButton;
    public GameObject roadButton;

    bool toggle = true;



    bool homeActive = false;
    bool roadActive = false;
    bool confirmActive = false;
    bool cancelActive = false;



    enum BuildingType {

        House,
        LumberMill,
        StoneMill

    }

    private BuildingType buildingType;





    void Awake()
    {
        // events = FindObjectOfType<EventManager>();
        build = FindObjectOfType<Build>();
    }

    

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }



    public void OnHouse1Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildHouse1");
    }



    public void OnHouse2Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildHouse2");
    }



    public void OnHouse3Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildHouse3");
    }



    public void OnTenament1Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildTenament1");
    }



    public void OnTenament2Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildTenament2");
    }



    public void OnTenament3Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildTenament3");
    }



    public void OnStoreClick()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildStore");
    }



    public void OnProductionFacility1Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildProductionFacility1");
    }



    public void OnProductionFacility2Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildProductionFacility2");
    }



    public void OnFactoryClick()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildFactory");
    }



    public void OnEmploymentOfficeClick()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildEmploymentOffice");
    }



    public void OnOffice1Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildOffice1");
    }



    public void OnOffice2Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildOffice2");
    }



    public void OnOffice3Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildOffice3");
    }



    public void OnOffice4Click()
    {
        audio.PlayOneShot(select, volume);
        // we will want to indicate the type of structure clicked - we will use building type later for this
        // EventManager.TriggerEvent ("testEvent")
        EventManager.TriggerEvent("BuildOffice4");
    }



    // R O A D S ///////////////////////////////////////////////////////////////////////////////////////////////


    public void OnRoadShortClick()
    {
        audio.PlayOneShot(select, volume);
        EventManager.TriggerEvent("BuildRoadShort");
    }



    public void OnRoadLongClick()
    {
        audio.PlayOneShot(select, volume);
        EventManager.TriggerEvent("BuildRoadLong");
    }



    public void OnRoadIntersectionClick()
    {
        audio.PlayOneShot(select, volume);
        EventManager.TriggerEvent("BuildRoadIntersection");
    }



    public void OnRoadCurveClick()
    {
        audio.PlayOneShot(select, volume);
        EventManager.TriggerEvent("BuildRoadCurve");
    }



    public void OnRoad3WayClick()
    {
        audio.PlayOneShot(select, volume);
        EventManager.TriggerEvent("BuildRoad3Way");
    }


    





    /*

    public void OnBuildClick()
    {
        
        audio.PlayOneShot(select, volume);
        // confirmButton.SetActive(toggle);
        // cancelButton.SetActive(toggle);
        roadButton.SetActive(toggle);
        homeButton.SetActive(toggle);
        toggle = !toggle;

        if (confirmActive == true && cancelActive == true)
        {
            confirmButton.SetActive(false);
            cancelButton.SetActive(false);
        }
    }


    public void OnHomeClick()
    {
        audio.PlayOneShot(select, volume);

        // these two lines begin a new building cycle
        // build.doneBuilding = false;
        // build.haveWePlacedFirstBuildingStage = false;

        // here we will also pass the object type, or set the object type in the data.cs class
        Data.structureSelection = Data.StructureSelection.house;
        build.allowBuild = true;

        // toggle = true;

        #if UNITY_ANDROID

        confirmButton.SetActive(true);
        cancelButton.SetActive(true);

        confirmActive = true;
        cancelActive = true;

        #endif

        // toggle = !toggle;
        homeActive = true;
        
    }


    public void OnRoadClick()
    {
        audio.PlayOneShot(select, volume);

        // these two lines begin a new building cycle
        // build.doneBuilding = false;
        // build.haveWePlacedFirstBuildingStage = false;

        // here we will also pass the object type, or set the object type in the data.cs class
        Data.structureSelection = Data.StructureSelection.road;
        build.allowBuild = true;


        // toggle = true;

        #if UNITY_ANDROID

        confirmButton.SetActive(true);
        cancelButton.SetActive(true);

        confirmActive = true;
        cancelActive = true;

        #endif

        // toggle = !toggle;
        roadActive = true;
        
    }



    public void OnConfirmClick()
    {
        audio.PlayOneShot(select, volume);
        // events.EventEndBuilding();
        // build.FinalizeBuilding();
        confirmButton.SetActive(false);
        cancelButton.SetActive(false);
        toggle = true;
        // build.allowBuild = false;
        
        // not sure if this is breaking the mobile build...
        // build.FinalizeBuildingOnConfirm(); // took this out for now... will need to add back in when building on mobile

        build.allowBuild = false; // probably can go in the above build.FnalizedBuildingOnConfirm() scope

        roadButton.SetActive(false);
        homeButton.SetActive(false);


    }



    // cancels the building cycle routine

    public void OnCancelClick()
    {
        build.DestroyBuilding();
        audio.PlayOneShot(select, volume);
        // events.EventEndBuildingCycleRoutine();
        confirmButton.SetActive(false);
        cancelButton.SetActive(false);
        toggle = true;

        // some are needed for android, can probably take out two
        build.allowBuild = false; // might not need this
        build.startedBuild = false; // might not need this
        build.haveWePlacedFirstBuildingStage = false;
        build.doneBuilding = false;

        roadButton.SetActive(false);
        homeButton.SetActive(false);
        
        
    }

    */






}
