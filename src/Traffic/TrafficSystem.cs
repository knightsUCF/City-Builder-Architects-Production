using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TrafficSystem : MonoBehaviour
{


    Build build;


    Vector2 startWaypoint;
    Vector2 endWaypoint;


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


        /*
        foreach (KeyValuePair<int, Vector2> value in Data.roadMap)
        {
            Debug.Log("key: " + value.Key);
            Debug.Log("value: " + value.Value);
        }
        */



        // so here we are going to update the junction vector segment, by taking the position of the x at 0, up to x at last index



        // get the key at value 0

        

        startWaypoint = Data.roadMap[0];


        Debug.Log("start junction: " + startWaypoint);


        endWaypoint = Data.roadMap[build.roadTileIndex];

        
        Debug.Log("end junction: " + endWaypoint);


        // the difference in x, (y is constant), is our vector waypoint


        // here we can also make a requirement to have a min number of road tiles before populating traffic

        // start vector: startWaypoint.x
        // end vector: endWaypoint.x

        // there are actually two way points on the corner of a turn, we can adjust this manually

        // so each segment has two way points, a connecting segment will have an extra waypoint at the connection

        // junctions are intersections


        // Creating Waypoints

        // 1. create a GameObject called "Waypoints Holder"
        // 2. attach WaypointsHolder script
        // 3. under the Waypoints Holder parent, create a game object for each way point
        // 4. a waypoint is a cube with the mesh renderer turned off, and the box collider turned on and set to trigger
        // 5. attach a "waypoint" script to each of these cube waypoints


        // Creating Cars

        // 1. Create parent "Cars" game object
        // 2. Under parent Cars game object prefab, create children prefabs for each individual car
        // 3. Every individual car gets: Rigidbody, is kinematic turned on, box collider (is trigger turned off), and a Car AI script
        // 4. The car AI script gets a Waypoitns Holder 2 Transform, with loop check and the other settings, the car prefabs might already exist


        // Creating Junctions

        // 1. Create parent "Junction" game object
        // 2. Attach "Junction Controller" script to the parent Junction game object
        // 3. In the example there are 4 junctions, with trigger 1, script, up to trigger 4 scripts dragged in
        // 4. the green light time is 5, and the yellow light time is 2
        // 5. Actually the trigger junctions are game objects with scripts attached...
        // 6. Seems like each trigger is on the right side of the road, right by the lights
        // 7. A trigger is a child game object of the parent "Junction" game object
        // 8. The trigger game object is a cube with the mesh renderer turned off, and a box collider with is trigger checked to true
        // 9. The trigger game object receives a "Junction" script with a traffic light slot that is dragged in, from the traffic prefab we will go over next, which is also a child of the Junction parent
        // 10. Free is check, and waiting is check off under the trigger
        // 11. Redlight mat num is 1, yellow light mat number is 2, and green light mat num is 3

        // 12. After we finish the traffic section, then this whole trigger prefab is dragged into the parent Junction slot

        // 13. Traffic light is a prefab, might be able to just drag this from the project folder
        // 14. Populate "trigger" with traffic light, and then drag trigger to the junction


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Okay, let's start off by dragging the car prefab into the hierarchy, which should already contain:
        // rigidbody, (is kinematic - true), box collider (is trigger checked off), Car AI script, with Waypoints holder 1 transform

        











    











    }



}
