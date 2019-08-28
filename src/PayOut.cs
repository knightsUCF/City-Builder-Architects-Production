using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class PayOut : MonoBehaviour
{

    public GameObject[] factories;
    public GameObject[] houses1;
    public GameObject[] houses2;
    public GameObject[] houses3;


    public int house1rent = 10000;
    public int house2rent = 200;
    public int house3rent = 300;


    Tokens tokens;

    void Awake()
    {
        tokens = FindObjectOfType<Tokens>();
    }


    public void UpdateRent()
    {
        houses1 = GameObject.FindGameObjectsWithTag("House1");
        houses2 = GameObject.FindGameObjectsWithTag("House2");
        houses3 = GameObject.FindGameObjectsWithTag("House3");

        foreach (GameObject house1 in houses1)
        {
            tokens.money += house1rent;
        }

        foreach (GameObject house2 in houses2)
        {
            tokens.money += house2rent;
        }

        foreach (GameObject house3 in houses3)
        {
            tokens.money += house3rent;
        }

        tokens.UpdateMoney();
    }


    public void UpdatePower()
    {

        /* need take this out for now because we are using the factory model for the water plant

        factories = GameObject.FindGameObjectsWithTag("Factory");

        foreach (GameObject factory in factories)
        {

            if (factory.GetComponent<Factory>().producingEnergy && !factory.GetComponent<Factory>().workerOutside)
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

        */
    }

    
}
