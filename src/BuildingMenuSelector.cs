using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Should be renamed to just MenuSelector, since includes things such as Research Tree


public class BuildingMenuSelector : MonoBehaviour
{

    public GameObject BuildingsMenu;
    public GameObject PlatformsMenu;
    public GameObject GridsMenu;
    public GameObject ResearchTree;

    bool ResearchTreeToggle = false;



    public AudioClip tabSelect;



    

    public void OnSelectBuildingMenu()
    {
        PlatformsMenu.SetActive(false);
        GridsMenu.SetActive(false);
        BuildingsMenu.SetActive(true);
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
        
    }



    public void OnSelectPlatformsMenu()
    {
        BuildingsMenu.SetActive(false);
        GridsMenu.SetActive(false);
        PlatformsMenu.SetActive(true);
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
    }



    public void OnSelectGridsMenu()
    {
        BuildingsMenu.SetActive(false);
        PlatformsMenu.SetActive(false);
        GridsMenu.SetActive(true);
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
    }



    public void OnSelectResearchTree()
    {
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
        if (!ResearchTreeToggle) ResearchTree.SetActive(true);
        else ResearchTree.SetActive(false);
        ResearchTreeToggle = !ResearchTreeToggle;
    }



    public void CloseResearchTree()
    {
        SoundManager.instance.PlaySingle(tabSelect, 1.0f);
        ResearchTree.SetActive(false);
    }




}
