using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class DummyAI : MonoBehaviour
{

    public Text aiMoney;

    public int money = 1000000;
    public int moneyAddition = 100000;


    public Text playerMoney;
    Tokens tokens;



    void Awake()
    {
        tokens = FindObjectOfType<Tokens>();
    }



    void Start()
    {
        InvokeRepeating("GetMoney", 0.0f, 10.0f); // start, repeat time
    }



    void GetMoney()
    {
        // money += moneyAddition;

        money = tokens.money - 1000000; // relative AI, adjust to player's progress with some sort of random range
        // difficulty can be set by finding player interval, and adjusting to this interval, have some wide random ranges
        // need to make seem as authentic as possible

        // the authentication can come in when the player stops playing or their actions go down per turn
        // so the AI will keep adding then when the player is not building
        

        aiMoney.text = "AI $: " + Shorten(money);
        playerMoney.text = "P1 $: " + Shorten(tokens.money);
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
            count = (float)System.Math.Round(count, 1);
            
            return count.ToString() + "K";
        }

        if (count >= 999000)
        {
            count = count / 1000000;
            count = (float)System.Math.Round(count, 1);

            return count.ToString() + "M"; 
        }

        else return "error";
        
    }

   
}
