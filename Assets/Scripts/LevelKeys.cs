using UnityEngine;
using System.Collections;

public class LevelKeys : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Progress.UpdatePercentage (0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Debug.Log ("END");
			Application.Quit ();
		} else if (Input.GetKey (KeyCode.F1)) {
			if(LivesScript.DecreaseLives())
				Application.LoadLevel (Application.loadedLevel);

			else Application.Quit (); // substituir por intro
		}
	}
}
