using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EventManager : MonoBehaviour
{



    /*
    
    - so for now we want to listen to the event, 
    "endBuilding" and finalize the cube structure in the Build class
    
    
    */

    /* Use

    From the script that is SENDING event:

    EventManager eventManager;
    eventManager = FindObjectOfType<EventManager>();
    eventManager.EventWorkerArrivedAtBuilding();

    From the script that is RECEIVING the event:
    
    From a script write this to add the "listener" of the event:

    void OnEnable ()
    {
        EventManager.startBuilding += MethodYouWantToTriggerFromReceivingScript;
    }

    void OnDisable()
    {
        EventManager.startBuilding -= MethodYouWantToTriggerFromReceivingScript;
    }

    void MethodYouWantToTriggerFromReceivingScript()
    {
        // run once on event
    }

    
    
    */

    // call StartBuilding() to send out event


    public delegate void StartBuilding();
    public static event StartBuilding startBuilding;

    public delegate void EndBuilding();
    public static event EndBuilding endBuilding;

    public delegate void EndBuildingCycleRoutine();
    public static event EndBuildingCycleRoutine endBuildingCycleRoutine;


    // worker events

    public delegate void WorkerArrivedAtBuilding();
    public static event WorkerArrivedAtBuilding workerArrivedAtBuilding;

    public delegate void WorkerCanStartBuilding();
    public static event WorkerCanStartBuilding workerCanStartBuilding;


    public void EventWorkerArrivedAtBuilding()
    {
        if (workerArrivedAtBuilding != null) workerArrivedAtBuilding(); // prevents null reference errors if no one is subscribed to event
    }

    public void EventWorkerCanStartBuilding()
    {
        if (workerCanStartBuilding != null) workerCanStartBuilding(); // prevents null reference errors if no one is subscribed to event
    }


    // Employment Office done building - for generating new workers by AI ////////////////////

    public delegate void EmploymentOfficeFinishedBuilding();
    public static event EmploymentOfficeFinishedBuilding employmentOfficeFinishedBuilding;


    public void EventEmploymentOfficeFinishedBuilding()
    {
        employmentOfficeFinishedBuilding(); 
    }

    //////////////////////////////////////////////////////////////////////////////////////////





    public void EventStartBuilding()
    {
        startBuilding();
    }

    public void EventEndBuilding()
    {
        endBuilding();
    }

    public void EventEndBuildingCycleRoutine()
    {
        endBuildingCycleRoutine();
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
