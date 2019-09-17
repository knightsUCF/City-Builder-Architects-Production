using System.Collections;
using System.Collections.Generic;
using UnityEngine;







public class SyntheticIntelligence : MonoBehaviour
{


    public bool run = false;



    public enum STATE
    {
        IDLE,
        WORK,
        SLEEP,
        EAT,
        PURSUE
    }

    STATE state;



    public enum PATTERN
    {
        GET_READY_FOR_WORK,
        WORK_DAY,
        MEET_SIM,
        TEST
    }

    PATTERN pattern;



    // flags

    bool WORKING = false;
    bool OWN_HOUSE = false;
    bool IS_MARRIED = false;
    bool ENCOUNTERED_SIM = false;




    
    Vector3 currentPosition;
    


    // For wandering around

    public float xMaxRange = 10.0f;
    public float zMaxRange = 10.0f;


    public float waitRangeMinInSeconds = 2.0f;
    public float waitRangeMaxInSeconds = 20.0f;



    public bool wander = true;


    public bool reachedDestination = true;
    public bool inRoute = false;
    public bool arrived = false;


    public Vector3 destination;

    public Vector3 currentLocation;


    public bool runWanderRoutine = true;


    public float arrivalDistanceWithinRange = 3.0f;







    public SimController simController; // drag in MoveSim script, easier to use then find object of type



    void Start()
    {

        Debug.Log("Running script");

        float waitTime = 0.0f;

        currentPosition = transform.position;

        
        // waitTime = WaitTime();

        // Invoke("WalkToRandomLocation", waitTime);


        StartCoroutine(Wander());
        


    }



    
    

    /*
    bool HaveWeArrived()
    {
        // let's output if we have reached the destination

        // destination <- Vector3
        

        // so we will want to check if our final vector position is within this range

        currentLocation = transform.position;

        if (transform.position == destination) return true; // we will want to check within range, in case there is another person there

        // also later we will want a larger radius, because if there is a building or something there, we don't want to get stuck and keep moving

        // also have safety check, to see whether we are stuck, and to give up on the current move action, or change course to get unstuck

        else return false;
    }
    */

    
    
    bool HaveWeArrived()
    {
        float distance = Vector3.Distance(transform.position, destination);
        return arrivalDistanceWithinRange >= distance;
    }


    bool waiting = false;



    IEnumerator Pause()
    {
        // waiting = false;
        runWanderRoutine = false;
        yield return new WaitForSeconds(2.0f);
    }


    
    IEnumerator Move()
    {

        WalkToRandomLocation();

        yield return new WaitForSeconds(2.0f);
        /*
        if (HaveWeArrived())
        {
            // reachedDestination = true;
            StartCoroutine(Pause());
            if (!waiting) WalkToRandomLocation();
        }
        */
        // else reachedDestination = false;
    }
    
    

    IEnumerator Wander()
    {
        // while(reachedDestination)
        while(runWanderRoutine)
        {
            if (HaveWeArrived()) StartCoroutine(Move());
            yield return new WaitForSeconds(0.5f);
        }
    }
    


    
    

    float RandomizeFromRange(float min, float max)
    {
        return Random.Range(min, max);
    }


    // includes the sleep, wait method

    void WalkToRandomLocation()
    {
        float x = RandomizeFromRange(currentPosition.x, currentPosition.x + xMaxRange);
        float z = RandomizeFromRange(currentPosition.z, currentPosition.z + zMaxRange);

        destination = new Vector3(x, 0.1f, z);

        simController.Move(destination);

        waiting = true;
    }
    



    float WaitTime()
    {
        float waitTime = RandomizeFromRange(waitRangeMinInSeconds, waitRangeMaxInSeconds);
        return waitTime;
    }



    
}






/*

USE

AI class for managing the state machine of the sim, and also calling actions on state and on pattern



SET UP 

- place component on the agent object to give them artificial (synthetic) intelligence


GENERAL


- sims approach within range

- randomized speed within range

- randomized animations

- probability based behaviour

- make decisions: state machine + probability based personality

- hard code sequences of patterns, and then trigger sequences instead of individual patterns

- patterns can be used to select patterns

- state machine

- to be classy sims will not show any sort of pop up status icons, instead they will communicate their feelings with animations

- if they are displeased, they will shake their head, with their hands on the hips, etc

- we can create our own custom animations if needed, especially if they are stationary, walking, running animations are the hardest



    
EXAMPLE: Animation as the end goal in an "on pattern action" (PATTERN.MEET_SIM)


1. Once done with an action we run RunOnStateActions()

2. We then run our probability decider, or choose a prearranged "pattern"

3. In the first case, let's get a random "pattern"

4. We then check this pattern in RunOnState(Pattern)Actions(), so have a separate one:


RunOnStateActions()
RunOnPatternActions()


(figure out how to easily get animations to start experimenting with the state machine, because just an animation at the end of scope could be the end goal in a large number of cases)


5. When running RunOnPatternActions():

    - that pattern is run in a simple if (pattern.MEET_SIM == PATTERN.MEET_SIM)
                                    else if (pattern.SOMETHING == PATTERN.SOMETHING)


6. In the if statement we place the simple action method we want to call:

    MeetSim()
    {
        // find closes sim's coordinates

        // walk over there and waive to them

        // the animation is the end goal in this example
    }


7. At the end signal we are done with an action to free up the queue, and start on the next action if needed




    
    
*/







/*



class AI
{
    
    public bool run = false;



    public enum STATE
    {
        IDLE,
        WORK,
        SLEEP,
        EAT,
        PURSUE
    }

    STATE state;



    public enum PATTERN
    {
        GET_READY_FOR_WORK,
        WORK_DAY,
        MEET_SIM,
        TEST
    }

    PATTERN pattern;



    // flags

    public bool WORKING = false;
    public bool OWN_HOUSE = false;
    public bool IS_MARRIED = false;
    public bool ENCOUNTERED_SIM = false;






    public MoveSim moveSim; // drag in MoveSim script




    public void Initialize()
    {
        WORKING = true;
        OWN_HOUSE = true;
    }



    void Update()
    {
        RunOnStateActions();
    }



    public bool Run()
    {
        while(run)
        {
            if (CURRENT_STATE == 0)
            {
                Debug.Log("Agent in idle");
            }

            else if (CURRENT_STATE == 1)
            {
                Debug.Log("Agent is moving");
            }
        }
    }



    // to be more efficient run on state actions, instead of constantly checking in update

    public bool RunOnStateActions()
    {
        if (CURRENT_STATE == 0)
        {
            Debug.Log("Agent in idle");
        }

        else if (CURRENT_STATE == 1)
        {
            Debug.Log("Agent is moving");
        }

    } 



    public void RunOnPatternActions()
    {

    }



    // one of the early things we will do, is send sims walking around, and then responding to each other if they are within range

    // for this we will need a OnColliderSimEncounter()


    public void OnColliderSimEncounter(Vector3 pos)
    {
        // when we contact another creature

        // do something like wave, well we would need to turn in their direction

        // TurnInObjectsDirection(), we will probably put this class in the Move Sim class, we will be using rotation already built in

        MoveSim.TurnInObjectsDirection(pos);

        // here let's update the state machine for testing

        ENCOUNTERED_SIM = true;

        Debug.Log("Encountered sim: " + ENCOUNTERED_SIM);

    }
}





*/
