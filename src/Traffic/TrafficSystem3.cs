using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/*

"Doesn't cost anymore to make a game epic rather than non epic"
"Our gift was knowing what to steal from other games" 
"Tech tree and diplomacy, fairly uncommon in games"
"Did research in children's library section, things that everyone knows about and feels smart about because they're familiar with them"
"Don't take the agency away from the player, let the player have the fun, not the designer having the fun"
"Educaintment!"
"Education is a dirty word, but learning is a secret aspect that brings you back to bring more to learn more about yourself"
"one third is core game, cities, wonders, pieces, another third is taking ideas experimented with before esponiage, combat, and making that better, and then another third is things we haven't put in the game, that is what guides the next iteration, enough novelty, and enough core  of the tested gameplay"

- Sid Meier

*/


public class TrafficSystem3 : MonoBehaviour
{
    public int offset = 8;
    public int mapStart = -2;
    public int mapEnd = 100;

    public int junctionCount = 0;

    int indexEndpointOfList = 1;

    int minSequence = 1;

    List<int> aSequence = new List<int>();


    bool done = false;
    bool isLastPosInList = false;

    


    int endpoint = 1;
    int lastEndpoint = 0;



    public GameObject cars;

    public GameObject car1;
    public GameObject car2;

    Vector3 startPos;

    public GameObject waypoint;





    void Start()
    {
        // Test();
        // UpdateTrafficSystem();
    }



    void Test()
    {
        Vector2 v1 = new Vector2(-58.0f, 20.0f);
        Vector2 v2 = new Vector2(-58.0f, 22.0f);
        Vector2 v3 = new Vector2(-50.0f, 22.0f);
        Vector2 v4 = new Vector2(-42.0f, 22.0f);
        
        Vector2 v5 = new Vector2(-34.0f, 22.0f);
        Vector2 v6 = new Vector2(-100.0f, 22.0f);
        Vector2 v7 = new Vector2(-200.0f, 30.0f);
        Vector2 v8 = new Vector2(-300.0f, 30.0f);

        Vector2 v9 = new Vector2(-26.0f, 22.0f);
        Vector2 v10 = new Vector2(-18.0f, 22.0f);
        Vector2 v11 = new Vector2(-10.0f, 20.0f);
        Vector2 v12 = new Vector2(-2.0f, 22.0f);

        Vector2 v13 = new Vector2(-100.0f, 30.0f);
        Vector2 v14 = new Vector2(-92.0f, 30.0f);
        Vector2 v15 = new Vector2(-84.0f, 30.0f);
        Vector2 v16 = new Vector2(-76.0f, 30.0f);

        Vector2 v17 = new Vector2(6.0f, 22.0f);
        Vector2 v18 = new Vector2(14.0f, 22.0f);
        Vector2 v19 = new Vector2(22.0f, 22.0f);
        Vector2 v20 = new Vector2(30.0f, 22.0f);

        Vector2 v21 = new Vector2(0.0f, -2.0f);
        Vector2 v22 = new Vector2(8.0f, -2.0f);
        Vector2 v23 = new Vector2(16.0f, -2.0f);
        Vector3 v24 = new Vector2(24.0f, -2.0f);

        Vector2 v25 = new Vector2(31.0f, -2.0f);
        Vector2 v26 = new Vector2(41.0f, -2.0f);
        Vector2 v27 = new Vector2(48.0f, -2.0f);
        Vector3 v28 = new Vector2(56.0f, -2.0f);
        Vector3 v29 = new Vector2(64.0f, -2.0f);
        Vector3 v30 = new Vector2(72.0f, -2.0f);


        // testing for rows - x must be the same, and also at one of the offsets

        Vector2 v31 = new Vector2(-2.0f, -2.0f);
        Vector3 v32 = new Vector2(-2.0f, 6.0f);
        Vector3 v33 = new Vector2(-2.0f, 14.0f);
        Vector3 v34 = new Vector2(-2.0f, 22.0f);






        Data.roadMap.Add(0, v1);
        Data.roadMap.Add(1, v2);
        Data.roadMap.Add(2, v3);
        Data.roadMap.Add(3, v4);
        Data.roadMap.Add(4, v5);
        Data.roadMap.Add(5, v6);
        Data.roadMap.Add(6, v7);
        Data.roadMap.Add(7, v8);
        Data.roadMap.Add(8, v9);
        Data.roadMap.Add(9, v10);
        Data.roadMap.Add(10, v11);
        Data.roadMap.Add(11, v12);
        
        Data.roadMap.Add(12, v21);
        Data.roadMap.Add(13, v22);
        Data.roadMap.Add(14, v23);
        Data.roadMap.Add(15, v24);

        Data.roadMap.Add(16, v25);
        Data.roadMap.Add(17, v26);
        Data.roadMap.Add(18, v27);
        Data.roadMap.Add(19, v28);
        Data.roadMap.Add(20, v29);
        Data.roadMap.Add(21, v30);

        // rows

        Data.roadMap.Add(22, v31);
        Data.roadMap.Add(23, v32);
        Data.roadMap.Add(24, v33);
        Data.roadMap.Add(25, v34);

        DetermineJunctions(); 
    }


