using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*

Great this works, but need to wait to start building
until the worker gets there

We instantiate the first stage, and we should make that semi
transparant until the worker gets there

In LOTR there is a percentage

so somehow we need to tie this in to the specific worker




*/


public class HouseBuilding : MonoBehaviour
{

    public GameObject Stage1;
    public GameObject Stage2;
    public GameObject Stage3;
    public GameObject Stage4;

    GameObject go;



    void Start()
    {
        go = Instantiate(Stage1, gameObject.transform.position, Quaternion.identity, this.transform);
        StartCoroutine(GrowToStage2());
    }



    IEnumerator GrowToStage2()
    {
        yield return new WaitForSeconds(Settings.buildTime);

        Destroy(go);
        go = Instantiate(Stage2, gameObject.transform.position, Quaternion.identity, this.transform);
        StartCoroutine(GrowToStage3());
    }



    IEnumerator GrowToStage3()
    {
        yield return new WaitForSeconds(Settings.buildTime);

        Destroy(go);
        go = Instantiate(Stage3, gameObject.transform.position, Quaternion.identity, this.transform);
        StartCoroutine(GrowToStage4());
    }



    IEnumerator GrowToStage4()
    {
        yield return new WaitForSeconds(Settings.buildTime);
        
        Destroy(go);
        go = Instantiate(Stage4, gameObject.transform.position, Quaternion.identity, this.transform);
    }

    
}
