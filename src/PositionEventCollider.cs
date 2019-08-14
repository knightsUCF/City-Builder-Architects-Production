using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PositionEventCollider : MonoBehaviour
{

    public string eventName;
    public string tag;

    bool runOnce = true;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag && runOnce)
        {
            EventManager.TriggerEvent(eventName);
            runOnce = false;
        }
    }
}
