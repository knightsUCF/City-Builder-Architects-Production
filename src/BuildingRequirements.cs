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


so we have a bug -- if we place a new road element near an existing already built structure, then that structure's trigger collider registers,
and the structure changes color

we don't want that, 

so we should have a flag which detects if this structure already has been built

this will work fine, except when we later add the feature of destroying roads, which then we will need to turn the color, since a road will no
longer be close, we will cross that bridge when we get there


a big part of the solution here was using OnTriggerStay, instead of OnTriggerEnter
*/






public class BuildingRequirements : MonoBehaviour
{

    Build build;
    Material material;

    Material blueMaterial;
    Material pinkMaterial;


    public bool canBuild = false;
    public bool structureFinalized = false; // for preventing color changes when dragging over new elements with collider events on a building that's already set down


    void Start()
    {
        material = GetComponentInChildren<Renderer>().material;
        build = FindObjectOfType<Build>();

        blueMaterial = (Material)Resources.Load("Blue", typeof(Material));
        pinkMaterial = (Material)Resources.Load("Pink", typeof(Material));

        // a new game object is created when set down, so we should check if the structure is finalized before intializing to the unavailable color
        if (!structureFinalized) material.color = Color.magenta; // we should start off with the unavailable material, since if starting we never have the chance to leave a collider we will get an available color
    }




    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Road" && !structureFinalized)
        {
            canBuild = true;
            material.color = Color.grey;
        }
    }



    void OnTriggerExit(Collider c)
    {
        if (c.tag == "Road" && !structureFinalized) 
        {
            canBuild = false;
            material.color = Color.magenta; // unavailable
        }
    }


    // will also need a pair of enter and exit triggers for determining if we are building on land we purchased





}
