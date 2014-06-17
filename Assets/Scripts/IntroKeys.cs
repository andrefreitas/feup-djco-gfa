using UnityEngine;
using System.Collections;

public class IntroKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LivesScript.SetLives (3);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
				Debug.Log ("END");
				Application.Quit ();
		} else if (Input.anyKeyDown) {
			Application.LoadLevel ("main");
		}
	}
}
