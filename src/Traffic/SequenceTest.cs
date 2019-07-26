using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SequenceTest : MonoBehaviour
{
    

    List<int> list = new List<int> {0, 8, 16, 24, 31, 32, 33, 34, 40, 48, 56, 64, 65, 70, 71, 80, 88, 96, 104, 112};
    // List<int> list = new List<int> {0, 1, 2, 3, 6, 9, 12, 15, 16, 17, 20, 23, 26, 27, 30, 33, 34, 46, 104, 112};


    List<int> aSequence = new List<int>();

    int offset = 8;
    int endpoint = 1;
    int lastEndpoint = 0;
    int minSequence = 1;
    bool done = false;
    int indexEndpointOfList = 1;

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


    int GetBeforeLastItem(List<int> list, int startItem)
    {
        int i = list.IndexOf(startItem);
        i -= 1;
        return list[i];
    }

    

    void ScanSequences()
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
            CreateJunction(GetBeforeLastItem(list, aSequence.FirstOrDefault()), aSequence.LastOrDefault());
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
    


    
    void Start()
    {
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);
        ScanSequences();
        indexEndpointOfList += 1;
        Debug.Log("indexEndpointOfList: " + indexEndpointOfList);

        

    
        
        // make sure the indexEndPointOfList does not go out of the lists index range, so something like if (indexendpointlist < list.count index) break
 

        if (isLastPosInList || done)
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
