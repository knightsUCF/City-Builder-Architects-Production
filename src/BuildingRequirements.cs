using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/*

Different proximity requirements

1) is building close enough next to a road to build

2) is building overlapping another building

3) is the building properly zoned



Case 1 -  is building close enough next to a road to build


The road will be the one with the large collider

So put an is trigger collider on the road, and make the collider large enough for the area



For this setup to work need:

- place box collider (is trigger checked) on parent game object of the road
- place box collider (is trigger unchecked) on parent game object of the building (house)
- and place a rigidbody (use gravity unchecked, kinematic checked) on the parent game object of the building (house)
*/






public class BuildingRequirements : MonoBehaviour
{


    Build build;
    Material material;

    Material blueMaterial;
    Material pinkMaterial;




    public bool canBuild = false;


    void Start()
    {
        material = GetComponentInChildren<Renderer>().material;
        build = FindObjectOfType<Build>();

        blueMaterial = (Material)Resources.Load("Blue", typeof(Material));
        pinkMaterial = (Material)Resources.Load("Pink", typeof(Material));
        

        // set the blue color alpha

        // blueColor.a = 0.26f;

    }
    


    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Road") // not working, TODO for later && !build.start) // check build start so we don't overwrite the material color once we set the building down
        {
            canBuild = true;
            material.color = Color.grey; // available
            // material = blueMaterial;
        }
    }



    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Road")
        {
            canBuild = false;
            material.color = Color.magenta; // unavailable
            // material = pinkMaterial;
        }
    }


    /* https://answers.unity.com/questions/1010797/directly-assigning-material-through-renderermateri.html

    public void SetMaterials(Material newMaterial)
    {
        
        for(int i = 0; i < renderers.Length; ++i)
        {
            Material[] materials = new Material[renderers[i].materials.Length]; // <-- CREATING THE TEMPORARY ARRAY
            
            for (int j = 0; j < materials.Length; ++j)
            {
                materials[j] = newMaterial;
            }
            
            renderers[i].materials = materials;
        }
    }

    */



    // will also need a pair of enter and exit triggers for determining if we are building on land we purchased






}
