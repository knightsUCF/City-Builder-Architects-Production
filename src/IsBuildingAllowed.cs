using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*

- attach to prefab structure object
- attach rigid body (no gravity) to structure
- attach box collider, and check "is trigger"

- need to attach this to BOTH the available and unavailable model
- BOTH models need to be tagged as "Road"
- BOTH need rigid bodies

*/


public class IsBuildingAllowed : MonoBehaviour
{
    
    /*
    public GameObject platform;

    public Material unavailableMaterial;
    public Material availableMaterial;
    private Material material;

    bool available = false;
    */



    // public GameObject availableModel;
    // public GameObject unavailableModel;
    

    public GameObject unavailableModel;
    public GameObject availableModel;

    // private BoxCollider boxCol;


    public bool finalized = false;

    public bool allowed = true;





    void Awake()
    {
        // material = GetComponent<Renderer>().material;
        // material.color = Color.yellow;
        // unavailableModel.SetActive(false);

        // boxCol = availableModel.GetComponent<BoxCollider>();
    }

    


    void OnTriggerEnter(Collider collider)
    {

        if (collider.GetComponent<Collider>().gameObject.tag == "Road")
        {

            if (!finalized)
            {
                Debug.Log("Entering road collision");

                allowed = false;

                availableModel.SetActive(false);
                unavailableModel.SetActive(true);
            }

            

    
            /*
            if (platform != null)
            {
                Debug.Log("Entering road collision");
                // platform.GetComponent<MeshRenderer>().material = unavailableMaterial;
            }
            */
            
        }
    }


    void OnTriggerExit(Collider collider)
    {
        if (collider.GetComponent<Collider>().gameObject.tag == "Road")
        {
            Debug.Log("LEAVING");
            if (!finalized)
            {
                Debug.Log("Leaving road collision");

                allowed = true;

                unavailableModel.SetActive(false);
                availableModel.SetActive(true);
            }

            
            

            /*
            if (platform != null)
            {
                Debug.Log("Leaving road collision");
                // platform.GetComponent<MeshRenderer>().material = availableMaterial;
            }
            */
            
        }
    }


}
