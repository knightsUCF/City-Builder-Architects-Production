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

    public Material shaderMaterial1;
    public Material shaderMaterial2;


    Shader shader1;
    Shader shader2;

    Renderer renderer;


    Material blueMaterial;
    Material pinkMaterial;


    public bool canBuild = false;
    public bool ownZonedLand = false;
    public bool waterAvailable = false;
    public bool powerAvailable = false;
    public bool extraRequirementFlag = false;

    public bool isThisPowerOrWater = false;

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
        WaterPipe,
        PowerLine,
        Land,
        Skyscraper,
        Test // anything can be built
    }

    public StructureType structureType;
    


    string zonedLand = "Land";

    

    public bool useExtraRequirement = false;
    public string extraRequirement = "...";


    MeshRenderer meshRenderer;
    // public Material[] shaderMaterials;


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

        Renderer renderer = GetComponentInChildren<Renderer>();




        // if we build a water pipe first with nothing else on the map to collide, we will never reach the water pipe set bool to true in the collision code

        if (isThisPowerOrWater)
        {
            waterAvailable = true;
            canBuild = true; // don't have to check for roads with water pipes
            extraRequirementFlag = true; // wtf
        }


        if (structureType == StructureType.Land)
        {
            // pass all the requirements to build land
            
            canBuild = true;
            ownZonedLand = true;
            waterAvailable = true;
            powerAvailable = true;
            extraRequirementFlag = true;

            meshRenderer = gameObject.GetComponentInChildren<MeshRenderer>();


        }


        // pass all the requirements for a test structure

        if (structureType == StructureType.Test)
        {
            canBuild = true;
            ownZonedLand = true;
            waterAvailable = true;
            powerAvailable = true;
            extraRequirementFlag = true;
        }


        // start off being able to build the first skyscraper anywhere, but then in the collisions we will be detecting if there are other skyscrapers and turn some of these flags off (canBuild)

        if (structureType == StructureType.Skyscraper)
        {
            canBuild = true;
            ownZonedLand = false;
            waterAvailable = true;
            powerAvailable = true;
            extraRequirementFlag = true;
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
        // Debug.Log("Reached on Trigger Stay scope");

        switch(structureType)
        {


            case StructureType.Land:

                /*
                canBuild = True;
                waterAvailable = true;
                powerAvailable = true;
                ownZonedLand = true;
                */

                // let's start by detecting if we are colliding with an already placed land tile


                // go.GetComponent<MeshRenderer>();

                // this functionality is a little different (backwards) then building houses
                // a house will want to require a road collider and etc,
                // while a land plot will want to require no other land colliders

                // backwards from other conditions because of the nature of land building (setting flag to false if we detect a land collision)

                if ((c.tag == "Land" || c.tag == "ResidentialLand" || c.tag == "CommercialLand" || c.tag == "IndustrialLand")  && !structureFinalized)
                {
                    Debug.Log("Detecting land collision!");



                    meshRenderer.material = new Material(shaderMaterial2);

                    // so here we cannot build

                    canBuild = false;













                    // let's try to switch out the shader material on the renderer

                    // https://forum.unity.com/threads/how-to-change-the-material-of-certain-element-in-mesh-renderer.334089/
                    
                    // meshRenderer[0].color = Color.magenta;

                    /*
                    public MeshRenderer meshRenderer;
                    public Material[] shaderMaterials;

                    mat = ren.materials;

                    shaderMaterials = meshRenderer.materials;
    
                    */



                    /*
                    shaderMaterials = meshRenderer.materials;

                    shaderMaterials[0].color = Color.blue;


                    
                    intMaterials = new Material[cachedMaterial.Length];

                    shaderMaterial1Instance = new Material

                    
                    for (int i = 0; i < intMaterials.Length;i++)
                    {
                        intMaterials[i] = inReplaceMat;
                    }

                    cachedRenderer.materials = intMaterials;


                    */
      
                }

                // then let's turn the color based on land collision
                

            
            break;



            case StructureType.Residential:


                if (c.tag == "Road" && !structureFinalized)
                {
                    canBuild = true;
                }

                if (c.tag == "WaterPipe" && !structureFinalized)
                {
                    waterAvailable = true;
                }

                if (c.tag == "PowerLine" && !structureFinalized)
                {
                    powerAvailable = true;
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



            case StructureType.PowerLine:


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



            case StructureType.Skyscraper:

            // let's do one standard check here that shows that we can build -- although this might just get turned on if we are touching land, so let's add that too

                if (( c.tag == "ResidentialLand" || c.tag == "CommercialLand" || c.tag == "IndustrialLand") && !structureFinalized)
                    {
                        ownZonedLand = true;
                        Debug.Log("Detecting land");
                    }

                if (ownZonedLand) material.color = Color.grey; // let's just get the building to turn gray on touch with land for now



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

                if (c.tag == "PowerLine" && !structureFinalized)
                {
                    powerAvailable = false;
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



            case StructureType.PowerLine:


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


            case StructureType.Land:


                if ((c.tag == "Land" ||c.tag == "ResidentialLand" || c.tag == "CommercialLand" || c.tag == "IndustrialLand")  && !structureFinalized) 
                {
                    meshRenderer.material = new Material(shaderMaterial1);
                    canBuild = true;
                }

            break;



            case StructureType.Skyscraper:

                // the first thing is being able to turn the color pink, and let the user know they cannot build there -- for now we are assuming all land is residential
                // if we want to have geeneric land we should do c.tag == "Land" and change the tag on the tile

                if (( c.tag == "ResidentialLand" || c.tag == "CommercialLand" || c.tag == "IndustrialLand") && !structureFinalized)
                {
                    ownZonedLand = false;
                    material.color = Color.magenta;
                }




            break;
        }

    }



}
