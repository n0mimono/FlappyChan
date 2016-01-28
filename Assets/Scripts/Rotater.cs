using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {
	public Vector3 rot;

	void Update() {
		transform.localEulerAngles += rot * Time.deltaTime; 
	}

}
