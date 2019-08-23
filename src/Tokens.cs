using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Tokens : MonoBehaviour
{


    public int money = 500000;
    public int energy = 0;



    public Text moneyText;
    public Text woodText;
    public Text energyText;



    void Start()
    {
        moneyText.text = Shorten(money); // money.ToString();
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
        moneyText.text = Shorten(money);
    }



    public string Shorten(int iCount)
    {
        float count = (float)iCount;

        if (count < 1000)
        {
            return count.ToString();
        }

        if (count > 1000 && count < 999000)
        {
            count = count / 1000;
            count = (float)System.Math.Round(count, 0);
            
            return count.ToString() + "K";
        }

        if (count >= 999000)
        {
            count = count / 1000000;
            count = (float)System.Math.Round(count, 0);

            return count.ToString() + "M"; 
        }

        else return "error";
        
    }



    
}
