using UnityEngine;
using System.Collections;

public class FlappyManager : MonoBehaviour {
	[Header("Managers")]
	public InputManager inputManager;
	public ScoreManager scoreManager;

	[Header("Objects")]
	public FlappyChan flappyChan;
	public GateSpawner spawner;

	void Start() {
		Initilize ();

		spawner.StartInstantiate ();
	}

	private void Initilize() {
		inputManager.ClickHandler += flappyChan.Jump;

		flappyChan.scorer.OnScore += scoreManager.AddScore;
		scoreManager.OnScore = inputManager.AddScore;
	}

}
