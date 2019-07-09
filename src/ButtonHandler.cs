using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// use: if (Data.buttonSelection == Data.ButtonSelection.BlueCube)

// best tutorial on events: http://www.theappguruz.com/blog/using-delegates-and-events-in-unity




public class ButtonHandler : MonoBehaviour // does this need to be a singleton?
{


    public delegate void SkyscraperButtonClick();
    public static event SkyscraperButtonClick SkyscraperOptionClick;

    public delegate void HouseButtonClick();
    public static event HouseButtonClick HouseOptionClick;

    public delegate void RoadButtonClick();
    public static event RoadButtonClick RoadOptionClick;





    // attach this to the button

    public void OnClickBuildSkyscraperOption()
    {
        Data.structureSelection = Data.StructureSelection.Skyscraper1;
        SkyscraperOptionClick();
    }


    public void OnClickBuildHouseOption()
    {
        HouseOptionClick();
        Data.structureSelection = Data.StructureSelection.House;
    }


    public void OnClickBuildRoadOption()
    {
        RoadOptionClick();
        Data.structureSelection = Data.StructureSelection.Road;
    }


    
}

