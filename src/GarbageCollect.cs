using UnityEngine;
using System.Collections;





// apply to "AreaMarker" prefab



public class GarbageCollect : MonoBehaviour {



	public float timeUntilDestruction = 5.0f;



	void Start ()
  {
		Invoke ("SelfDestruct", timeUntilDestruction);
	}



	void SelfDestruct()
	{
		Destroy (gameObject);
	}

}
