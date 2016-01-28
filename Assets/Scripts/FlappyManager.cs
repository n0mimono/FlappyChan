using UnityEngine;
using System.Collections;

public class FlappyManager : MonoBehaviour {
	public InputManager inputManager;
	public FlappyChan flappyChan;
	public GateSpawner spawner;

	void Start() {
		Initilize ();

		spawner.StartInstantiate ();
	}

	private void Initilize() {
		inputManager.ClickHandler += flappyChan.Jump;
	}

}
