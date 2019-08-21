using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Tokens : MonoBehaviour
{


    public int money = 10000;
    public int energy = 0;



    public Text moneyText;
    public Text woodText;
    public Text energyText;



    void Start()
    {
        moneyText.text = money.ToString();
        woodText.text = Data.wood.ToString();
        energyText.text = Data.energy.ToString();
    }


    public void UpdateWood()
    {
        woodText.text = Data.wood.ToString(); // needs to be rewritten = wood.ToString() // allow this script to handle data
    }



    public void UpdateEnergy()
    {
        energyText.text = Data.energy.ToString(); // needs to be rewritten = energy.ToString() // allow this script to handle data
    }



    public void UpdateMoney()
    {
        moneyText.text = money.ToString();
    }


    

    
}
