using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PositionEventCollider : MonoBehaviour
{

    public string eventName;
    public string tag;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            EventManager.TriggerEvent(eventName);
        }
    }
}
