using UnityEngine;
using System.Collections;

public static class CustomUtility {

	public static Vector3 SetPosition(this MonoBehaviour behav, Transform src) {
		return behav.transform.position = src.position;
	}

}
