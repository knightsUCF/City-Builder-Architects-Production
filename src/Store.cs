using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// even though the player might switch their production structures they are just paid out during the game time turn





public class Store : MonoBehaviour
{

    public GameObject panel;

    bool panelToggle = false;


    enum Product {
        Food,
        Apparel,
        Electronics
    }

    private Product product;



    void TogglePanel()
    {
        panel.SetActive(panelToggle);
        panelToggle = !panelToggle;
    }



    void OnMouseDown()
    {
        TogglePanel();
    }



    // drag these into the buttons

    public void OnSelectFoodSales()
    {
        product = Product.Food;
        UpdateMarket();
        TogglePanel();
    }



    public void OnSelectApparelSales()
    {
        product = Product.Apparel;
        UpdateMarket();
        TogglePanel();
    }



    public void OnSelectElectronicsSales()
    {
        product = Product.Electronics;
        UpdateMarket();
        TogglePanel();
    }




    void UpdateMarket()
    {
        switch (product)
        {
            case Product.Food:
                Market.foodProductionStructure += 1;
                break;

            case Product.Apparel:
                Market.apparelProductionStructure += 1;
                break;

            case Product.Electronics:
                Market.electronicsProductionStructure += 1;
                break;
        }
    }


}
