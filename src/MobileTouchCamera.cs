// to create locking functionality

// declare in public scope:

public class MobileTouchCamera : MonoBehaviourWrapped {

    public bool lockCamera = false;
    
    
    // and then in LateUpdate
    
    public void LateUpdate() {

      if (lockCamera) return;

      if (!lockCamera)
      {

      
      //Pinch.
      UpdatePinch(Time.unscaledDeltaTime);

      //Translation.
      UpdatePosition(Time.unscaledDeltaTime);
      }

      if (lockCamera) isRotationLock = true;
      if (!lockCamera)  isRotationLock = false;

      }
}
    
