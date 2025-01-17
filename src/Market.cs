using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// supply demand tracker of goods


public class Market : MonoBehaviour
{

    public GameObject[] stores;


    public int totalFoodStores = 0;
    public int totalApparelStores = 0;
    public int totalElectronicsStores = 0;



    public void UpdateMarket()
    {

        totalFoodStores = 0;
        totalApparelStores = 0;
        totalElectronicsStores = 0;


        stores = GameObject.FindGameObjectsWithTag("Store");

        foreach (GameObject store in stores)
        {
            if (store.GetComponent<Store>().product == Store.Product.Food)
            {
                totalFoodStores += 1;
            }

            if (store.GetComponent<Store>().product == Store.Product.Apparel)
            {
                totalApparelStores += 1;
            }

            if (store.GetComponent<Store>().product == Store.Product.Electronics)
            {
                totalElectronicsStores += 1;
            }
        }
    }
}





