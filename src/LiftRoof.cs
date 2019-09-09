using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class LiftRoof : MonoBehaviour
{

    public GameObject roof;
    bool toggle = false;

    

    public void OnMouseDown()
    {
        Debug.Log("clicked on the house");
        roof.SetActive(toggle);
        toggle = !toggle;
    }



}