    void OutputList(List<int> list)
    {
        foreach (int i in list)
        {
            Debug.Log(i);
        }
    }



    void CreateRowJunction(int start, int end, int row)
    {


        // 1. Vector2(start, rowOrColumn)
        // 2. Vector2(end, rowOrColumn)

        // Instantiate prefab with pos parameters of above

        // for a row 

        // a row will be going 

        // so the start pos will be: start, 0, row  -->   end, 0, row

        // start x, y, z:  start, 0, row
        // end   x, y, z:  end, 0, row

        // Debug.Log("Junction start: " + start + " " + row);
        // Debug.Log("Junction end: " + end + " " + row);

        Vector3 junctionStart = new Vector3((float)start, 0.0f, (float)row);
        Vector3 junctionEnd = new Vector3((float)end, 0.0f, (float)row);

        GameObject junction = Instantiate(waypoint, new Vector3(0,0,0), Quaternion.identity);
        GameObject waypointStart = junction.transform.GetChild(0);
        GameObject waypointEnd = junction.transform.GetChild(1);

        waypointStart.transform.position = junctionStart;
        waypointEnd.transform.position = junctionEnd;



        // modify the child objects of the junction prefab with the above parameters
    }



    void CreateColumnJunction(int start, int end, int column)
    {

        // 1. Vector2(start, rowOrColumn)
        // 2. Vector2(end, rowOrColumn)

        // Instantiate prefab with pos parameters of above

        // start x, y, z:  column, 0, start
        // end   x, y, z:  column, 0, end

        // Debug.Log("Junction start: " + start + " " + column);
        // Debug.Log("Junction end: " + end + " " + column);

        Vector3 junctionStart = new Vector3((float)column, 0.0f, (float)start);
        Vector3 junctionEnd = new Vector3((float)column, 0.0f, (float)end);

        GameObject junction = Instantiate(waypoint, new Vector3(0,0,0), Quaternion.identity);
        GameObject waypointStart = junction.transform.GetChild(0);
        GameObject waypointEnd = junction.transform.GetChild(1);

        waypointStart.transform.position = junctionStart;
        waypointEnd.transform.position = junctionEnd;


    }




    
    int GetIndexOfItem(List<int> list, int item)
    {
        return list.IndexOf(item);
    }
    


    void ResetIterator()
    {
        endpoint = 1;
    }



    /*
    bool GetSequences(List<int> list, int column)
    {

        
    }
    */



    int GetBeforeLastItem(List<int> aList, int startItem)
    {
        int i = aList.IndexOf(startItem);
        i -= 1;
        return aList[i];
    }



    void GetRowSequences(List<int> list, int row)
    {
        for (int i = indexEndpointOfList; i < list.Count; i++)
        {
            if (list[i] == ((list[i - 1]) + offset))
            {
                aSequence.Add(list[i]);
            }
            else break; 
        }


        if (aSequence.Count > minSequence)
        {
            // CreateJunction(aSequence.FirstOrDefault(), aSequence.LastOrDefault());
            CreateRowJunction(GetBeforeLastItem(list, aSequence.FirstOrDefault()), aSequence.LastOrDefault(), row);
            indexEndpointOfList = 1 + GetIndexOfItem(list, aSequence.LastOrDefault());
            aSequence.Clear();
        }


        if (list.Count == indexEndpointOfList)
        {
            done = true;
        }



        // two ways of breaking out of the future while loop:

        /*
        if (list[endpoint] == list.LastOrDefault())
        {
            // Debug.Log("Reached the end: " + list[endpoint]);
            isLastPosInList = true;
        }
        */

        // Debug.Log("list[endpoint] " + list[endpoint]);

        if (endpoint == lastEndpoint) isLastPosInList = true; // done

        lastEndpoint = endpoint;
    }




