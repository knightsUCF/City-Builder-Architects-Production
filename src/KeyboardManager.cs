using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class KeyboardManager : MonoBehaviour
{


    bool cameraToggle = false;



    void Update()
    {
        if (Input.GetKey("escape") || Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }


        // switch cameras

        if (Input.GetKeyDown(KeyCode.C))
        {

            if (!cameraToggle) EventManager.TriggerEvent("Toggle to car camera");

            else if (cameraToggle) EventManager.TriggerEvent("Toggle to build camera");

            cameraToggle = !cameraToggle;

            // Debug.Log("camera toggle:");
            
        }
    }
}
