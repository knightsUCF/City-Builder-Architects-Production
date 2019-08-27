using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 

// so before building we will need to zone the land
// well when we purchase the land we should zone then, instead of doing this separately

public class ZoneLand : MonoBehaviour
{


    public GameObject landTypePanel;

    bool toggle = true;


    public enum CurrentlySelectedZone
    {
        Residential,
        Commercial,
        Industrial
    };

    public CurrentlySelectedZone currentlySelectedZone;



    public int iCurrentlySelectedZone = -1; // 1 - residential, 2 - commercial, 3 - industrial





    public void ZoneLandButtonClicked()
    {
        landTypePanel.SetActive(toggle);
        toggle = !toggle;
    }



    public void OnSelectResidentialLand()
    {
        currentlySelectedZone = CurrentlySelectedZone.Residential;
        iCurrentlySelectedZone = 1; 
        EventManager.TriggerEvent("BuyLandGridClicked");
        landTypePanel.SetActive(false);
    }



    public void OnSelectCommercialLand()
    {
        currentlySelectedZone = CurrentlySelectedZone.Commercial;
        iCurrentlySelectedZone = 2;
        EventManager.TriggerEvent("BuyLandGridClicked");
        landTypePanel.SetActive(false);
    }



    public void OnSelectIndustrialLand()
    {
        currentlySelectedZone = CurrentlySelectedZone.Industrial;
        iCurrentlySelectedZone = 3;
        EventManager.TriggerEvent("BuyLandGridClicked");
        landTypePanel.SetActive(false);
    }
    


}
