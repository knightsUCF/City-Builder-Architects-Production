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

    bool toggle = true;



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
        build.doneBuilding = false;
        build.haveWePlacedFirstBuildingStage = false;
        audio.PlayOneShot(select, volume);
        confirmButton.SetActive(toggle);
        cancelButton.SetActive(toggle);
        toggle = !toggle;
    }



    public void OnConfirmClick()
    {
        audio.PlayOneShot(select, volume);
        events.EventEndBuilding();
        confirmButton.SetActive(false);
        cancelButton.SetActive(false);
        toggle = true;
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
        
        
    }



}
