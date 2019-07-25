using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SequenceTest : MonoBehaviour
{
    

    List<int> list = new List<int> {0, 8, 16, 24, 31, 32, 33, 34, 40, 48, 56, 64, 65, 70, 71, 80, 88, 96, 104, 112};

    List<int> aSequence = new List<int>();

    int offset = 8;
    int endpoint = 1;
    int lastEndpoint = 0;
    int minSequence = 1;
    bool done = false;

    bool isLastPosInList = false;


    /*

    0   0
    8   1
    16  2
    24  3
    31  4
    32  5
    33  6
    34  7
    40  8
    48  9
    56  10
    64  11
    
    
    
    
    
    
    */


    void ScanSequences()
    {
        for (int i = endpoint; i < list.Count; i++)
        {
            if (list[i] == ((list[i - 1]) + offset))
            {
                aSequence.Add(list[i]);
            }
            else break;
        }


        if (aSequence.Count > minSequence)
        {
            CreateJunction(aSequence.FirstOrDefault(), aSequence.LastOrDefault());
            endpoint = 1 + GetIndexOfItem(aSequence, aSequence.LastOrDefault());
            // Debug.Log("updated endpoint: " + endpoint);
            // clear the last sequence, so we don't keep adding to the same sequence
            aSequence.Clear();
        }

        // if (endpoint == lastEndpoint) done = true; // for breaking out of a while loop

        // lastEndpoint = endpoint;

        // OutputList(aSequence);

        if (list[endpoint] == list.LastOrDefault())
        {
            // Debug.Log("Reached the end: " + list[endpoint]);
            isLastPosInList = true;
        }

        // Debug.Log("list[endpoint] " + list[endpoint]);

        if (endpoint == lastEndpoint) isLastPosInList = true; // done

        lastEndpoint = endpoint;
    }



    void Start()
    {
        // can't just add one, have to add one after the
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
        endpoint += 1;
        Debug.Log("endpoint: " + endpoint);
        ScanSequences();
 
  


        if (isLastPosInList)
        {
            Debug.Log("DONE!");
        }
        
    }



    void OutputList(List<int> list)
    {
        foreach (int i in list)
        {
            Debug.Log(i);
        }
    }



    int GetIndexOfItem(List<int> list, int item)
    {
        return list.IndexOf(item);
    }


    void CreateJunction(int start, int end)
    {
        Debug.Log("Junction start: " + start);
        Debug.Log("Junction end: " + end);
    }


    
}
