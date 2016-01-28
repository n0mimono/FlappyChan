using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Custom;

public class GateSpawner : MonoBehaviour {
	public Gate gatePrefab;
	public float cycle;
	public Vector3 randMag;

	public int maxGateNums;
	private Queue<Gate> gates;

	[System.Serializable]
	public struct TransformBound {
		public Transform upper;
		public Transform lower;

		public void ClampHeight(Transform trans) {
			Vector3 pos = trans.position;
			pos.y = Mathf.Clamp (pos.y, lower.localPosition.y, upper.localPosition.y);
			trans.position = pos;
		}
	}
	public TransformBound bound;

	void Awake() {
		gates = new Queue<Gate> ();
	}

	public void StartInstantiate() {
		StartCoroutine (InstantiateProc ());
	}

	private IEnumerator InstantiateProc() {
		Vector3 interval = -1f * gatePrefab.speed * cycle;

		for (int i = 0; i < 5; i++) {
			yield return StartCoroutine (InstantiateGate ());
			transform.position += interval;
		}

		while (true) {
			yield return StartCoroutine (InstantiateGate ());
			yield return new WaitForSeconds (cycle);
		}
	}

	private IEnumerator InstantiateGate() {
		transform.position += Vector3.Scale (Random.insideUnitSphere, randMag);
		bound.ClampHeight (transform);

		Gate gate = gates.Count > maxGateNums ? gates.Dequeue () : Instantiate (gatePrefab);
		gate.SetPosition (transform);
		gates.Enqueue (gate);

		yield return null;
	}

}
