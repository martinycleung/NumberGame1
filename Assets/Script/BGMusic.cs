using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour {
	static BGMusic instance;
	// Use this for initialization
	void Awake() {
		if (instance != null) {
			Destroy (gameObject);
			Debug.Log ("destory BGMusic");
		} else {
			instance = this;
		}
		GameObject.DontDestroyOnLoad (gameObject);
	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
