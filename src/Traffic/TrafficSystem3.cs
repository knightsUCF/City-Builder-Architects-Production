using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;




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


    void Start()
    {
        Test();
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

        DetermineJunctions(); 
    }


    void OutputList(List<int> list)
    {
        foreach (int i in list)
        {
            Debug.Log(i);
        }
    }


    public int CreateJunction_count = 0;

    void CreateJunction(int start, int end, int rowOrColumn)
    {
        CreateJunction_count += 1;

        // 1. Vector2(start, rowOrColumn)
        // 2. Vector2(end, rowOrColumn)

        // Instantiate prefab with pos parameters of above

        Debug.Log("Junction start: " + start + " " + rowOrColumn);
        Debug.Log("Junction end: " + end + " " + rowOrColumn);

        junctionCount += 1;
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




    void GetSequences(List<int> list, int column)
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
            CreateJunction(GetBeforeLastItem(list, aSequence.FirstOrDefault()), aSequence.LastOrDefault(), column);
            indexEndpointOfList = 1 + GetIndexOfItem(list, aSequence.LastOrDefault());
            aSequence.Clear();
        }


        if (list.Count == indexEndpointOfList)
        {
            done = true;
        }



        // two ways of breaking out of the future while loop:

        if (list[endpoint] == list.LastOrDefault())
        {
            // Debug.Log("Reached the end: " + list[endpoint]);
            isLastPosInList = true;
        }

        // Debug.Log("list[endpoint] " + list[endpoint]);

        if (endpoint == lastEndpoint) isLastPosInList = true; // done

        lastEndpoint = endpoint;
    }


    public int GetNextConsecutiveSegment_count = 0;


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


    void Scan(List<Vector2> positionsByColumn, int column)
    {

        positionsByColumn.Sort((a, b) => a.x.CompareTo(b.x));
        List<int> justXs = new List<int>();

        foreach (Vector2 item in positionsByColumn)
        {
            justXs.Add((int)item.x);
        }

        foreach (int i in justXs) // justXs list here?
        {
            GetSequences(justXs, column);
            indexEndpointOfList += 1;
        }
    }




    void GetAllSegmentsInColumn(List<Vector2> posByColumn, int column)
    {
        Scan(posByColumn, column);
    }


    public int PullOutVectorsByColumn_count = 0;

    List<Vector2> PullOutVectorsByColumn(float column)
    {
        PullOutVectorsByColumn_count += 1;

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



    void ScanRowLine(int row)
    {
    }


    public int ScanColumnLine_count = 0;

    void ScanColumnLine(int column)
    {
        ScanColumnLine_count += 1;
        List<Vector2> positionsByColumn = PullOutVectorsByColumn((float)column);
        GetAllSegmentsInColumn(positionsByColumn, column);
    }


    public int DetermineJunctions_count = 0;

    void DetermineJunctions()
    {
        DetermineJunctions_count += 1;

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
    


    public void UpdateTrafficSystem()
    {

    }



}
