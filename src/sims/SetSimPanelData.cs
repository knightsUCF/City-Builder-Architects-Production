using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SetSimPanelData : MonoBehaviour
{

    SimData simData;



    void Awake()
    {
        simData = GetComponent<SimData>();
    }


    
}
