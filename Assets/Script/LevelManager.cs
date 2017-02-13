using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// set level
	public void SetLevel(string level) {
		Debug.Log ("Enter to level: " + level);
		Application.LoadLevel (level);

	}

	public void QuitRequest() {
		Debug.Log ("Quit game.");
		Application.Quit ();
	}
}
