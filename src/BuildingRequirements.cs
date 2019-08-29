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
    public bool ownZonedLand = false;
    public bool waterAvailable = false;
    public bool extraRequirementFlag = false;

    public bool isThisAWaterPipe = false;

    public bool structureFinalized = false; // for preventing color changes when dragging over new elements with collider events on a building that's already set down



    [System.Serializable]
    public enum landType
    {
        Residential,
        Commercial,
        Industrial
    };

    public landType zoneType;


    public enum StructureType
    {
        Residential,
        WaterPipe
    }

    public StructureType structureType;
    


    string zonedLand = "Land";

    

    public bool useExtraRequirement = false;
    public string extraRequirement = "...";


    /*
    void Update()
    {
        Debug.Log("canBuild: " + canBuild);
        Debug.Log("ownZonedLand: " + ownZonedLand);
        Debug.Log("waterAvailable: " + waterAvailable);
    }
    */





    void Start()
    {

        // if we build a water pipe first with nothing else on the map to collide, we will never reach the water pipe set bool to true in the collision code

        if (isThisAWaterPipe) 
        {
            waterAvailable = true;
            extraRequirementFlag = true; // wtf
        }

        

        material = GetComponentInChildren<Renderer>().material;
        build = FindObjectOfType<Build>();

        blueMaterial = (Material)Resources.Load("Blue", typeof(Material));
        pinkMaterial = (Material)Resources.Load("Pink", typeof(Material));

        // a new game object is created when set down, so we should check if the structure is finalized before intializing to the unavailable color
        if (!structureFinalized) material.color = Color.magenta; // we should start off with the unavailable material, since if starting we never have the chance to leave a collider we will get an available color
    

        if (zoneType == landType.Residential)
        {
            zonedLand = "ResidentialLand";
        }

        if (zoneType == landType.Commercial)
        {
            zonedLand = "CommercialLand";
        }

        if (zoneType == landType.Industrial)
        {
            zonedLand = "IndustrialLand";
        }

    }




    void OnTriggerStay(Collider c)
    {
        Debug.Log("Reached on Trigger Stay scope");

        switch(structureType)
        {
            case StructureType.Residential:


                if (c.tag == "Road" && !structureFinalized)
                {
                    canBuild = true;
                }

                if (c.tag == "WaterPipe" && !structureFinalized)
                {
                    waterAvailable = true;
                }

                if (c.tag == zonedLand && !structureFinalized)
                {
                    ownZonedLand = true;
                }

                if (useExtraRequirement)
                {
                    if (c.tag == extraRequirement && !structureFinalized)
                    {
                        extraRequirementFlag = true;
                    }
                    // else extraRequirementFlag = false;

                }

                if (!useExtraRequirement) extraRequirementFlag = true;

                if (canBuild && ownZonedLand && extraRequirementFlag && waterAvailable) material.color = Color.grey;

                // Debug.Log("canBuild: " + canBuild);
                // Debug.Log("ownZonedLand: " + ownZonedLand);
                // Debug.Log("extraRequirementFlag: " + extraRequirementFlag);

            break;



            case StructureType.WaterPipe:

                Debug.Log("WATER SCOPE!!!");

                canBuild = true; // don't have to check for roads with water pipes
                waterAvailable = true; // we don't need to check for other water pipes, perhaps water plants later


                if (( c.tag == "ResidentialLand" || c.tag == "CommercialLand" || c.tag == "IndustrialLand") && !structureFinalized)
                {
                    ownZonedLand = true;
                }

                if (useExtraRequirement)
                {
                    if (c.tag == extraRequirement && !structureFinalized)
                    {
                        extraRequirementFlag = true;
                    }
                    // else extraRequirementFlag = false;

                }

                if (!useExtraRequirement) extraRequirementFlag = true;

                if (canBuild && ownZonedLand && extraRequirementFlag) material.color = Color.grey;


            break; 


        }


        
    }



    void OnTriggerExit(Collider c)
    {
        switch(structureType)
        {
            case StructureType.Residential:



                if (c.tag == "Road" && !structureFinalized) 
                {
                    canBuild = false;
                    material.color = Color.magenta;
                }

                if (c.tag == zonedLand && !structureFinalized) 
                {
                    ownZonedLand = false;
                    material.color = Color.magenta;
                }

                if (c.tag == "WaterPipe" && !structureFinalized)
                {
                    waterAvailable = false;
                    material.color = Color.magenta;
                }



                if (useExtraRequirement)
                {
                    if (c.tag == extraRequirement && !structureFinalized)
                    {
                        extraRequirementFlag = false;
                        material.color = Color.magenta;
                    }
                }

                // Debug.Log("canBuild: " + canBuild);
                // Debug.Log("ownZonedLand: " + ownZonedLand);
                // Debug.Log("extraRequirementFlag: " + extraRequirementFlag);

            break;



            case StructureType.WaterPipe:


                if (( c.tag == "ResidentialLand" || c.tag == "CommercialLand" || c.tag == "IndustrialLand") && !structureFinalized)
                {
                    ownZonedLand = false;
                    material.color = Color.magenta;
                }

                if (useExtraRequirement)
                {
                    if (c.tag == extraRequirement && !structureFinalized)
                    {
                        extraRequirementFlag = false;
                        material.color = Color.magenta;
                    }
                }


            break;

        }

    }



}
