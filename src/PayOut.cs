using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PayOut : MonoBehaviour
{

    public GameObject[] factories;


    Tokens tokens;

    void Awake()
    {
        tokens = FindObjectOfType<Tokens>();
    }


    public void UpdatePower()
    {

        factories = GameObject.FindGameObjectsWithTag("Factory");

        foreach (GameObject factory in factories)
        {

            if (factory.GetComponent<Factory>().producingEnergy)
            {
                Debug.Log("Adding power");
                Data.energy += 1; // move to tokens later
                tokens.UpdateEnergy();

                // we can assume there will be a worker there if we are producing energy so we can level them up, we could also do this from a separate method later for clarity

                // this will be kind of messy but we will leave this here for now until we refactor

                // the preferred way to be update the worker game object attached to the factory -- how to get to the reference on the game object, can we store the reference here?

                factory.GetComponent<Factory>().workerEngineeringLevel += 1;

                // this also might be messy, but this is how we will update the workers levels in realtime

                factory.GetComponent<Factory>().UpdateLevel();


            }
        }
    }

    
}
