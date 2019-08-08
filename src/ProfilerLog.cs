using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

public class ProfilerLog : MonoBehaviour
{
    uint used;
    uint total;

    double dUsed;
    double dTotal;

    float fUsed;
    float fTotal;

    int iUsed;
    int iTotal;

    public Text usedText;
    public Text totalText;

    
    void Update()
    {
        System.GC.Collect();

        used = Profiler.GetMonoUsedSize();
        total = Profiler.GetMonoHeapSize();

        // Debug.Log("Total managed memory currently used: " + used);
        // Debug.Log("Total size of the managed heap (used + free): " + total);


        dUsed = (double)used * 0.000001;
        dTotal = (double)total * 0.000001;

        fUsed = (float)dUsed;
        fTotal = (float)dTotal;

        // fUsed = Mathf.Round(fUsed);
        // fTotal = Mathf.Round(fTotal);

        usedText.text = "Used:  " + fUsed.ToString();
        totalText.text = "Total: " + fTotal.ToString();
    }
}


