using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class StartingTokens : MonoBehaviour
{
    public Text money;



    void Start()
    {
        money.text = Data.money.ToString();
    }

    
}
