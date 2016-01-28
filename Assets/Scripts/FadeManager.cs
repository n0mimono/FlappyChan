using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeManager : MonoBehaviour {
	public Image image;
	
	public CustomYieldInstruction FadeOut() {
		float t = 0f;
		return new  WaitWhile (() => {
			t += Time.deltaTime;
			image.color = new Color(1f, 1f, 1f, 1 - t);
			return t <= 1f;
		});
	}

	public CustomYieldInstruction FadeIn() {
		float t = 0f;
		return new  WaitWhile (() => {
			t += Time.deltaTime;
			image.color = new Color(1f, 1f, 1f, t);
			return t >= 0f;
		});
	}

}
