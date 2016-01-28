using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {
	public Text scoreText;

	public event Action ClickHandler;

	public void OnClickedPanel() {
		ClickHandler ();
	}

	public void AddScore(int curPoint, int addPoint) {
		scoreText.text = curPoint.ToString ();
	}

}
