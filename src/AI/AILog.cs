using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class AILog : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;


    public void LogText(string text)
    {
        text1.text = text2.text;
        text2.text = text3.text;
        text3.text = text;
    }
}
