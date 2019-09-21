using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// create audio source as component attached to where this script is
// drag into speakers slot
// probably should have centralized speakers later



public class SimPanel : MonoBehaviour
{
    
    public GameObject panel;
    bool toggle = true;

    public GameObject SpeakersGO;

    AudioSource speakers;
    public AudioClip select;




    void Awake()
    {
        speakers = GameObject.FindWithTag("Speakers").GetComponent<AudioSource>();
        speakers.clip = select;
        speakers.volume = 1.0f;
    }



    void OnMouseDown()
    {
        speakers.Play();
        panel.SetActive(toggle);
        GetComponent<SimData>().selected = toggle;
        toggle = !toggle;
    }


}
