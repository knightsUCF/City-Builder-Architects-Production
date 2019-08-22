using System.Collections;
using System.Collections.Generic;
using UnityEngine;








public class Costs : MonoBehaviour
{

    public GameObject insufficientFundsPanel;

    Tokens tokens;


    public int workerCost = 100;
    
    public int house1Cost = 100;
    public int house2Cost = 200;
    public int house3Cost = 300;
    
    public int roadShort = 100;
    public int roadLong = 200;
    public int roadIntersection = 300;
    public int roadCurve = 100;
    public int road3Way = 150;


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



    public bool House1()
    {
        if (tokens.money >= house1Cost)
        {
            tokens.money -= house1Cost;
            tokens.UpdateMoney();
            return true;   
        }

        else
        {
            ShowInsufficientFundsPanel();
            return false;
        }
    }



    public bool House2()
    {
        if (tokens.money >= house2Cost)
        {
            tokens.money -= house2Cost;
            tokens.UpdateMoney();
            return true;   
        }

        else
        {
            ShowInsufficientFundsPanel();
            return false;
        }
    }



    public bool House3()
    {
        if (tokens.money >= house3Cost)
        {
            tokens.money -= house3Cost;
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
            return true;   
        }

        else
        {
            ShowInsufficientFundsPanel();
            return false;
        }
    }

    
}
