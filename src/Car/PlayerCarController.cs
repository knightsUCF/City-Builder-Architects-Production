using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;




public class PlayerCarController : MonoBehaviour
{



    Screenshake screenshake;


    public GameObject car; // for speed testing
    public GameObject carModel;
    float speed = 0.0f;
    Vector3 lastPosition;


    CarController carController;
    

    int flashCount = 0;
    int maxFlashCount = 10;
    bool flashToggle = false;




    void Awake()
    {
        screenshake = FindObjectOfType<Screenshake>();
        carController = FindObjectOfType<CarController>();
    }



    void OnTriggerStay(Collider c)
    {
        // Debug.Log(c.name);
        // Debug.Log(c.gameObject.layer);
        
        if (c.gameObject.layer == 8 && c.gameObject.tag != "PlayerCar")
        {
            if (carController.speed < 3)
            {
                screenshake.Shake();
            }
        }
    }


    void OnTriggerExit(Collider c)
    {
        // Debug.Log(c.name);
        // Debug.Log(c.gameObject.layer);
    }



    void Update()
    {
        // does this need to be optimized?

        if (carController.speed < 3)
        {
            ResetPositionIfStuck();
        }
    }



    float GetSpeed()
    {
        speed = (transform.position - lastPosition).magnitude / Time.deltaTime;
        lastPosition = transform.position;
        return speed;
    }



    void ResetPositionIfStuck()
    {
        // if (flashCount <  maxFlashCount) InvokeRepeating("FlashCar", 0.0f, 0.5f);

        // on reaching the max flash count reset to 0,0,0 or original position
    }



    void FlashCar()
    {
        flashCount += 1;
        carModel.SetActive(flashToggle);
        flashToggle = !flashToggle;

        // also disable input in case we "move" the invisible car, enable input until after the flash is done
    }


}
