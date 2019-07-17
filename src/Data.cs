using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*


- adding tile data:

roadTileMapPos = new Vector2(start.x, (float)(i * size));

if (!Data.map.ContainsKey(roadTileMapPos))

{
    Data.map.Add(roadTileMapPos, 3);
}







*/





public class Data : Singleton<Data>
{



    public enum StructureSelection
    {
        none,
        house,
        road
    }

    public static StructureSelection structureSelection;


    // map data


    /*
    we want a list, where we can just add the x and y coordinates as the index, this way we can decouple the functionality, and just always be able to add new data by the 2D index, so a vector2
    so we want a vector2 as one type, and then an integer as the other type, since we will be using integers instead of strings for a speed difference, if there is one
    USE 
    Vector2 v = new Vector2(0, 0);
    Data.map.Add(v, 1);
    Debug.Log(Data.map[v]);
    1 - house
    2 - skyscraper
    3 - road
    */


    public static Dictionary <int, Vector2> roadMap = new Dictionary<int, Vector2>();




    public static bool[] unlockedTechnologies;







    
    
    

}
