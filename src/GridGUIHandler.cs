using System.Collections;
using System.Collections.Generic;
using UnityEngine;







public class GridGUIHandler : MonoBehaviour
{

    public float gridSize = 10.0f;

    public AudioClip select;



    public GameObject standardGrid;
    public GameObject landParcel;

    GameObject GO;
    GameObject finalGO;

    Ray ray;
    Vector3 closestVector;
    RaycastHit hitInfo;

    Vector3 lastGridPos = new Vector3(0.0f, 0.0f, 0.0f);
    Vector3 newGridPos = new Vector3(0.0f, 0.0f, 0.0f);

    bool standardGridToggle = false;
    bool buyLandGridToggle = false;
    
    bool startDraggingBuyLandSelector = false;


    Costs costs;
    LandType landType;
    ZoneLand zoneLand;
    



    void OnEnable()
    {
        EventManager.StartListening("StandardGridClicked", StandardGridClickedEvent);
        EventManager.StartListening("BuyLandGridClicked", BuyLandGridClickedEvent);
    }



    void OnDisable()
    {
        EventManager.StopListening("StandardGridClicked", StandardGridClickedEvent);
        EventManager.StopListening("BuyLandGridClicked", BuyLandGridClickedEvent);
    }



    void Awake()
    {
        costs = FindObjectOfType<Costs>();
        zoneLand = FindObjectOfType<ZoneLand>();
    }







    void StandardGridClickedEvent()
    {
        if (!standardGridToggle)
        {
            standardGrid.SetActive(true);
        }

        if (standardGridToggle)
        {
            standardGrid.SetActive(false);
        }

        standardGridToggle = !standardGridToggle;

    }



    void BuyLandGridClickedEvent()
    {
        if (costs.Purchasable(costs.land))
        {
            if (!buyLandGridToggle)
            {
                landParcel.SetActive(true);
                // GO = landParcel;
                CreateGameObject(landParcel);
                startDraggingBuyLandSelector = true;
                destroyToggle = false;
            }

            else if (buyLandGridToggle)
            {
                landParcel.SetActive(false);
                startDraggingBuyLandSelector = false;
            }

            if (destroyToggle) buyLandGridToggle = !buyLandGridToggle;
        }

    }


    Vector3 tempPos = new Vector3(0.0f, 0.0f, 0.0f);

    public void CreateGameObject(GameObject go)
    {
        GO = Instantiate(go, tempPos, Quaternion.identity, this.transform);
        landParcel.SetActive(false);
    }



    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;
        int xCount = Mathf.RoundToInt(position.x / gridSize);
        int zCount = Mathf.RoundToInt(position.z / gridSize);
        int yCount = 0;
        closestVector = new Vector3((float)xCount * gridSize, (float)yCount, (float)zCount * gridSize);
        closestVector += transform.position;
        return closestVector;
    }




    void MoveBuildingToDragPoint()
    {
        if (Physics.Raycast(ray, out hitInfo))
        {
            var gridPos = GetNearestPointOnGrid(hitInfo.point);
            GO.transform.position = gridPos;
            newGridPos = gridPos;
            if (lastGridPos != newGridPos)
            {
                SoundManager.instance.PlaySingle(select, 0.3f);
                lastGridPos = newGridPos;
            }
        }
    }



    void Drag()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        MoveBuildingToDragPoint();
        
        
        
        if (Input.GetMouseButtonDown(0)) //  && buildingRequirements.canBuild)
        {
            FinalizeBuilding(); // for desktop we finalize building by clicking - we could also tap for the mobile version
        }
        
        
        if (Input.GetMouseButtonDown(1)) DestroyStructure();

  
    }


    void FinalizeBuilding()
    {
        Vector3 finalizedPosition; // not to be confused with finalPosition
        finalizedPosition = GO.transform.position;
        Quaternion finalizedRotation = GO.transform.rotation;

        finalizedPosition.y -= 1.1f;

        Destroy(GO);

        
        finalGO = (GameObject)Instantiate(landParcel, finalizedPosition, finalizedRotation, this.transform);


        landType = landParcel.GetComponent<LandType>();



        if (zoneLand.iCurrentlySelectedZone == 1)
        {
            // Debug.Log("Residential!");
            landType.zoneType = LandType.landType.Residential;
            finalGO.tag = "ResidentialLand";
        }

        if (zoneLand.iCurrentlySelectedZone == 2)
        {
            // Debug.Log("Commercial!");
            landType.zoneType = LandType.landType.Commercial;
            finalGO.tag = "CommercialLand";
        }

        if (zoneLand.iCurrentlySelectedZone == 3)
        {
            // Debug.Log("Industrial!");
            landType.zoneType = LandType.landType.Industrial;
            finalGO.tag = "IndustrialLand";
        }


        
        


        /*
        if (zoneLand.currentlySelectedZone == ZoneLand.CurrentlySelectedZone.Residential)
        {
            landType.zoneType = LandType.landType.Residential;
            finalGO.tag = "ResidentialLand";
        }

        if (zoneLand.currentlySelectedZone == ZoneLand.CurrentlySelectedZone.Commercial)
        {
            landType.zoneType = LandType.landType.Commercial;
            finalGO.tag = "CommercialLand";
        }

        if (zoneLand.currentlySelectedZone == ZoneLand.CurrentlySelectedZone.Industrial)
        {
            landType.zoneType = LandType.landType.Industrial;
            finalGO.tag = "IndustrialLand";
        }
        */
        


        finalGO.SetActive(true);
        


        /*
        // for preventing the structure changing colors on collider event when we have already set down the building
        buildingRequirements = finalGO.GetComponent<BuildingRequirements>();
        buildingRequirements.structureFinalized = true;


        start = false;

        */

        // mobileTouchCamera.lockCamera = false;

        // GetComponent<AudioSource>().PlayOneShot(finalizedBuilding, volume);
    }


    bool destroyToggle = false;

    public void DestroyStructure()
    {
        costs.Refund(costs.land); // give back the money on canceling building
        // mobileTouchCamera.lockCamera = false;
        Destroy(GO);
        destroyToggle = true;
    }




    void Update()
    {
        if (startDraggingBuyLandSelector && GO != null)
        {
            Drag();
        }
    }








}
