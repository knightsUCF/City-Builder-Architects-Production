using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// add to camera, or drag in camera, this is set up to drag onto the camera

public class GyroControl : MonoBehaviour
{
    
    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject camera;
    private Quaternion rot;


    private void Start()
    {
        camera = new GameObject("Camera");
        camera.transform.position = transform.position;
        transform.SetParent(camera.transform);

        gyroEnabled = EnableGyro();
    }


    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            camera.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }
        return false;
    }



    private void Update()
    {
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rot;
        }
    }


}
