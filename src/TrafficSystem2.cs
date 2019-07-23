using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TrafficSystem2 : MonoBehaviour
{



    public int offset = 8;
    public int mapStart = -2;
    public int mapEnd = 100;


    





    /*
    
    TODO

    - move map over so we are only building past zero, if not, can't we just start the iteration at a negative number?
    - 
    
    
    
    */






    void Start()
    {
        Test();
    }



    void Test()
    {
        Vector2 v1 = new Vector2(-58.0f, 20.0f);

        Vector2 v4 = new Vector2(-42.0f, 22.0f);

        Vector2 v2 = new Vector2(-58.0f, 22.0f);
        Vector2 v3 = new Vector2(-50.0f, 22.0f);
        
        Vector2 v5 = new Vector2(-34.0f, 20.0f);
        Vector2 v6 = new Vector2(-100.0f, 22.0f);
        Vector2 v7 = new Vector2(-200.0f, 30.0f);
        Vector2 v8 = new Vector2(-300.0f, 30.0f);

        Data.roadMap.Add(0, v1);
        Data.roadMap.Add(1, v2);
        Data.roadMap.Add(2, v3);
        Data.roadMap.Add(3, v4);
        Data.roadMap.Add(4, v5);
        Data.roadMap.Add(5, v6);
        Data.roadMap.Add(6, v7);
        Data.roadMap.Add(7, v8);


        DetermineJunctions(); 

    }



    void OutputListContents(List<Vector2> someList)
    {
        foreach (Vector2 item in someList)
        {
            Debug.Log(item);
        }
    }



    float GetListMin(List<Vector2> someList)
    {
        float minValue = 10000.0f; // will need to be set to map's bounds

        foreach (Vector2 item in someList)
        {
            if (item.x < minValue) minValue = item.x;
        }

        return minValue;
    }



    bool DoesElementExistInList(float x, float y, List<Vector2> someList)
    {
        foreach (Vector2 item in someList)
        {
            if (item.x == x && item.y == y) return true;
        }
        return false;
    }

    

    List<Vector2> PullOutVectorsByColumn(float column)
    {
        List<Vector2> posVectorsByColumn = new List<Vector2>();

        // Debug.Log("Column: " + column);

        int addCount = 0;

        foreach (KeyValuePair<int, Vector2> value in Data.roadMap)
        {
            // Debug.Log(value);
            // [0, (-58.0, 20.0)]
            // [1, (-50.0, 20.0)]
            // [2, (-50.0, 22.0)]

            // Debug.Log("column: " + column);


            if (value.Value.y == column)
            {
                posVectorsByColumn.Add(value.Value);
                addCount += 1;
            }
        }

        // OutputListContents(posVectorsByColumn);

        // Debug.Log("Add count: " + addCount);

        return posVectorsByColumn;
    }



    List<Vector2> PullOutVectorsByRow(float row)
    {
        List<Vector2> posVectorsByRow = new List<Vector2>();

        foreach (KeyValuePair<int, Vector2> value in Data.roadMap)
        {
            if (value.Value.x == row)
            {
                posVectorsByRow.Add(value.Value);
            }
        }

        return posVectorsByRow;
    }





    


    // rewrite for row 

    /*
    void ScanNextConsecutiveRowSegment(List<Vector2> posByRow)
    {
        List<Vector2> connectedSegment = new List<Vector2>();


        // this for loop is different than the one in DetermineJunctions(), but since the world is a box they both have the same symmetrical boundary
        for (int i = mapStart; i < mapEnd; i += 8)
        {
            if (DoesElementExistInList((float)i, column, posByColumn)) // if the incremented position by 8 exists, add to list
            {
                if(DoesElementExistInList((float)(i - 8), column, posByColumn)) // determine we are linking continously, if the element doesn't exist 8 back in the list, we don't add
                {
                    connectedSegment.Add(); // and here voila, we should have a connected segments list, out of which we will pull out the min and max
                }
            }
        }
    }
    */



    void ScanNextConsecutiveColumnSegment(List<Vector2> posByColumn, int column)
    {

        // reached scope

        // Debug.Log("columns being scanned: " + column);


        List<Vector2> connectedSegment = new List<Vector2>();

        // OutputListContents(posByColumn);



        // this for loop is different than the one in DetermineJunctions(), but since the world is a box they both have the same symmetrical boundary
        
        

        for (int i = mapStart; i < mapEnd; i += 8)
        {
            // if the incremented position by 8 exists, add to list

            if (DoesElementExistInList((float)i, (float)column, posByColumn)) 
            {
                Debug.Log("reached outer element exist scope");
                // determine we are linking continously, if the element doesn't exist 8 back in the list, we don't add

                if(DoesElementExistInList((float)(i - 8), (float)column, posByColumn)) 
                {
                    // and here voila, we should have a connected segments list, out of which we will pull out the min and max

                    Vector2 posToAdd = new Vector2((float)i, (float)column);
                    // Debug.Log(posToAdd);
                    connectedSegment.Add(posToAdd); // not sure the x, y position we are possing off here TODO
                    Debug.Log("reached inner element exist scope");
                }
            }

            // Debug.Log("i: " + i);

            // if (i > mapEnd) return true; // most efficient way? 
        }
        // return false; // we will return true once we get to the end, to signal scanning all the possible column lines has finished
    }


    /*
    void ScanColumnLine(int column)
    {

        List<Vector2> positionsByColumn = PullOutVectorsByColumn((float)column);

        // OutputListContents(positionsByColumn);


        ScanNextConsecutiveColumnSegment(positionsByColumn, column);

        
        bool run = true;
        bool doneScanning = false;
        int counter = 0;

        while (run)
        {
            doneScanning = ScanNextConsecutiveColumnSegment(positionsByColumn, column);

            Debug.Log("done scanning: " + doneScanning);

            if (doneScanning) // where we will compare the end of the map to the last scan
            {
                run = false;
            }

            counter += 1;

            if (counter > 1000) 
            {
                Debug.Log("Reached over 10000 in while loop... breaking...");
                return; // prevent crashing in any case
            }            
        }
        
    }
    */



    void ScanRowLine(int row)
    {
        // just working on columns now
        
        /* 
        List<Vector2> positionsByRow = PullOutVectorsByRow(row);

        ScanNextConsecutiveSegment(positionsByRow);
        */


    }

    // https://stackoverflow.com/questions/3844611/detecting-sequence-of-at-least-3-sequential-numbers-from-a-given-list

    static IEnumerable<IEnumerable<int>> ConsecutiveSequences( IEnumerable<int> input, int minLength = 1)
    {
        var results = new List<List<int>>();

        foreach (var i in input.OrderBy(x => x))
        {
            var existing = results.FirstOrDefault(lst => lst.Last() + 1 == i);

            if (existing == null)
                results.Add(new List<int> { i });
            else
                existing.Add(i);
        }
        return minLength <= 1 ? results :
            results.Where(lst => lst.Count >= minLength);
    }



    static IEnumerable<IEnumerable<int>> Sequencify(List<int> list, int minLength = 1)
    {
        var results = new List<List<int>>();

        foreach (int i in list)
        {
            var existing = results.FirstOrDefault(lst => lst.Last() + 1 == i);
            
            if (existing == null)
                results.Add(new List<int> { i });
            else
                existing.Add(i);
        }

        return minLength <= 1 ? results :
            results.Where(lst => lst.Count >= minLength);
    }




    void OutputIntegerList(List<int> list)
    {
        foreach (int i in list)
        {
            Debug.Log(i);
        }
    }


    void DisplayNestedList(List<List<int>> list)
    {
        //
        // Display everything in the List.
        //
        // Debug.Log("Elements:");
        foreach (var sublist in list)
        {
            foreach (var value in sublist)
            {
                Debug.Log(value);
                // Debug.Log(' ');
            }
            // Debug.Log(' ');
        }

        /* 
        //
        // Display element at 3, 3.
        //
        if (list.Count > 3 &&
            list[3].Count > 3)
        {
            Console.WriteLine("Element at 3, 3:");
            Console.WriteLine(list[3][3]);
        }
        //
        // Display total count.
        //
        int count = 0;
        foreach (var sublist in list)
        {
            count += sublist.Count;
        }
        Console.WriteLine("Count:");
        Console.WriteLine(count);
        */
    }


    void GetSequences(List<int> list)
    {

        List<int> aSequence = new List<int>();

        int last = 0;


        if (list == null)
        {
            return;
        }

        
        int current = list.FirstOrDefault();
        last = list.FirstOrDefault();


        for (int i = 0; i < list.Count(); i++)
        {
            if (i != 0)
            {

                Debug.Log("list[i]: " + list[i] + " last (list[i - 1]): " + list[i - 1] +  " offset: " + offset);

                if (list[i] == ((list[i - 1]) + offset))
                {
                    aSequence.Add(list[i]);
                    Debug.Log("adding to sequence!");
                }


                if (current != last - offset)
                {
                    // Debug.Log("Last item out of sequence is: " + i);

                }

            }


            
 
            
            /*
            if (i == last - offset)
            {
                aSequence.Add(i);
                Debug.Log("adding to sequence!");
                last = i;
            }
            */

            
        }


        Debug.Log("The compiled sequence: ");

        OutputIntegerList(aSequence);




        /*
        for (int i = 0; i < 100; i++)
        {
            if (current == last - offset)
            {
                // set the first one as beginning
                
                list.Add(current);
                last = current;
            }

            if (current != last - offset)
            {
                // end sequence, note where ending
                // and mark this as the end
            }
        }
        */
    }


    /*

    void GetSequences(List<int> list)
    {
        var results = new List<List<int>>();

        foreach (int i in list)
        {
            var existing = results.FirstOrDefault(lst => lst.Last() + offset == i);
            
            if (existing == null)
                results.Add(new List<int> { i });
            else
                existing.Add(i);
        }

        // List<int> parent = new List<int>();
        // List<int> child = new List<int>();

       List<List<int>> resultsList = new List<List<int>>();

       resultsList = results;

        // parent = results[0];
        // child = results[0][0];

        // OutputIntegerList(parent);
        // OutputIntegerList(child);

        // https://www.dotnetperls.com/nested-list

        DisplayNestedList(resultsList);

        
        foreach (List<int> i in resultsList)
        {
            Debug.Log(i);
        }
        

        // Debug.Log(resultsList[0]);
        // Debug.Log(resultsList[0][0]);
    }


    */




    bool GetNextConsecutiveSegment(List<Vector2> positionsByColumn, int column)
    {

        positionsByColumn.Sort((a, b) => a.x.CompareTo(b.x));

        List<int> justXs = new List<int>();

        
        foreach (Vector2 item in positionsByColumn)
        {
            justXs.Add((int)item.x);
        }


        OutputIntegerList(justXs);

        GetSequences(justXs);



        /*
        IEnumerable<IEnumerable<int>> sequence = Sequencify(justXs, 3);

        List<int> iSequence = sequence.ToList();

        */

        // List<int> iSequence = sequence.Cast<object>().ToList();


        /*    

        foreach (int i in iSequence)
        {
            Debug.Log(i);
        }

        */

    




      

        // https://stackoverflow.com/questions/3844611/detecting-sequence-of-at-least-3-sequential-numbers-from-a-given-list

        // we do this up to the map limits, so until the item.x exceeds (>) the mapEnd, then we break

        



        /*
        for (int i = mapStart; i <= mapEnd; i += offset)
        {

            // as we iterate up we check if element exists, if element doesn't exist the junction has ended


            // CreateJunction(start, end); // instantiate the junction prefab
        }
        */



        

        // even for now if the junction is just one box

        // once we get to the end we mark this, so we can then begin to find the next starting segment






        /*
        for (int i = mapStart; i < mapEnd; i += offset)
        {




            // if the incremented position by 8 exists, add to list

            // i = x position, column = y position, positionsByColumn = all the positions
            if (DoesElementExistInList((float)i, (float)column, positionsByColumn)) 
            {
                Debug.Log("reached outer element exist scope");
                // determine we are linking continously, if the element doesn't exist 8 back in the list, we don't add

                if(DoesElementExistInList((float)(i - offset), (float)column, positionsByColumn)) 
                {
                    // and here voila, we should have a connected segments list, out of which we will pull out the min and max

                    Vector2 posToAdd = new Vector2((float)i, (float)column);
                    // Debug.Log(posToAdd);
                    connectedSegment.Add(posToAdd); // not sure the x, y position we are possing off here TODO
                    Debug.Log("reached inner element exist scope");
                }
            }

            
        }
        */
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



    // runs per each column

    void ScanColumnLine(int column)
    {
        List<Vector2> positionsByColumn = PullOutVectorsByColumn((float)column);

        GetAllSegmentsInColumn(positionsByColumn, column);

        // ScanNextConsecutiveColumnSegment(positionsByColumn, column);

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
