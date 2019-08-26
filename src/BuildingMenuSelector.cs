using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class BuildingMenuSelector : MonoBehaviour
{

    public GameObject BuildingsMenu;
    public GameObject PlatformsMenu;
    public GameObject GridsMenu;



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

}
