using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Should be renamed to just MenuSelector, since includes things such as Research Tree


public class BuildingMenuSelector : MonoBehaviour
{

    public GameObject BuildingsMenu;
    public GameObject PlatformsMenu;
    public GameObject GridsMenu;
    public GameObject WaterSystemMenu;
    public GameObject ResearchTree;

    bool ResearchTreeToggle = true;



    public AudioClip tabSelect;



    

    public void OnSelectBuildingMenu()
    {
        PlatformsMenu.SetActive(false);
        GridsMenu.SetActive(false);
        WaterSystemMenu.SetActive(false);
        BuildingsMenu.SetActive(true);
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
        
    }



    public void OnSelectPlatformsMenu()
    {
        BuildingsMenu.SetActive(false);
        GridsMenu.SetActive(false);
        WaterSystemMenu.SetActive(false);
        PlatformsMenu.SetActive(true);
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
    }



    public void OnSelectGridsMenu()
    {
        BuildingsMenu.SetActive(false);
        PlatformsMenu.SetActive(false);
        WaterSystemMenu.SetActive(false);
        GridsMenu.SetActive(true);
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
    }



    public void OnSelectWaterSystemMenu()
    {
        BuildingsMenu.SetActive(false);
        PlatformsMenu.SetActive(false);
        GridsMenu.SetActive(false);
        WaterSystemMenu.SetActive(true);
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
    }



    public void OnSelectResearchTree()
    {
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
        ResearchTree.SetActive(ResearchTreeToggle);
        ResearchTreeToggle = !ResearchTreeToggle;
    }



    public void CloseResearchTree()
    {
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
        ResearchTree.SetActive(false);
        ResearchTreeToggle = true;
    }







}
