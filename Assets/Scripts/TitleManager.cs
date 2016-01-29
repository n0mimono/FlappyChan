using UnityEngine;
using System.Collections;

public class TitleManager : MonoBehaviour {

	IEnumerator Start() {
		yield return SceneControl.Instance.ToInGame ();
	}

}
