using UnityEngine;
using System.Collections;
using System;

public class InputManager : MonoBehaviour {
	public event Action ClickHandler;

	public void OnClickedPanel() {
		ClickHandler ();
	}

}
