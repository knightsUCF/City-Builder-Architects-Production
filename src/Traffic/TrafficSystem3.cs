using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class TrafficSystem3 : MonoBehaviour
{
    public int offset = 8;
    public int mapStart = -2;
    public int mapEnd = 100;


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

        DetermineJunctions(); 
    }



    void GetSequences(List<int> list)
    {
        List<int> aSequence = new List<int>();
        if (list == null) return;
    
        for (int i = 0; i < list.Count; i++)
        {
            if (i != 0)
            {
                if (list[i] == ((list[i - 1]) + offset)) aSequence.Add(list[i]);
                // if (current != last - offset)
            }
        }
    }



    bool GetNextConsecutiveSegment(List<Vector2> positionsByColumn, int column)
    {
        positionsByColumn.Sort((a, b) => a.x.CompareTo(b.x));
        List<int> justXs = new List<int>();

        foreach (Vector2 item in positionsByColumn)
        {
            justXs.Add((int)item.x);
        }

        GetSequences(justXs);

        return true;
    }




    void GetAllSegmentsInColumn(List<Vector2> posByColumn, int column)
    {
        bool run = true;
        bool done = false;
        int counter = 0;

        while (run)
        {
            done = GetNextConsecutiveSegment(posByColumn, column);

            if (done) return; // close out when we reach the end

            counter += 1;

            if (counter > 1000) 
            {
                Debug.Log("Reached over 10000 in while loop... breaking...");
                return; // prevent crashing in any case
            }   
        }
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



    void ScanRowLine(int row)
    {
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
    


    public void UpdateTrafficSystem()
    {

    }



}
