using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGUIHandler : MonoBehaviour
{


    public GameObject standardGrid;

    bool standardGridToggle = false;
    



    void OnEnable()
    {
        EventManager.StartListening("StandardGridClicked", StandardGridClickedEvent);
    }


    void OnDisable()
    {
        EventManager.StopListening("StandardGridClicked", StandardGridClickedEvent);
    }





    void StandardGridClickedEvent()
    {
        if (!standardGridToggle)
        {
            standardGrid.SetActive(true);
        }

        if (standardGridToggle)
        {
            standardGrid.SetActive(false);
        }

        standardGridToggle = !standardGridToggle;

    }




}
