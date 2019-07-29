using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/*
1. Attach this to the Employment Office "Model" On Trigger Box Collider
2. Create a canvas panel child object to the Employment Office Game Object
3. When we click on the collider, let's have a panel that pops up asking if we want to hire a new worker

? 4. Eventually if a worker is not selected, the click will just pop up the Power Plant settings, only if a worker is selected will we get the: Assign "Bob" to PowerPlant?


The nice thing about the employment office is that we just hire a generic worker, which we can use for anything.

Perhaps we also get two workers starting out. So one can build an employment office, and the other can do other things, so we can get fancy strategies and build orders.



*/




public class EmploymentOffice : MonoBehaviour
{

    public GameObject worker;
    public Vector3 workerStartPos = new Vector3(0.0f, 4.0f, 0.0f);

    public GameObject hireWorkerPanel;
    public Text confirmHireWorker;
    public Text workerCostText;

    public Text money;

    bool panelToggle = true;

    int balance;




    // when hiring a worker, flash some light beam to show their location, or also do some kind of funky enlarge wobble effect

    public void OnHireWorker()
    {
        // do a check here for enough money required
        Pay();
        CreateNewWorker(); 
        TogglePanel(); 
    }



    void TogglePanel()
    {
        hireWorkerPanel.SetActive(panelToggle);
        panelToggle = !panelToggle;
    }



    void Pay()
    {
        balance = Data.money -= Data.hireWorkerCost;
        money.text = balance.ToString();
    }



    void CreateNewWorker()
    {
        GameObject workerGO = (GameObject)Instantiate(worker, workerStartPos, Quaternion.identity, this.transform);
    }



    public void OnCancel()
    {
        TogglePanel(); 
    }



    void OnMouseDown()
    {
        TogglePanel();
    }


    

    
}