    void GetColumnSequences(List<int> list, int column)
    {
        for (int i = indexEndpointOfList; i < list.Count; i++)
        {
            if (list[i] == ((list[i - 1]) + offset))
            {
                aSequence.Add(list[i]);
            }
            else break; 
        }


        if (aSequence.Count > minSequence)
        {
            // CreateJunction(aSequence.FirstOrDefault(), aSequence.LastOrDefault());
            CreateColumnJunction(GetBeforeLastItem(list, aSequence.FirstOrDefault()), aSequence.LastOrDefault(), column);
            indexEndpointOfList = 1 + GetIndexOfItem(list, aSequence.LastOrDefault());
            aSequence.Clear();
        }


        if (list.Count == indexEndpointOfList)
        {
            done = true;
        }



        // two ways of breaking out of the future while loop:

        /*
        if (list[endpoint] == list.LastOrDefault())
        {
            // Debug.Log("Reached the end: " + list[endpoint]);
            isLastPosInList = true;
        }
        */

        // Debug.Log("list[endpoint] " + list[endpoint]);

        if (endpoint == lastEndpoint) isLastPosInList = true; // done

        lastEndpoint = endpoint;
    }




    // runs 228 times, everything runs 13 times at most, once per column
    // 228 / 13 = 17, perhaps this runs 17 times per column

    /*
    bool GetNextConsecutiveSegment(List<Vector2> positionsByColumn, int column)
    {
        GetNextConsecutiveSegment_count += 1;

        positionsByColumn.Sort((a, b) => a.x.CompareTo(b.x));
        List<int> justXs = new List<int>();

        foreach (Vector2 item in positionsByColumn)
        {
            justXs.Add((int)item.x);
        }

        bool done = GetSequences(justXs, column);

        return done;
    }
    */


    void ScanColumns(List<Vector2> positionsByColumn, int column)
    {

        positionsByColumn.Sort((a, b) => a.x.CompareTo(b.x));
        List<int> justXs = new List<int>();

        foreach (Vector2 item in positionsByColumn)
        {
            justXs.Add((int)item.x);
        }

        foreach (int i in justXs) // justXs list here?
        {
            GetColumnSequences(justXs, column);
            indexEndpointOfList += 1;
        }
        // reset index endpoint?
        indexEndpointOfList = 1;

        Debug.Log("End of columns");
    }



    void ScanRows(List<Vector2> positionsByColumn, int row)
    {

        positionsByColumn.Sort((a, b) => a.y.CompareTo(b.y));
        List<int> justYs = new List<int>();

        foreach (Vector2 item in positionsByColumn)
        {
            justYs.Add((int)item.y);
        }

        foreach (int i in justYs) // justXs list here?
        {
            GetRowSequences(justYs, row);
            indexEndpointOfList += 1;
        }

        indexEndpointOfList = 1;

        Debug.Log("End of rows");
    }








    void GetAllSegmentsInColumn(List<Vector2> posByColumn, int column)
    {
        ScanColumns(posByColumn, column);
    }



    void GetAllSegmentsInRow(List<Vector2> posByRow, int row)
    {
        ScanRows(posByRow, row);
    }



    List<Vector2> PullOutVectorsByColumn(float column)
    {
        List<Vector2> posVectorsByColumn = new List<Vector2>();
        int addCount = 0;

        foreach (KeyValuePair<int, Vector2> value in Data.roadMap)
        {
            if (value.Value.y == column)
            {
                posVectorsByColumn.Add(value.Value);
                addCount += 1;
            }
        }
        return posVectorsByColumn;
    }



    List<Vector2> PullOutVectorsByRow(float row)
    {
        List<Vector2> posVectorsByRow = new List<Vector2>();
        int addCount = 0;

        foreach (KeyValuePair<int, Vector2> value in Data.roadMap)
        {
            if (value.Value.x == row) // x? - come back here to check if get an error
            {
                posVectorsByRow.Add(value.Value);
                addCount += 1;
            }
        }
        return posVectorsByRow;
    }



    void ScanRowLine(int row)
    {
        List<Vector2> positionsByRow = PullOutVectorsByRow((float)row);
        GetAllSegmentsInRow(positionsByRow, row);
    }




    void ScanColumnLine(int column)
    {
        List<Vector2> positionsByColumn = PullOutVectorsByColumn((float)column);
        GetAllSegmentsInColumn(positionsByColumn, column);
    }



    void DetermineJunctions()
    {


        for (int i = mapStart; i < mapEnd; i += offset)
        {
            ScanColumnLine(i);
        }

        for (int i = mapStart; i < mapEnd; i += offset)
        {
            ScanRowLine(i);
        }

        // and here we have to do something about the intersections
    }
    

    // public minRoadTilesForTraffic = 3;


    public void UpdateTrafficSystem()
    {

        DetermineJunctions();

        if (cars.activeSelf == false)
        {
            cars.SetActive(true);

            // set starting pos of the cars
            Vector3 startVector = new Vector3(Data.roadMap[0].x, 0.0f, Data.roadMap[0].y);
            // startPos = Data.roadMap[0]; // hacky way for now
            Debug.Log("Start pos: " + startVector);

            car1.transform.position = startVector;
            car2.transform.position = startVector;

        }


        

    }



}
