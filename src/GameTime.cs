using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class GameTime : MonoBehaviour
{

    [Range(0,1)]
    public float currentTimeOfDay = 0;
    public float secondsInFullDay = 120;
    public float timeMultiplier = 1;

    float delta;



    void Start()
    {
        delta = 1 / secondsInFullDay; // save performance on division
        delta = (float)System.Math.Round(delta, 2);  // round for optimization        
    }



    void Update()
    {
        currentTimeOfDay += (Time.deltaTime * delta) * timeMultiplier;

        if (currentTimeOfDay >= 1)
        {
            DoTurnActions();
            currentTimeOfDay = 0;
        }
    }



   void DoTurnActions()
   {
       // Payout.OnResourceCycleCompletion();



       // update stats

       // so pull the Data.tokens, and update into Data.tokensChartList, and then call ShowGraph with GetComponent

       // then whenever the user presses "G" the graph will be updated for them, eventually

       // well instead only call the ShowGraph() when they press G, because we will be unnessarily slowing the system down every 10 seconds or so



       // Data.tokens
       // Data.valueList
       // Data.tokensChartList
       // Instead of ShowGraph() this is GeneratingGraph(), with the new data
       // ShowGraph(Data.tokensChartList, -1, (int _i) => "Day "+(_i+1), (float _f) => "$" + Mathf.RoundToInt(_f));

       // Data.tokensChartList.Add(Data.tokens);

       // likewise for all the other chart lists, such as electricity  

   }
}
