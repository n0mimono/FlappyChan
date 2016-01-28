using UnityEngine;
using System.Collections;
using System;

public class ScoreManager : MonoBehaviour {
	public Action<int,int> OnScore;

	public int Score { private set; get; }

	void Start() {
		Score = 0;
	}

	public void AddScore(int point) {
		Score += point;
		OnScore (Score, point);
	}

}
