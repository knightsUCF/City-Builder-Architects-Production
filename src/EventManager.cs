using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EventManager : MonoBehaviour
{



    /*
    
    - so for now we want to listen to the event, "endBuilding" and finalize the cube structure in the Build class
    
    
    */

    /* Use
    
    From a script write this to add the "listener" of the event:

    void OnEnable ()
    {
        EventManager.startBuilding += MethodYouWantToTriggerFromChildScript;
    }

    void OnDisable()
    {
        EventManager.startBuilding -= MethodYouWantToTriggerFromChildScript;
    }

    
    
    */

    // call StartBuilding() to send out event


    public delegate void StartBuilding();
    public static event StartBuilding startBuilding;

    public delegate void EndBuilding();
    public static event EndBuilding endBuilding;


    public void EventStartBuilding()
    {
        startBuilding();
    }

    public void EventEndBuilding()
    {
        endBuilding();
    }


    /*
    

    // "parent" class

    public delegate void SkyscraperButtonClick();
    public static event SkyscraperButtonClick SkyscraperOptionClick;

    public delegate void HouseButtonClick();
    public static event HouseButtonClick HouseOptionClick;

    public delegate void RoadButtonClick();
    public static event RoadButtonClick RoadOptionClick;


    SkyscraperOptionClick();





    // goes in the specific class
    // event stuff

    void OnEnable ()
    {
        ButtonHandler.SkyscraperOptionClick += BuildSkyscraper;
        ButtonHandler.HouseOptionClick += BuildHouse;
        ButtonHandler.RoadOptionClick += BuildRoad;
    }

    void OnDisable()
    {
        ButtonHandler.SkyscraperOptionClick -= BuildSkyscraper;
        ButtonHandler.HouseOptionClick -= BuildHouse;
        ButtonHandler.RoadOptionClick -= BuildRoad;
    }
    

    void BuildSkyscraper()
    {
        structureSelection = StructureSelection.skyscraper1;
    }


    
    
    
    
    
    
    
    */
}
