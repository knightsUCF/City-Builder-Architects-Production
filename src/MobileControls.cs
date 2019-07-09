using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControls : MonoBehaviour {
    Vector3 touchStart;
    public float zoomOutMin = 1;
    public float zoomOutMax = 8;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.touchCount == 2){
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

            float difference = currentMagnitude - prevMagnitude;

            zoom(difference * 0.01f);
        }else if(Input.GetMouseButton(0)){
            Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += direction;
        }
        zoom(Input.GetAxis("Mouse ScrollWheel"));
	}

    void zoom(float increment){
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}


// https://pressstart.vip/tutorials/2018/07/12/44/pan--zoom.html
// https://www.youtube.com/watch?v=0G4vcH9N0gc


/* typical two finger rotation

var rotating: boolean;
var startVector: Vector2;
var rotGestureWidth: float;
var rotAngleMinimum: float;
 
function Update () {
    if (Input.touchCount == 2) {
        if (!rotating) {
            startVector = Input.GetTouch(1).position - Input.GetTouch(0).position;
            rotating = startVector.sqrMagnitude > rotGestureWidth * rotGestureWidth;
        } else {
            var currVector = Input.GetTouch(1).position - Input.GetTouch(0).position;
            var angleOffset = Vector2.Angle(startVector, currVector);
            var LR = Vector3.Cross(startVector, currVector);
           
            if (angleOffset > rotAngleMinimum) {
                if (LR.z > 0) {
                    // Anticlockwise turn equal to angleOffset.
                } else if (LR.z < 0) {
                    // Clockwise turn equal to angleOffset.
                }
            }
           
        }
       
    } else {
        rotating = false;
    }
}

// https://forum.unity.com/threads/rotation-gesture.87308/
*/


