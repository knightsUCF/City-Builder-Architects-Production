using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TrafficSystem : MonoBehaviour
{


    Build build;


    public Vector2 startWaypoint;
    public Vector2 endWaypoint;


    public GameObject waypoint1;
    public GameObject waypoint2;

    float startX, startZ, endX, endZ;

    public GameObject cars;

    public GameObject car1;
    public GameObject car2;






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

        endWaypoint = Data.roadMap[build.roadTileIndex];

        
        Vector3 startPos = new Vector3(startWaypoint.x, 0.0f, startWaypoint.y);
        Vector3 endPos = new Vector3(endWaypoint.x, 0.0f, endWaypoint.y);

        waypoint1.transform.position = startPos;
        waypoint2.transform.position = endPos;

        // let's activate the cars

        if (cars.activeSelf == false)
        {
            cars.SetActive(true);

            // set starting pos of the cars

            car1.transform.position = startPos;
            car2.transform.position = startPos;


        }




        /*
        startX = waypoint1.transform.position.x;
        startZ = waypoint1.transform.position.z;

        endX = waypoint2.transform.position.x;
        endZ = waypoint2.transform.position.z;

        startX = startWaypoint.x;
        startZ = startWaypoint.y;

        endX = endWaypoint.x;
        endZ = endWaypoint.y;
        */





        














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
        // 3. under the Waypoints Holder parent, create a game object for each way point, each one gets the "Waypoint" tag
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
        // 3a. Each trigger 1, trigger 2, etc, gets a "Junction" tag
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

        // To make cars & junctions work you need to create tags: 'Waypoint' and 'Junction'

        // Also you need to create layer: 'Car'
        // As you get 'Waypoint' tags are used by waypoint triggers, and 'Junction' tags are used by junction triggers
        // Cars are set on 'Car' layer and in their 'Car AI' script in 'Deceleration Layer' is chosen 'Car' too, 
        // so car's will see each-other and won't collide/go through each-other.

        // Okay, let's start off by dragging the car prefab into the hierarchy, which should already contain:
        // rigidbody, (is kinematic - true), box collider (is trigger checked off), Car AI script, with Waypoints holder 1 transform



        // S T E P S 

        // 1. Drag car onto the hierarchy (set car to "Car" layer, and also set deceleration to "Car" layer so cars don't collide)
        // 2. Create Waypoints 1 parent game object
        // 3. Create cube game object under Waypoints 1 parent game object
        // 4. Turn off mesh renderer
        // 5. Check is trigger for box collider
        // 6. Add "Waypoint" script
        // 7. Adjust the transform position of the waypoint
        // 8. Repeat for set of waypoints


        // Drag the Waypoints 1 parent game object into the Car waypoints slot

        // Set the start waypoints index on the car to 1
















    











    }



}
