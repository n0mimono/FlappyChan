﻿using UnityEngine;
using System.Collections;

public class FlappyChan : MonoBehaviour {
	public Rigidbody rigidBody;
	public Vector3 forceJump;

	public void Jump() {
		rigidBody.AddForce (forceJump);
	}

}
