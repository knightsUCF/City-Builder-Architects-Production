using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ButtonHandler : MonoBehaviour
{

    float volume = 1.0F;
    
    public AudioClip select;
    AudioSource audio;

    private EventManager events;
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



    void Awake()
    {
        events = FindObjectOfType<EventManager>();
        build = FindObjectOfType<Build>();
    }

    

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }



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
        build.FinalizeBuildingOnConfirm();
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

        roadButton.SetActive(false);
        homeButton.SetActive(false);
        
        
    }






}
