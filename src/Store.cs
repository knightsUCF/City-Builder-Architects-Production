using System.Collections;
using System.Collections.Generic;
using UnityEngine;




// even though the player might switch their production structures they are just paid out during the game time turn





public class Store : MonoBehaviour
{

    public GameObject panel;

    bool panelToggle = false;


    public enum Product {
        Food,
        Apparel,
        Electronics
    }

    public Product product;

    Market market;



    void Awake()
    {
        market = FindObjectOfType<Market>();
    }



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
        market.UpdateMarket();
        TogglePanel();
    }



    public void OnSelectApparelSales()
    {
        product = Product.Apparel;
        market.UpdateMarket();
        TogglePanel();
    }



    public void OnSelectElectronicsSales()
    {
        product = Product.Electronics;
        market.UpdateMarket();
        TogglePanel();
    }




    


}
