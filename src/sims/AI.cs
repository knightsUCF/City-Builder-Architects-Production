




// place component on the agent object to give them artificial (synthetic) intelligence



/*
    

    - sims approach within range

    - randomized speed within range

    - randomized animations

    - probability based behaviour

    - make decisions: state machine + probability based personality

    - hard code sequences of patterns, and then trigger sequences instead of individual patterns

    - patterns can be used to select patterns

    - state machine

    */



    /*
    
    Example

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
        }





-
    
    
    
    */









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
