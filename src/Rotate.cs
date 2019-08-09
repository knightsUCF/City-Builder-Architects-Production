using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// make sure object is not static


public class Rotate : MonoBehaviour {
    
    
    public float speed = 2.0f;

    public GameObject objectToRotate;

    
    void Update ()
    {
        objectToRotate.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
