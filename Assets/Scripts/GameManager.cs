using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public enum Layer {
		Score = 8,
	}
}

public static class GameManagerExtension {

	public static bool IsLayer(this GameObject go, GameManager.Layer layer) {
		return go.layer == (int)layer;
	}
}
