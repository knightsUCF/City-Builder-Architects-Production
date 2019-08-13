using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Tokens : MonoBehaviour
{
    public Text money;
    public Text wood;



    void Start()
    {
        money.text = Data.money.ToString();
        wood.text = Data.wood.ToString();
    }


    public void UpdateWood()
    {
        wood.text = Data.wood.ToString();
    }




    

    
}
