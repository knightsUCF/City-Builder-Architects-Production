using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class AI : MonoBehaviour
{


    public GameObject workerAIprefab;
    public Vector3 workerStartPos = new Vector3(0.0f, 4.0f, 0.0f);
    WorkerAI worker;



    void Awake()
    {
        // workerAIcode = FindObjectOfType<WorkerAI>();

    }



    public void MoveWorker(Vector3 destination)
    {
        // we will want to call the WorkerAI class and move a worker

        // we will need two things for this, worker ID, and also the destination

        // we should use a different starting ID point for the AI, so something past the max workers, perhaps starting after 1000
    
        // so in the scene we will have a number of workers generated under the AI

        // let's generate a few



    }



    

    

    GameObject GenerateWorker(Vector3 startPos)
    {
        GameObject workerGO = (GameObject)Instantiate(workerAIprefab, startPos, Quaternion.identity, this.transform);
        return workerGO;
    }


    
    void Start()
    {
        GameObject workerAIgameObject = GenerateWorker(workerStartPos);

        worker = workerAIgameObject.GetComponent<WorkerAI>();

        Vector3 destination = new Vector3(20.0f, 0.0f, 10.0f);

        worker.Move(destination);
    }














    /*
    public int money = 0;
    public float timeBeforeFirstBuild = 3.0f;
    public List<int> aiWorkerIDs = new List<int>();

    public void Build(int structureID, Vector3 pos)
    {

    }


    */


    



}
