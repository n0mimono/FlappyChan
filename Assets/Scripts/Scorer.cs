using UnityEngine;
using System.Collections;
using System;

public class Scorer : MonoBehaviour {
	public int basePoint;
	public event Action<int> OnScore;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.IsLayer (GameManager.Layer.Score)) {
			OnScore (basePoint);
		}
	}

}
