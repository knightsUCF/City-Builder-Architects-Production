using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Factory : MonoBehaviour
{

    
    public GameObject factoryInfoPanel;
    public Text level;
    
    
    public bool producingEnergy = false;
    public int workerID = -1;
    public int workerEngineeringLevel = 0; // we would like to grab the workers engineering level

    bool panelToggle = true;




    void TogglePanel()
    {
        factoryInfoPanel.SetActive(panelToggle);
        panelToggle = !panelToggle;
    }



    void OnMouseDown()
    {
        UpdateLevel();
        TogglePanel();
    }



    public void UpdateLevel()
    {
        level.text = "Level: " + workerEngineeringLevel.ToString();
        // this is getting updated from PayOut.cs, not sure if this is too messy
    }



}
