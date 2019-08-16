using System.Collections;
using System.Collections.Generic;
using UnityEngine;






public class KeyboardManager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("escape") || Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
