using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Factory : MonoBehaviour
{

    public GameObject worker;

    public GameObject factoryInfoPanel;
    public Text level;
    
    
    public bool producingEnergy = false;
    public int workerID = -1;
    public int workerEngineeringLevel = 0; // we would like to grab the workers engineering level

    bool panelToggle = true;

    PlaceWorker placeWorker;

    public bool workerOutside = true;




    void Awake()
    {
        placeWorker = FindObjectOfType<PlaceWorker>();
    }



    void TogglePanel()
    {
        factoryInfoPanel.SetActive(panelToggle);
        panelToggle = !panelToggle;
    }



    void OnMouseDown()
    {
        UpdateLevel();
        TogglePanel();

        if (workerOutside) 
        {
            placeWorker.callOnce = true; // we also want to reset the callOnce flag on Factory, so that we can renter the building
            workerOutside = false;
        }
    }



    public void UpdateLevel()
    {
        level.text = "Level: " + workerEngineeringLevel.ToString();
        // this is getting updated from PayOut.cs, not sure if this is too messy
    }




    public void PassWorkerGameObject(GameObject workerGO)
    {
        worker = workerGO;
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            worker.SetActive(true);
            workerOutside = true;
        }
    }



}
