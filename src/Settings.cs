using UnityEngine;
using System.Collections;




public class Settings : Singleton<Settings>
{




    public static int startingMoney = 100;
    public static int startingEnergy = 0;
    public static int startingWood = 0;

    public static int hireWorkerCost = 10;


    public static float buildTime = 2.0f;


    // building costs





    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

}
