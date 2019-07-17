using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TrafficSystem : MonoBehaviour
{


    Build build;


    Vector2 startJunction;
    Vector2 endJunction;


    void Awake()
    {
        build = FindObjectOfType<Build>();
    }


    
    public void UpdateTrafficSystem()
    {
        // gets called every time we finalize a traffic tile

        // we want to recalculate the traffic paths, and then run the appropriate traffic methods

        // all of our data is in Data.map

        // so now we want to trace this map data to determine the vectors of traffic


        // like Carmack said, there is no secret efficient algo, so just write this from scratch


        // first let's determine a simple line, the simplest traffic lane we can build


        // let's determine, the start, the middle, and the end, and then populate traffic

        // we will have to do intersections next, but just one thing at a time for now

        // also how will the systme react if we add new roads while the cars are already moving


        foreach (KeyValuePair<int, Vector2> value in Data.roadMap)
        {
            Debug.Log("key: " + value.Key);
            Debug.Log("value: " + value.Value);
        }



        // so here we are going to update the junction vector segment, by taking the position of the x at 0, up to x at last index



        // get the key at value 0

        

        startJunction = Data.roadMap[0];


        Debug.Log("start junction: " + startJunction);


        endJunction = Data.roadMap[build.roadTileIndex];

        
        Debug.Log("end junction: " + endJunction);



        // the difference in x, (y is constant), is our vector junction


        




    











    }



}
