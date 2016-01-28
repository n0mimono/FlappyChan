using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {
	public Bar upper;
	public Bar lower;
	public Vector3 speed;

	void Update() {
		transform.position += speed * Time.deltaTime;
	}

}
