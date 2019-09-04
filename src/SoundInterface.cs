using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SoundInterface : MonoBehaviour
{
    public AudioClip tabSelect;
    public AudioClip dragStructure;
    public AudioClip finalizeStructure;
    public AudioClip cantBuildHere;


    public float volume = 0.5f;

    

    public void Play(string sound)
    {
        if (sound == "select")
        {
            Debug.Log("Playing!");
            SoundManager.instance.PlaySingle(tabSelect, volume);
        }
    }


    public void PlayDragStructureSound()
    {
        SoundManager.instance.PlaySingle(dragStructure, volume);
    }



    public void PlayFinalizeStructureSound()
    {
        SoundManager.instance.PlaySingle(finalizeStructure, volume);
    }


    public void PlayCantBuildHereSound()
    {
        SoundManager.instance.PlaySingle(cantBuildHere, volume);
    }

}
