using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {
	public Bar upper;
	public Bar lower;
	public Vector3 speed;

	public void Initilize(Vector3 position) {
		transform.position = position;

		upper.SetRandomAngles ();
		lower.SetRandomAngles ();
	}

	void Update() {
		transform.position += speed * Time.deltaTime;
	}

}
