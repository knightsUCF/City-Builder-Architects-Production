using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class BuildingMenuSelector : MonoBehaviour
{

    public GameObject BuildingsMenu;
    public GameObject PlatformsMenu;



    public void OnSelectBuildingMenu()
    {
        PlatformsMenu.SetActive(false);
        BuildingsMenu.SetActive(true);
    }



    public void OnSelectPlatformsMenu()
    {
        BuildingsMenu.SetActive(false);
        PlatformsMenu.SetActive(true);
    }

}
