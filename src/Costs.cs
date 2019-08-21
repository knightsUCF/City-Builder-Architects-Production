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


    void Awake()
    {
        tokens = FindObjectOfType<Tokens>();
    }


    void Start()
    {
        GetTotalMoney();
    }



    void GetTotalMoney()
    {
        Debug.Log(tokens.money);
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

    
    void ShowInsufficientFundsPanel()
    {
        insufficientFundsPanel.SetActive(true);
        Invoke("HideInsufficientFundsPanel", 1);
    }


    void HideInsufficientFundsPanel()
    {
        insufficientFundsPanel.SetActive(false);
    }

}
