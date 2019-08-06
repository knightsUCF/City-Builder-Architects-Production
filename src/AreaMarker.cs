using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

Circular particle effect

https://assetstore.unity.com/packages/vfx/particles/ktk-effect-sample-set-25081

later search for more paid particle effect assets if needed

This is the prefab "Eff heal 2"

Turn off everything except "ring" and turn off "emission" on the ring to only be left with the ring

Change the start size to (on the parent ring particle effect, not the child) 7, since scaling will not work for this particle effect


*/



public class AreaMarker : MonoBehaviour
{

    public GameObject marker;

    Ray ray;
    RaycastHit hitInfo;
    GameObject go;




    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseToArea();
        }
    }



    void MouseToArea()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.transform.gameObject.tag != "Worker")
            {
                CastMarker(hitInfo.point);
            }
        } 
    }



    void CastMarker(Vector3 clickPoint)
    {
        go = (GameObject)Instantiate(marker, clickPoint, Quaternion.identity, this.transform);
    }
    
}
