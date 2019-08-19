using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Store : MonoBehaviour
{

    public GameObject panel;

    bool panelToggle = true;

    int salesType = -1; // 1 - food, 2 - apparel, 3 - electronics



    void TogglePanel()
    {
        panel.SetActive(panelToggle);
        panelToggle = !panelToggle;
    }



    void OnMouseDown()
    {
        TogglePanel();
    }



    public void OnSelectFoodSales()
    {
        salesType = 1;
    }



    public void OnSelectApparelSales()
    {
        salesType = 2;
    }



    public void OnSelectElectronicsSales()
    {
        salesType = 3;
    }


}
