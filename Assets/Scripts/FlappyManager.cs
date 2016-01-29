using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Custom;
using UnityEngine.SceneManagement;

public class FlappyManager : MonoBehaviour {
	[Header("Managers")]
	public InputManager inputManager;
	public ScoreManager scoreManager;
	public FadeManager  fadeManager;

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

		ProcState ().StartBy (this);
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
		spawners.ForEach(s => s.StartInstantiate ());
		yield return fadeManager.FadeOut ();

		yield return null;
		cur = State.InGame;
	}
	private IEnumerator StateInGame() {
		while (true) {
			yield return null;
		}
	}
	private IEnumerator StateGameOver() {
		yield return new WaitForSeconds (5f);

		yield return fadeManager.FadeIn ();
		yield return null;

		yield return SceneControl.Instance.ToTitle ();
	}

	private void OnGameOver() {
		cur = State.GameOver;
	}

}

