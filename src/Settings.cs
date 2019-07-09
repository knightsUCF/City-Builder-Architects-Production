using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : Singleton<Settings>
{


    // building costs

    public static int BuildingCost = 10;




    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    


    void Start()
    {
        #if UNITY_ANDROID
        
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        QualitySettings.antiAliasing = 0;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        #endif
    }


}




