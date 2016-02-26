using UnityEngine;
using System.Collections;

public class Basictargetmover : MonoBehaviour {

	public float spinspeed = 180.0f;
	public float motionmagnitude = 0.1f;

	public bool dospin = true;
	public bool doMotion = false;

		// Update is called once per frame
	void Update () {
	
		if (dospin) {
			// rotate around around the up axis of the gameObject
			gameObject.transform.Rotate (Vector3.up * spinspeed * Time.deltaTime);
		}
		if (doMotion){
		// move up and down over time
		gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionmagnitude);
	}
}
}