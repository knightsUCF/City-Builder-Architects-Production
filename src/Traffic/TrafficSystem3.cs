using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;




public class TrafficSystem3 : MonoBehaviour
{
    public int offset = 8;
    public int mapStart = -2;
    public int mapEnd = 100;

    


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



    void CreateJunction(int start, int end, int rowOrColumn)
    {
        // 1. Vector2(start, rowOrColumn)
        // 2. Vector2(end, rowOrColumn)

        // Instantiate prefab with pos parameters of above

        Debug.Log("Junction start: " + start + " " + rowOrColumn);
        Debug.Log("Junction end: " + end + " " + rowOrColumn);
    }




    
    int GetIndexOfItem(List<int> list, int item)
    {
        return list.IndexOf(item);
    }
    


    void ResetIterator()
    {
        endpoint = 1;
    }



    bool GetSequences(List<int> list, int column)
    {
        bool done = false; // return true when done iterating over sequences

        int minSequence = 1;
        int endOfLastSequence;
        List<int> aSequence = new List<int>();
        // if (list == null) return;
    
        for (int i = endpoint; i < list.Count; i++)
        {
            if (list[i] == ((list[i - 1]) + offset))
            {
                aSequence.Add(list[i]);
            }
        }

        
        if (aSequence.Count > minSequence)
        {
            CreateJunction(aSequence.FirstOrDefault(), aSequence.LastOrDefault(), column);
            endpoint = GetIndexOfItem(aSequence, aSequence.LastOrDefault()); // becomes the beginning of our next iteration, should start at 1
            Debug.Log("index endpoint: " + endpoint);
            // also remember to reset back to one
        }

        Debug.Log("endpoint == lastEndpoint >>>  endpoint: " + endpoint + " lastEndpoint" + lastEndpoint);
        
        if (endpoint == lastEndpoint) done = true;

        lastEndpoint = endpoint;



        // how to tell we are at the end of the map

        // well what if the last element is not past the map end? TODO
        // well we will want to exit once we reach the last element, and then break the while loop



        if (list.LastOrDefault() >= mapEnd)
        {
            ResetIterator(); // resets back to one
            // at the end of the sequence endpoint will be reset back to one for each next column, and then also when we move over to rows

            // also want to close out the while loop TODO
            
        }
        

                // if (current != last - offset)


                /*
                if (i != list.Count - 1 && list[i] != (list[i + 1] + offset))
                {
                    aSequence.Add(list[i]);
                    endOfLastSequence = list[i];
                    return;
                }
                */
                    // compare this to the end of the map
                    
                    // also start here for the next sequence
            // }

            // waiting on help - https://discordapp.com/channels/493510779866316801/493511037421879316

            // we can proceed for now without the last element


            /*
            aSequence.Add(list[i]); this gives me the second item to last item
            aSequence.Add(list[i - 1]); gives me the first item to next to last item
            i would like to get the first to the last item
            */

        



    return done; // return true when done

        
        
    }



    bool GetNextConsecutiveSegment(List<Vector2> positionsByColumn, int column)
    {
        positionsByColumn.Sort((a, b) => a.x.CompareTo(b.x));
        List<int> justXs = new List<int>();

        foreach (Vector2 item in positionsByColumn)
        {
            justXs.Add((int)item.x);
        }

        bool done = GetSequences(justXs, column);

        return done;
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

            if (counter > 100) 
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
