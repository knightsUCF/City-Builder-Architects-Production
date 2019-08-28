using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GenerateWorld : MonoBehaviour
{

    public int worldWidth = 10;
    public int worldLength = 10;

    public int objectWidth = 30;
    public int objectLength = 30;

    public float yOffset = -0.8f; // road height could also be modified instead


    

    public GameObject FloorTile; // public GameObject[] FloorTiles;



    void Awake()
    {
        LayoutTiles();
    }



    void GenerateTile(int i, int j)
    {
        GameObject go = Instantiate(FloorTile, new Vector3((i * objectLength), yOffset, (j * objectWidth)), Quaternion.identity, this.transform);
    }



    void LayoutTiles()
    {
        for (int i = 0; i < worldWidth; i++)
        {
            for (int j = 0; j < worldLength; j++)
            {
                GenerateTile(i, j);
            }
        }
    }


}

