using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class SimGenerator : MonoBehaviour
{

    public int count = 1;
    public GameObject sim;

    Vector3 pos = Vector3.zero;




    void GenerateSims()
    {
        for (int i = 0; i < count; i++)
        {
            pos.x += 5.0f;
            GameObject GO = Instantiate(sim, pos, Quaternion.identity, this.transform);
        }
    }



    void Start()
    {
        GenerateSims();
    }
    



    
}
