using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

Costs:


Hire worker: 100

House 1: 100
House 2: 200
House 3: 300


*/



public class Costs : MonoBehaviour
{

    public GameObject insufficientFundsPanel;

    Tokens tokens;


    int workerCost = 100;
    int house1Cost = 100;
    int house2Cost = 200;
    int house3Cost = 300;



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



    
    
}
