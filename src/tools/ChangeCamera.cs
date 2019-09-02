using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ChangeCamera : MonoBehaviour
{



    public GameObject buildCamera;
    public GameObject carCamera;



    void OnEnable()
    {
        EventManager.StartListening("Toggle to car camera", ToggleCarCamera);
        EventManager.StartListening("Toggle to build camera", ToggleBuildCamera);
    }


    void OnDisable()
    {
        EventManager.StopListening("Toggle to car camera", ToggleCarCamera);
        EventManager.StopListening("Toggle to build camera", ToggleBuildCamera);
    }




    void Start()
    {
        ToggleCarCamera();
    }



    void ToggleCarCamera()
    {
        buildCamera.SetActive(false);
        carCamera.SetActive(true);
    }


    void ToggleBuildCamera()
    {
        carCamera.SetActive(false);
        buildCamera.SetActive(true);
    }



}
