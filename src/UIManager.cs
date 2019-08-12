using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class UIManager : MonoBehaviour
{
    
    
    public GameObject buildHouseIcon;


    public void RevealHouseIcon()
    {
        if (!buildHouseIcon.activeSelf) buildHouseIcon.SetActive(true);
    }


    public void HideHouseIcon()
    {
        if (buildHouseIcon.activeSelf) buildHouseIcon.SetActive(true);
    }


}
