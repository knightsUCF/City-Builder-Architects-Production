using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// https://interestingengineering.com/dirty-clean-how-water-treatment-plant-works


// try to model the above elements, try to have the most realistic water and power plant systems out of any game



public class WaterSystem : MonoBehaviour
{



    public void OnBuildWaterPlant()
    {
        EventManager.TriggerEvent("BuildWaterPlant"); // send an event to build a water plant, the build class will take care of the rest
    }



    public void OnAccessWaterGrid()
    {
        // send an event to build a water pipe, the build class will take care of the snap to grid
        // we will want to create a water pipe element an intanstiate that with Build.cs
        // if for some reason our grid requirements change, we can take care of that later, if we need to abstract here,
        // or create a SnapToGrid parent class we can derive from if needed, based on the grid size
        // the only element that would really change is the grid size, since any grid is uniform

        // what we will also want to do here is "turn off" the rest of the world, so we get a nice x ray, but that is also something for later
        // so here for now just build when we access the water grid
        // well we should have the grid view here, AND then another button which lays pipes
        // this grid view might not be much at first, but let's carve out the future place holder
        // so in total we will ahve three elements in our water grid -- 1) water plant 2) water grid view, and 3) laying pipes
        // of course later this all might get consolidated to just one building, and then perhaps we can split off the water system view,
        // and power plant view into a "systems view tab", but since we will rework the UI many times, let's just get the basic
        // elements functional
        EventManager.TriggerEvent("AccessWaterGrid");
    }



    public void OnBuildWaterPipe()
    {
        EventManager.TriggerEvent("BuildWaterPipe");
    }



}
