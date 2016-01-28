using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Custom;

public class FlappyManager : MonoBehaviour {
	[Header("Managers")]
	public InputManager inputManager;
	public ScoreManager scoreManager;

	[Header("Objects")]
	public FlappyChan flappyChan;
	public List<GateSpawner> spawners;

	public enum State {
		Introduction,
		InGame,
		GameOver,
	}
	private State cur;

	void Start() {
		Initilize ();

		spawners.ForEach(s => s.StartInstantiate ());
	}

	private void Initilize() {
		cur = State.Introduction;

		inputManager.ClickHandler += flappyChan.Jump;

		flappyChan.scorer.OnScore += scoreManager.AddScore;
		flappyChan.scorer.OnCollision += OnGameOver;

		scoreManager.OnScore = inputManager.AddScore;
	}

	private IEnumerator ProcState() {
		yield return StateIntroduction ().StartBy (this);
		yield return StateInGame ().While(() => cur == State.InGame).StartBy (this);
		yield return StateGameOver ().StartBy (this);
	}

	private IEnumerator StateIntroduction() {
		yield return null;
	}
	private IEnumerator StateInGame() {
		yield return null;
	}
	private IEnumerator StateGameOver() {
		yield return null;
	}

	private void OnGameOver() {
		cur = State.GameOver;
	}

}

