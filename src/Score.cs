using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// uses instruction from SoundManager.cs

// for some reason conflicts with some of the sound effects, but works fine with the main menu selection mechanism


public class Score : MonoBehaviour
{


    public AudioClip score;


    void Start()
    {
        SoundManager.instance.PlaySingle(score, 5.0f);
    }


}
