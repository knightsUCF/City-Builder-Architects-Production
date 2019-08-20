using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// supply demand tracker of goods


public class Market : MonoBehaviour
{

    public GameObject[] stores;


    int totalFoodStores = 0;
    int totalApparelStores = 0;
    int totalElectronicsStores = 0;



    public void UpdateMarket()
    {
        
        stores = GameObject.FindGameObjectsWithTag("Store");

        foreach (GameObject store in stores)
        {
            if (store.GetComponent<Store>().product == Store.Product.Food)
            {
                // totalFoodStores += 1;
                Debug.Log("Incrementing food production!");
            }

            if (store.GetComponent<Store>().product == Store.Product.Apparel)
            {
                // totalFoodStores += 1;
                Debug.Log("Incrementing apparel production!");
            }

            if (store.GetComponent<Store>().product == Store.Product.Electronics)
            {
                // totalFoodStores += 1;
                Debug.Log("Incrementing electronics production!");
            }
        }
    }


}





