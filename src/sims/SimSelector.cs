using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class SimSelector : MonoBehaviour
{


    public GameObject panel;

    bool toggle = true;

    

    void OnMouseDown()
    {
        panel.SetActive(toggle);
        toggle = !toggle;
    }

}
