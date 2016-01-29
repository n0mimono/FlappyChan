using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneControl {

	private static SceneControl instance;
	public static SceneControl Instance {
		get {
			if (instance == null) {
				instance = new SceneControl ();
			}
			return instance;
		}
	}

	public enum SceneName {
		Title  = 0,
		InGame = 1,
	}

	public AsyncOperation LoadScene(SceneName name) {
		return SceneManager.LoadSceneAsync (name.ToString ());
	}

	public AsyncOperation ToTitle() {
		return LoadScene (SceneName.Title);
	}

	public AsyncOperation ToInGame() {
		return LoadScene (SceneName.InGame);
	}

}
