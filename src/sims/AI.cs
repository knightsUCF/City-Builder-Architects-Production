




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











class AI
{

    public bool run = false;


    // state machine


    // flags

    public bool WORKING = false;
    public bool OWN_HOUSE = false;
    public bool IS_MARRIED = false;



    // current state

    public int CURRENT_STATE = 0;

    // 0 - idle
    // 1 - moving to destination
    // 2 - etc




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
}
