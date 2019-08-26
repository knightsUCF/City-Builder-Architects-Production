using System.Collections;
using System.Collections.Generic;
using UnityEngine;








public class Costs : MonoBehaviour
{

    public GameObject insufficientFundsPanel;

    Tokens tokens;


    public int workerCost = 100;

    public int house1 = 100000;
    public int house2 = 200;
    public int house3 = 300;
    
    public int roadShort = 100;
    public int roadLong = 50000;
    public int roadIntersection = 300;
    public int roadCurve = 100;
    public int road3Way = 150;


    public int land = 500000;

    public int currentlySelectedBuildingCost = 0; // so that we can give back the building cost if the player deselects a building
    


    void Awake()
    {
        tokens = FindObjectOfType<Tokens>();
    }



    void ShowInsufficientFundsPanel()
    {
        insufficientFundsPanel.SetActive(true);
        Invoke("HideInsufficientFundsPanel", 1);
    }



    void HideInsufficientFundsPanel()
    {
        insufficientFundsPanel.SetActive(false);
    }



    // return bool, this way any script can check if we have sufficient funds

    public bool Worker()
    {
        if (tokens.money >= workerCost)
        {
            tokens.money -= workerCost;
            tokens.UpdateMoney();
            return true;   
        }

        else
        {
            ShowInsufficientFundsPanel();
            return false;
        }
    }



    // rewrite the above methods to just use Purchasable()

    public bool Purchasable(int cost)
    {
        if (tokens.money >= cost)
        {
            tokens.money -= cost;
            tokens.UpdateMoney();

            currentlySelectedBuildingCost = cost;

            return true;   
        }

        else
        {
            currentlySelectedBuildingCost = 0; // just in case but might not need

            ShowInsufficientFundsPanel();
            return false;
        }
    }


    public void Refund(int cost)
    {
        tokens.money += cost;
        tokens.UpdateMoney();
    }

    
}
