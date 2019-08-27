using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class BuildingStages : MonoBehaviour
{

    public GameObject building;

    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;

    GameObject GO;

    Quaternion rotation;


    // now one of the upgrades in the research tree could be sped up build time, this is a very valuable upgrade, and adds a true sense of progress to the fun factor



    // add some smoke effects



    public void OnFinalizeBuildingEvent(Quaternion r)
    {
        rotation = r;
        GO = Instantiate(stage1, this.transform.position, rotation, this.transform);
        building.SetActive(false);
        Invoke("Stage2", 4.0f);
    }



    public void Stage2()
    {
        Destroy(GO);
        GO = Instantiate(stage2, this.transform.position, rotation, this.transform);
        Invoke("Stage3", 4.0f);
    }


    public void Stage3()
    {
        // will need some rework for object instantiation pooling, plus we are doing this set active with instantiating maybe a little messy, although not sure if this is not efficient
        Destroy(GO);
        GO = Instantiate(building, this.transform.position, rotation, this.transform);
        building.SetActive(true);
    }


}
