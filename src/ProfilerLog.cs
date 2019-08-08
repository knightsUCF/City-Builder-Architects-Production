using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.UI;

public class ProfilerLog : MonoBehaviour
{
    uint used;
    uint total;

    uint totalMemory;

    double dUsed;
    double dTotal;
    double dTotalMemory;

    float fUsed;
    float fTotal;
    float fTotalMemory;

    int iUsed;
    int iTotal;

    public Text usedText;
    public Text totalText;
    public Text totalMemoryText;


    // FPS

    public string formatedString = "{value} FPS";
    public Text txtFps;
 
    public float updateRateSeconds = 4.0F;
 
    int frameCount = 0;
    float dt = 0.0F;
    float fps = 0.0F;


    public float avgFrameRate;



    void Start()
    {
        // 1 - Sync framerate to monitors refresh rate, 0 - don't sync
        QualitySettings.vSyncCount = 1;
    }




    void GetFPS2()
    {
        frameCount++;
         dt += Time.unscaledDeltaTime;
         if (dt > 1.0 / updateRateSeconds)
         {
             fps = frameCount / dt;
             frameCount = 0;
             dt -= 1.0F / updateRateSeconds;
         }
         txtFps.text = formatedString.Replace("{value}", System.Math.Round(fps, 1).ToString("0.0"));
    }

    void GetFPS()
    {
        avgFrameRate = Time.frameCount / Time.time;
        txtFps.text = "FPS: " + avgFrameRate.ToString();

    }


    void GetMemory()
    {
        // System.GC.Collect();

        // used = Profiler.GetMonoUsedSize();
        // total = Profiler.GetMonoHeapSize();

        totalMemory = Profiler.GetTotalAllocatedMemory();

        // Debug.Log("Total managed memory currently used: " + used);
        // Debug.Log("Total size of the managed heap (used + free): " + total);


        // dUsed = (double)used * 0.000001;
        // dTotal = (double)total * 0.000001;
        dTotalMemory = (double)totalMemory * 0.000001;

        // fUsed = (float)dUsed;
        // fTotal = (float)dTotal;
        fTotalMemory = (float)dTotalMemory;



        // fUsed = Mathf.Round(fUsed);
        // fTotal = Mathf.Round(fTotal);

        // usedText.text = "Used:  " + fUsed.ToString();
        // totalText.text = "Total: " + fTotal.ToString();

        totalMemoryText.text = "RAM: " + fTotalMemory.ToString();

    }

    
    void Update()
    {
        GetMemory();
        GetFPS();
    }
}


