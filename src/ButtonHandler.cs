using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ButtonHandler : MonoBehaviour
{

    float volume = 1.0F;
    
    public AudioClip select;
    AudioSource audio;

    private EventManager events;

    // drag in deactivated buttons
    public GameObject confirmButton;
    public GameObject cancelButton;

    bool toggle = true;



    void Awake()
    {
        events = FindObjectOfType<EventManager>();
    }

    


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }



    public void OnBuildClick()
    {
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



    public void OnCancelClick()
    {
        audio.PlayOneShot(select, volume);
        confirmButton.SetActive(false);
        cancelButton.SetActive(false);
        toggle = true;
    }



}
