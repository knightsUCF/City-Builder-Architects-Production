using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/*

okay, so we want to place an object, on a grid [ X ]

drag the object around [  ]

finalize the object [  ]





*/


public class Build : MonoBehaviour
{

    public float gridSize = 10.0f;
    public GameObject particle;
    RaycastHit hitInfo;
    Ray ray;
    GameObject GO;
    Touch touch;
    Vector3 result;
    bool haveWeBuiltAlready = false;



    void Update()
    {
        if (!haveWeBuiltAlready) SetStartingPlacement();
        DragStructureAround();
    }



    void SetStartingPlacement()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hitInfo)) 
                {
                    PlaceStructure(hitInfo.point, particle);
                    haveWeBuiltAlready = true;
                }
            }
        }
    }



    Vector2 PlaceStructure(Vector3 clickPoint, GameObject gameObject)
    {
        var finalPosition = GetNearestPointOnGrid(clickPoint);
        GO = (GameObject)Instantiate(gameObject, finalPosition, Quaternion.identity, this.transform);
        return (Vector2)finalPosition;
    }



    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;
        int xCount = Mathf.RoundToInt(position.x / gridSize);
        int zCount = Mathf.RoundToInt(position.z / gridSize);
        int yCount = 0;
        result = new Vector3((float)xCount * gridSize, (float)yCount, (float)zCount * gridSize);
        result += transform.position;
        return result;
    }



    void DragStructureAround()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            ray = Camera.main.ScreenPointToRay(touch.position);
            if (touch.phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hitInfo))
                {
                    var gridPos = GetNearestPointOnGrid(hitInfo.point);
                    GO.transform.position = gridPos;
                    // IsBuildingAreaFree();
                }
            }
        }
    }

}
