using UnityEngine;
using System.Collections;

public class Bar : MonoBehaviour {
	public Transform resersal;
	public Transform offset;
	public Transform body;
	public Vector3 randMag;

	public void SetRandomAngles() {
		body.transform.localEulerAngles = Vector3.Scale (Random.insideUnitCircle, randMag);
	}

}
